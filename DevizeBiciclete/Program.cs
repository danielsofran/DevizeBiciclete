using DevizeBiciclete.Test;
using DevizeBiciclete.Domain;

namespace DevizeBiciclete
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DevizSetari.Logo.Save("logo.png");
            TestDomain.Run();
            //Application.Run(new TestForm());
        }
    }
}