namespace ESPNotice3._0
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        public static bool IsBindEvent = false;
        public static bool bdemo = false;
        public static DateTime demoDate = new DateTime(2025, 1, 1);
        public static String sMsgTitle = "ESP Notice 3.0";
        public static bool bLogin = false;
        public static int iUserCode = 0;
        public static String sUserName = String.Empty;
        public static int iRoleCode = 0;
        public static String sRoleName = String.Empty;
        public static string sStateCode = string.Empty;
        public static string sStateName = string.Empty;
        public static decimal dRelaxed = 0;

        //Declaration for license related variables
        public static string productName = "ESPNotice3.0";
        public static string clientIdentificationId = "espindiapvtltd";
        public static string versionNumber = "01.00.00";
        public static int iTotalLicenseKey = 10;

        public static string sLicenseKeyValue = String.Empty;
        public static string sLicenseKeyValueDefault = "0000-0000-0000-0000-0000-0000-0000-0000";

        /// </summary>
        [STAThread]
        static void Main()
        {
            string InputFilesPath = Properties.Settings.Default.InputFilesPath;
            if (string.IsNullOrEmpty(InputFilesPath))
            { 
                MessageBox.Show("Please configure Input paths", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop); 
                Application.ExitThread();            
            }

            string OutputFilesPath = Properties.Settings.Default.OutputFilesPath;
            if (string.IsNullOrEmpty(OutputFilesPath))
            {
                MessageBox.Show("Please configure Output paths", Program.sMsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.ExitThread();
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}