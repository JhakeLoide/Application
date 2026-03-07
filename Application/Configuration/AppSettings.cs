using System;
using System.IO;
using System.Text.Json;

namespace Final_Project.Configuration
{
    internal static class AppSettings
    {
        private static readonly string SettingsPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Final_Project",
            "settings.json");

        public static string StartupPage { get; set; } = "Menu";

        public static void Load()
        {
            if (!File.Exists(SettingsPath))
            {
                return;
            }

            try
            {
                var json = File.ReadAllText(SettingsPath);
                var stored = JsonSerializer.Deserialize<StoredSettings>(json);
                if (!string.IsNullOrWhiteSpace(stored?.StartupPage))
                {
                    StartupPage = stored.StartupPage;
                }
            }
            catch
            {
                StartupPage = "Menu";
            }
        }

        public static void Save()
        {
            var directory = Path.GetDirectoryName(SettingsPath);
            if (!string.IsNullOrWhiteSpace(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var stored = new StoredSettings
            {
                StartupPage = StartupPage
            };

            var json = JsonSerializer.Serialize(stored, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(SettingsPath, json);
        }

        private sealed class StoredSettings
        {
            public string? StartupPage { get; set; }
        }
    }
}
