namespace CapaPresentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JHaF5cWWdCe0x+WmFZfVhgdl9GYVZSRmY/P1ZhSXxVdkFjUX5acHVWTmZfUER9XEE=");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new CP_Login());
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
        }
    }
}