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
            System.Windows.Forms.Application.Run(new Menu());
        }
    }
}