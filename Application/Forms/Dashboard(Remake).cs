using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using App.Infrastructure.Context;
using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Forms
{
    public partial class Dashboard_Remake_ : Form
    {
        private static bool _databaseInitialized;
        private readonly List<OperatingSystemSlice> _operatingSystemSlices = new();
        private readonly List<ReportBar> _reportBars = new();
        private readonly Color[] _operatingSystemPalette =
        {
            Color.DeepSkyBlue,
            Color.MediumSpringGreen,
            Color.Gold,
            Color.MediumPurple,
            Color.Coral,
            Color.Turquoise
        };
        private readonly Color _reportBarNewColor = Color.Cyan;
        private readonly Color _reportBarCompletedColor = Color.Lime;
        private ReportRange _selectedReportRange = ReportRange.Weekly;

        public Dashboard_Remake_()
        {
            InitializeComponent();
            Load += Dashboard_Remake__Load;
            panelOperatingSystemChart.Paint += panelOperatingSystemChart_Paint;
            panelWeeklyReportChart.Paint += panelWeeklyReportChart_Paint;
            buttonWeekly.Click += (_, __) => _ = ChangeReportRangeAsync(ReportRange.Weekly);
            buttonMonthly.Click += (_, __) => _ = ChangeReportRangeAsync(ReportRange.Monthly);
            buttonYearly.Click += (_, __) => _ = ChangeReportRangeAsync(ReportRange.Yearly);
            panelOperatingSystemLegend.SizeChanged += (_, __) => RenderOperatingSystemLegend();
            panelOperatingSystemChart.Resize += (_, __) => panelOperatingSystemChart.Invalidate();
            panelWeeklyReportChart.Resize += (_, __) => panelWeeklyReportChart.Invalidate();
            panelBarChartLegend.SizeChanged += (_, __) => RenderReportLegend();
            labelOnHold.Click += (_, __) => OpenClientListWithStatus("On-Hold");
            labelInProgress.Click += (_, __) => OpenClientListWithStatus("In-progress");
            Activated += async (_, __) => await LoadSummaryAsync();
        }

        private async void Dashboard_Remake__Load(object sender, EventArgs e)
        {
            await LoadSummaryAsync();
            await LoadOperatingSystemChartAsync();
            await ChangeReportRangeAsync(_selectedReportRange);
        }

        private async Task LoadSummaryAsync()
        {
            try
            {
                var summary = await Task.Run(() =>
                {
                    using var dbContext = CreateDbContext();
                    var today = DateTime.Today;
                    var reports = dbContext.DamageReports.ToList();

                    var hasUpdates = false;
                    foreach (var report in reports)
                    {
                        if (ShouldExpireNewStatus(report, today))
                        {
                            report.Status = "On-Hold";
                            hasUpdates = true;
                        }
                    }

                    if (hasUpdates)
                    {
                        dbContext.SaveChanges();
                    }

                    return new
                    {
                        NewToday = reports.Count(report => report.DateReceived.Date == today),
                        InProgress = reports.Count(report => string.Equals(report.Status, "In-progress", StringComparison.OrdinalIgnoreCase)),
                        Completed = reports.Count(report => string.Equals(report.Status, "Completed", StringComparison.OrdinalIgnoreCase)),
                        OnHold = reports.Count(report =>
                            string.Equals(report.Status, "On-Hold", StringComparison.OrdinalIgnoreCase) ||
                            string.Equals(report.Status, "[New] On-Hold", StringComparison.OrdinalIgnoreCase))
                    };
                });

                labelNewToday.Text = summary.NewToday.ToString("N0");
                labelInProgress.Text = summary.InProgress.ToString("N0");
                labelCompleted.Text = summary.Completed.ToString("N0");
                labelOnHold.Text = summary.OnHold.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load dashboard summary: {ex.Message}", "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadOperatingSystemChartAsync()
        {
            try
            {
                var operatingSystemData = await Task.Run(() =>
                {
                    using var dbContext = CreateDbContext();

                    return dbContext.DamageReports
                        .AsNoTracking()
                        .Where(report => !string.IsNullOrWhiteSpace(report.OperatingSystem))
                        .GroupBy(report => report.OperatingSystem)
                        .Select(group => new { OperatingSystem = group.Key, Count = group.Count() })
                        .OrderByDescending(group => group.Count)
                        .ToList();
                });

                _operatingSystemSlices.Clear();

                if (operatingSystemData.Count == 0)
                {
                    _operatingSystemSlices.Add(new OperatingSystemSlice("No data", 1, Color.FromArgb(60, 60, 90)));
                }
                else
                {
                    for (var index = 0; index < operatingSystemData.Count; index++)
                    {
                        var item = operatingSystemData[index];
                        var color = _operatingSystemPalette[index % _operatingSystemPalette.Length];
                        _operatingSystemSlices.Add(new OperatingSystemSlice(item.OperatingSystem, item.Count, color));
                    }
                }
                RenderOperatingSystemLegend();
                panelOperatingSystemChart.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load operating system chart: {ex.Message}", "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ChangeReportRangeAsync(ReportRange range)
        {
            _selectedReportRange = range;
            UpdateReportRangeButtons();
            await LoadReportBarsAsync(range);
        }

        private void UpdateReportRangeButtons()
        {
            UpdateReportRangeButton(buttonWeekly, _selectedReportRange == ReportRange.Weekly);
            UpdateReportRangeButton(buttonMonthly, _selectedReportRange == ReportRange.Monthly);
            UpdateReportRangeButton(buttonYearly, _selectedReportRange == ReportRange.Yearly);
        }

        private static void UpdateReportRangeButton(Button button, bool isSelected)
        {
            button.BackColor = isSelected ? Color.FromArgb(90, 90, 130) : Color.FromArgb(60, 60, 90);
            button.ForeColor = Color.White;
            button.FlatAppearance.BorderSize = 0;
        }

        private async Task LoadReportBarsAsync(ReportRange range)
        {
            try
            {
                var bars = await Task.Run(() =>
                {
                    using var dbContext = CreateDbContext();
                    var reports = dbContext.DamageReports
                        .AsNoTracking()
                        .Select(report => new ReportItem(report.DateReceived, report.Status))
                        .ToList();

                    return BuildReportBars(reports, range);
                });

                _reportBars.Clear();
                _reportBars.AddRange(bars);
                panelWeeklyReportChart.Invalidate();
            RenderReportLegend();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load report trend data: {ex.Message}", "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static List<ReportBar> BuildReportBars(List<ReportItem> reports, ReportRange range)
        {
            var today = DateTime.Today;
            var bars = new List<ReportBar>();

            switch (range)
            {
                case ReportRange.Weekly:
                    var startOfWeek = today;
                    while (startOfWeek.DayOfWeek != DayOfWeek.Monday)
                    {
                        startOfWeek = startOfWeek.AddDays(-1);
                    }

                    for (var offset = 0; offset < 7; offset++)
                    {
                        var day = startOfWeek.AddDays(offset);
                        var label = $"{day:ddd}\n{day:dd}";
                        bars.Add(CreateReportBar(label, reports, day, day.AddDays(1)));
                    }
                    break;
                case ReportRange.Monthly:
                    var monthStart = new DateTime(today.Year, today.Month, 1);
                    for (var weekIndex = 0; weekIndex < 4; weekIndex++)
                    {
                        var weekStart = monthStart.AddDays(weekIndex * 7);
                        var weekEnd = weekStart.AddDays(7);
                        bars.Add(CreateReportBar($"Week {weekIndex + 1}", reports, weekStart, weekEnd));
                    }
                    break;
                case ReportRange.Yearly:
                    for (var month = 1; month <= 12; month++)
                    {
                        var label = new DateTime(today.Year, month, 1).ToString("MMM");
                        var monthStartDate = new DateTime(today.Year, month, 1);
                        var monthEndDate = monthStartDate.AddMonths(1);
                        bars.Add(CreateReportBar(label, reports, monthStartDate, monthEndDate));
                    }
                    break;
            }

            return bars;
        }

        private static ReportBar CreateReportBar(string label, List<ReportItem> reports, DateTime start, DateTime end)
        {
            var newCount = reports.Count(report =>
                report.DateReceived.Date >= start && report.DateReceived.Date < end);
            var completedCount = reports.Count(report =>
                report.DateReceived.Date >= start && report.DateReceived.Date < end &&
                string.Equals(report.Status, "Completed", StringComparison.OrdinalIgnoreCase));
            return new ReportBar(label, newCount, completedCount);
        }

        private void panelWeeklyReportChart_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var bounds = panelWeeklyReportChart.ClientRectangle;
            if (bounds.Width <= 0 || bounds.Height <= 0)
            {
                return;
            }

            if (_reportBars.Count == 0)
            {
                DrawEmptyChartMessage(graphics, bounds, "No data");
                return;
            }

            var maxValue = _reportBars.Max(bar => Math.Max(bar.NewCount, bar.CompletedCount));
            if (maxValue <= 0)
            {
                DrawEmptyChartMessage(graphics, bounds, "No data");
                return;
            }

            var scaledMaxValue = Math.Max(1, (int)Math.Ceiling(maxValue * 1.15f));

            var barCount = _reportBars.Count;
            var labelFont = panelWeeklyReportChart.Font;
            Font? customLabelFont = null;
            if (barCount > 10)
            {
                customLabelFont = new Font(labelFont.FontFamily, 7F, labelFont.Style);
                labelFont = customLabelFont;
            }

            var padding = 10;
            var availableHeight = Math.Max(1, bounds.Height - padding * 2);
            var labelLines = _reportBars.Select(bar => bar.Label.Split('\n').Length).DefaultIfEmpty(1).Max();
            var labelPadding = 8;
            var bottomPadding = 10;
            var valueLabelHeight = (int)Math.Ceiling(labelFont.GetHeight(graphics)) + 6;
            var labelHeight = Math.Min(availableHeight, (int)Math.Ceiling(labelFont.GetHeight(graphics) * labelLines) + labelPadding);
            var plotAreaHeight = Math.Max(1, bounds.Height - padding * 2 - labelHeight - bottomPadding - valueLabelHeight);
            var valueAreaTop = bounds.Y + padding;
            var valueAreaBottom = bounds.Y + padding + valueLabelHeight;
            var plotArea = new Rectangle(bounds.X + padding, valueAreaBottom, bounds.Width - padding * 2, plotAreaHeight);
            if (plotArea.Width <= 0)
            {
                customLabelFont?.Dispose();
                return;
            }

            var groupSpacing = 10f;
            var groupWidth = Math.Max(10f, (plotArea.Width - (barCount - 1) * groupSpacing) / barCount);
            var barSpacing = 4f;
            var barWidth = Math.Max(4f, (groupWidth - barSpacing) / 2f);

            using var labelBrush = new SolidBrush(Color.WhiteSmoke);
            using var labelFormat = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Near };

            for (var index = 0; index < barCount; index++)
            {
                var bar = _reportBars[index];
                var groupX = plotArea.X + index * (groupWidth + groupSpacing);
                var newHeight = (float)bar.NewCount / scaledMaxValue * plotArea.Height;
                var completedHeight = (float)bar.CompletedCount / scaledMaxValue * plotArea.Height;

                if (newHeight > 0)
                {
                    var newRect = new RectangleF(groupX, plotArea.Bottom - newHeight, barWidth, newHeight);
                    using var newBrush = new SolidBrush(_reportBarNewColor);
                    graphics.FillRectangle(newBrush, newRect);
                    DrawBarValue(graphics, bar.NewCount, labelFont, labelBrush, newRect, valueAreaTop, valueAreaBottom);
                }

                if (completedHeight > 0)
                {
                    var completedRect = new RectangleF(groupX + barWidth + barSpacing, plotArea.Bottom - completedHeight, barWidth, completedHeight);
                    using var completedBrush = new SolidBrush(_reportBarCompletedColor);
                    graphics.FillRectangle(completedBrush, completedRect);
                    DrawBarValue(graphics, bar.CompletedCount, labelFont, labelBrush, completedRect, valueAreaTop, valueAreaBottom);
                }

                var labelY = bounds.Bottom - padding - labelHeight;
                var labelBounds = new Rectangle((int)groupX, labelY, (int)groupWidth, labelHeight);
                graphics.DrawString(bar.Label, labelFont, labelBrush, labelBounds, labelFormat);
            }

            customLabelFont?.Dispose();
        }

        private static void DrawBarValue(Graphics graphics, int value, Font labelFont, Brush labelBrush, RectangleF barRect, int valueAreaTop, int valueAreaBottom)
        {
            var valueText = value.ToString("N0");
            var textSize = graphics.MeasureString(valueText, labelFont);
            var valueX = barRect.X + (barRect.Width - textSize.Width) / 2f;
            var valueY = Math.Max(valueAreaTop, barRect.Top - textSize.Height - 2f);

            var valueBounds = new RectangleF(valueX, valueY, textSize.Width, textSize.Height);
            graphics.DrawString(valueText, labelFont, labelBrush, valueBounds);
        }

        private void OpenClientListWithStatus(string status)
        {
            using var clientList = new formClientList(status);
            clientList.ShowDialog(this);
        }

        private void RenderReportLegend()
        {
            panelBarChartLegend.SuspendLayout();
            panelBarChartLegend.Controls.Clear();

            var legendItems = new (string Text, Color Color)[]
            {
                ("New", _reportBarNewColor),
                ("Completed", _reportBarCompletedColor)
            };

            var x = 0;
            foreach (var item in legendItems)
            {
                var colorPanel = new Panel
                {
                    BackColor = item.Color,
                    Size = new Size(12, 12),
                    Location = new Point(x, 5)
                };

                var label = new Label
                {
                    AutoSize = true,
                    ForeColor = Color.White,
                    Location = new Point(x + 18, 3),
                    Text = item.Text
                };

                panelBarChartLegend.Controls.Add(colorPanel);
                panelBarChartLegend.Controls.Add(label);

                x += label.PreferredWidth + 30;
            }

            panelBarChartLegend.ResumeLayout();
        }

        private static void DrawEmptyChartMessage(Graphics graphics, Rectangle bounds, string message)
        {
            using var textBrush = new SolidBrush(Color.WhiteSmoke);
            var textSize = graphics.MeasureString(message, SystemFonts.DefaultFont);
            var textLocation = new PointF(
                bounds.X + (bounds.Width - textSize.Width) / 2,
                bounds.Y + (bounds.Height - textSize.Height) / 2);
            graphics.DrawString(message, SystemFonts.DefaultFont, textBrush, textLocation);
        }

        private void RenderOperatingSystemLegend()
        {
            panelOperatingSystemLegend.SuspendLayout();
            panelOperatingSystemLegend.Controls.Clear();

            var legendWidth = Math.Max(0, panelOperatingSystemLegend.ClientSize.Width - 4);
            var total = _operatingSystemSlices.Sum(slice => slice.Count);
            var slices = _operatingSystemSlices.Where(slice => slice.Name != "No data").ToList();
            var remainingPercentage = 100d;

            for (var index = 0; index < _operatingSystemSlices.Count; index++)
            {
                var slice = _operatingSystemSlices[index];
                string percentageText;

                if (total <= 0 || slice.Name == "No data")
                {
                    percentageText = string.Empty;
                }
                else
                {
                    var sliceIndex = slices.IndexOf(slice);
                    if (sliceIndex >= 0 && sliceIndex < slices.Count - 1)
                    {
                        var percentage = Math.Round(slice.Count / (double)total * 100, 1);
                        remainingPercentage -= percentage;
                        percentageText = $" ({percentage:0.#}%)";
                    }
                    else
                    {
                        var percentage = Math.Max(0, Math.Round(remainingPercentage, 1));
                        percentageText = $" ({percentage:0.#}%)";
                    }
                }
                var itemPanel = new Panel
                {
                    BackColor = panelOperatingSystemLegend.BackColor,
                    Height = 20,
                    Width = legendWidth,
                    Margin = new Padding(0, 0, 0, 6)
                };

                var colorPanel = new Panel
                {
                    BackColor = slice.Color,
                    Size = new Size(12, 12),
                    Location = new Point(0, 4)
                };

                var label = new Label
                {
                    AutoSize = true,
                    ForeColor = Color.White,
                    Location = new Point(18, 2),
                    Text = $"{slice.Name}{percentageText}"
                };

                itemPanel.Controls.Add(colorPanel);
                itemPanel.Controls.Add(label);
                panelOperatingSystemLegend.Controls.Add(itemPanel);
            }

            panelOperatingSystemLegend.ResumeLayout();
        }

        private void panelOperatingSystemChart_Paint(object sender, PaintEventArgs e)
        {
            if (_operatingSystemSlices.Count == 0)
            {
                return;
            }

            var graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var bounds = panelOperatingSystemChart.ClientRectangle;
            if (bounds.Width <= 0 || bounds.Height <= 0)
            {
                return;
            }

            var padding = 10;
            var outerBounds = new Rectangle(bounds.X + padding, bounds.Y + padding, bounds.Width - padding * 2, bounds.Height - padding * 2);
            var size = Math.Min(outerBounds.Width, outerBounds.Height);
            var donutBounds = new Rectangle(outerBounds.X + (outerBounds.Width - size) / 2, outerBounds.Y + (outerBounds.Height - size) / 2, size, size);

            var total = _operatingSystemSlices.Sum(slice => slice.Count);
            if (total <= 0)
            {
                return;
            }

            var startAngle = -90f;
            foreach (var slice in _operatingSystemSlices)
            {
                var sweepAngle = (float)slice.Count / total * 360f;
                using var brush = new SolidBrush(slice.Color);
                graphics.FillPie(brush, donutBounds, startAngle, sweepAngle);
                startAngle += sweepAngle;
            }

            var innerSize = (int)(size * 0.55f);
            var innerBounds = new Rectangle(donutBounds.X + (donutBounds.Width - innerSize) / 2, donutBounds.Y + (donutBounds.Height - innerSize) / 2, innerSize, innerSize);
            using var innerBrush = new SolidBrush(panelOperatingSystemChart.BackColor);
            graphics.FillEllipse(innerBrush, innerBounds);

            if (_operatingSystemSlices.Count == 1 && _operatingSystemSlices[0].Name == "No data")
            {
                var text = "No data";
                using var textBrush = new SolidBrush(Color.WhiteSmoke);
                var textSize = graphics.MeasureString(text, Font);
                var textLocation = new PointF(
                    innerBounds.X + (innerBounds.Width - textSize.Width) / 2,
                    innerBounds.Y + (innerBounds.Height - textSize.Height) / 2);
                graphics.DrawString(text, Font, textBrush, textLocation);
            }
        }

        private static AppDbContext CreateDbContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>().Options;
            var dbContext = new AppDbContext(options);

            if (!_databaseInitialized)
            {
                dbContext.Database.Migrate();
                _databaseInitialized = true;
            }

            return dbContext;
        }

        private static bool ShouldExpireNewStatus(DamageReports report, DateTime today)
        {
            return string.Equals(report.Status, "[New] On-Hold", StringComparison.OrdinalIgnoreCase) &&
                report.DateReceived.Date <= today.AddDays(-1);
        }

        private void panelWeeklyReport_Paint(object sender, PaintEventArgs e)
        {

        }

        private sealed record OperatingSystemSlice(string Name, int Count, Color Color);
        private sealed record ReportBar(string Label, int NewCount, int CompletedCount);
        private sealed record ReportItem(DateTime DateReceived, string Status);

        private enum ReportRange
        {
            Weekly,
            Monthly,
            Yearly
        }
    }
}
