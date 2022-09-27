using System;
using System.Windows.Forms;

namespace DownloaderApp
{
    internal static class Program
    {
        public static Forms.FormInstaDownloader frmInsta;
        public static Forms.FormYoutubedownloader frmYoutube;
        public static Forms.FormMain frmMain;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmMain = new Forms.FormMain();
            frmInsta = new Forms.FormInstaDownloader();
            frmYoutube = new Forms.FormYoutubedownloader();

            Application.Run(frmMain);
        }
    }
}
