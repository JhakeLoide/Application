using Application.Forms;
using System.Windows.Forms;
namespace Final_Project
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var context = new ApplicationContext();
            var loadingScreen = new LoadingScreen();
            loadingScreen.LoadingCompleted += (_, __) =>
            {
                var menu = new Menu();
                menu.FormClosed += (_, __) => context.ExitThread();
                context.MainForm = menu;
                menu.Show();
                loadingScreen.Close();
            };

            context.MainForm = loadingScreen;
            loadingScreen.Show();
            System.Windows.Forms.Application.Run(context);
        }
    }
}