using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace DownloaderApp.Forms
{
    public partial class FormInstaDownloader : Form
    {
        WebClient webClient = new WebClient();
        Stopwatch stopWatch = new Stopwatch();
        static string URL;
        string LinkDownloadSingleData;
        List<string> ListDownload = new List<string>();
        string startupPath2 = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        Thread thread;
        private IInstaApi InstaApi;



        public FormInstaDownloader()
        {
            InitializeComponent();

            buttonGet.Enabled = false;
            buttonStart.Enabled = false;
            txtSaveLocation.Enabled = false;
            comboboxLinkDownload.Enabled = false;
        }

        private void FormInstaDownloader_Load(object sender, EventArgs e)
        {

        }

        private void FormInstaDownloader_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            Program.frmMain.Visible = true;
            e.Cancel = true;
        }



        //Click events
        private void buttonLogin_Click(object sender, EventArgs e)
        {

            loginInsta();
            if (true)
            {
                buttonGet.Enabled = true;
                txtUrl.Enabled = true;
            }

            /* yerel metot */
            async void loginInsta()
            {
                try
                {
                    loginStatus.Text = "Logging...";
                    var userSession = new UserSessionData()
                    {
                        UserName = textBoxUsername.Text,
                        Password = textBoxPassword.Text,
                    };
                    InstaApi = InstaApiBuilder.CreateBuilder().SetUser(userSession).UseLogger(new DebugLogger(LogLevel.All)).Build();
                    var loginResult = await InstaApi.LoginAsync();
                    if (loginResult.Succeeded == true)
                    {
                        loginStatus.ForeColor = Color.DarkGreen;
                        loginStatus.Text = "Succeess";
                    }
                    else if (loginResult.Value.ToString() == "ChallengeRequired")
                    {
                        loginStatus.ForeColor = Color.Red;
                        loginStatus.Text = "Challenge Required";
                    }
                    else
                    {
                        loginStatus.ForeColor = Color.Red;
                        loginStatus.Text = "Invalid User";
                    }
                }
                catch
                {
                    loginStatus.ForeColor = Color.Red;
                    loginStatus.Text = "Connection Faild";
                }
            }
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {

            checkStructureURL();

            // Apply the rule on the URL and Check the input URL Structure by CheckStructureURL Method
            void checkStructureURL()
            {

                // Apply the rule on the URL
                string patternUrl1 = "^(https://www.instagram.com/p/)";
                System.Text.RegularExpressions.Regex expression1 = new System.Text.RegularExpressions.Regex(patternUrl1);
                string patternUrl2 = "^(https://www.instagram.com/tv/)";
                System.Text.RegularExpressions.Regex expression2 = new System.Text.RegularExpressions.Regex(patternUrl2);
                //Check the input URL Structure
                if (expression1.IsMatch(txtUrl.Text) || expression2.IsMatch(txtUrl.Text))
                {

                    thread = new Thread(new ThreadStart(GetInfo));
                    thread.Start();


                }
                else
                {
                    MessageBox.Show("Invalid URL", "URL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            async void GetInfo()
            {
                LinkDownloadSingleData = String.Empty;
                ListDownload.Clear();

                //try to connect and get information from the url
                try
                {
                    if (loginStatus.Text == "Succeess")
                    {
                        //detail of design
                        URL = txtUrl.Text;
                        btnBrowse.Invoke(new Action(() => buttonGet.Enabled = false));
                        btnBrowse.Invoke(new Action(() => txtUrl.Enabled = false));
                        btnBrowse.Invoke(new Action(() => comboboxLinkDownload.Items.Clear()));
                        btnBrowse.Invoke(new Action(() => txtSaveLocation.Enabled = false));
                        btnBrowse.Invoke(new Action(() => comboboxLinkDownload.Enabled = false));
                        btnBrowse.Invoke(new Action(() => comboboxLinkDownload.Text = String.Empty));
                        btnBrowse.Invoke(new Action(() => btnBrowse.Enabled = false));
                        btnBrowse.Invoke(new Action(() => txtSaveLocation.Text = String.Empty));
                        btnBrowse.Invoke(new Action(() => progressBar1.Value = 0));

                        //set URLdownload to combo box link download
                        try
                        {
                            Uri uri = new Uri(URL);
                            var mediaid = await InstaApi.MediaProcessor.GetMediaIdFromUrlAsync(uri);
                            var media = await InstaApi.MediaProcessor.GetMediaByIdsAsync(mediaid.Value);
                            Console.WriteLine();
                            //get link download as property IGTV
                            if (media.Value[0].ProductType == "igtv")
                            {

                                LinkDownloadSingleData = media.Value[0].Videos[0].Uri.ToString();
                                comboboxLinkDownload.Invoke(new Action(() => comboboxLinkDownload.Text = "This page has a slide (IGTV)"));
                                txtSaveLocation.Invoke(new Action(() => txtSaveLocation.Enabled = true));
                                btnBrowse.Invoke(new Action(() => btnBrowse.Enabled = true));
                                buttonGet.Invoke(new Action(() => buttonGet.Enabled = true));
                                txtUrl.Invoke(new Action(() => txtUrl.Enabled = true));

                            }

                            //get link download as property single display video
                            else if (media.Value[0].MediaType.ToString() == "Video")
                            {

                                LinkDownloadSingleData = media.Value[0].Videos[0].Uri.ToString();
                                comboboxLinkDownload.Invoke(new Action(() => comboboxLinkDownload.Text = "This page has a slide (One Video)"));
                                txtSaveLocation.Invoke(new Action(() => txtSaveLocation.Enabled = true));
                                btnBrowse.Invoke(new Action(() => btnBrowse.Enabled = true));
                                buttonGet.Invoke(new Action(() => buttonGet.Enabled = true));
                                txtUrl.Invoke(new Action(() => txtUrl.Enabled = true));

                            }

                            //get link download as property single display Image
                            else if (media.Value[0].MediaType.ToString() == "Image")
                            {

                                LinkDownloadSingleData = media.Value[0].Images[0].Uri.ToString();
                                comboboxLinkDownload.Invoke(new Action(() => comboboxLinkDownload.Text = "This page has a slide (one Image)"));
                                txtSaveLocation.Invoke(new Action(() => txtSaveLocation.Enabled = true));
                                btnBrowse.Invoke(new Action(() => btnBrowse.Enabled = true));
                                buttonGet.Invoke(new Action(() => buttonGet.Enabled = true));
                                txtUrl.Invoke(new Action(() => txtUrl.Enabled = true));

                            }


                            //get as property multi display picture and Video
                            else if (media.Value[0].MediaType.ToString() == "Carousel")
                            {



                                for (int i = 0; i < media.Value[0].Carousel.Count; i++)
                                {

                                    if (media.Value[0].Carousel[i].MediaType.ToString() == "Image")
                                    {

                                        ListDownload.Add(media.Value[0].Carousel[i].Images[0].Uri.ToString());
                                        comboboxLinkDownload.Invoke(new Action(() => comboboxLinkDownload.Items.Add("Slide " + (i + 1) + " ( Image )")));

                                    }
                                    else
                                    {
                                        ListDownload.Add(media.Value[0].Carousel[i].Videos[0].Uri.ToString());
                                        comboboxLinkDownload.Invoke(new Action(() => comboboxLinkDownload.Items.Add("Slide " + (i + 1) + " ( Video )")));

                                    }

                                }
                                comboboxLinkDownload.Invoke(new Action(() => comboboxLinkDownload.Text = "The Pages added"));
                                txtSaveLocation.Invoke(new Action(() => txtSaveLocation.Enabled = true));
                                comboboxLinkDownload.Invoke(new Action(() => comboboxLinkDownload.Enabled = true));
                                btnBrowse.Invoke(new Action(() => btnBrowse.Enabled = true));
                                buttonGet.Invoke(new Action(() => buttonGet.Enabled = true));
                                txtUrl.Invoke(new Action(() => txtUrl.Enabled = true));

                            }
                        }
                        catch
                        {
                            string errortypechoice = "Invalid URL";
                            labelPrgrs.Invoke(new Action(() => labelPrgrs.Text = "0" + "%"));
                            txtUrl.Invoke(new Action(() => txtUrl.Enabled = true));
                            buttonGet.Invoke(new Action(() => buttonGet.Enabled = true));
                            MessageBox.Show(errortypechoice, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please login first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                catch
                {
                    labelPrgrs.Invoke(new Action(() => labelPrgrs.Text = "0" + "%"));
                    txtUrl.Invoke(new Action(() => txtUrl.Enabled = true));
                    buttonGet.Invoke(new Action(() => buttonGet.Enabled = true));
                    MessageBox.Show("can not connect in the server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }





            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {


                //Show Save File Dialog and get the file name from the URL and set to txtSaveLocation
                saveFileDialog.Filter = "All File|*.*";
                if (!string.IsNullOrEmpty(LinkDownloadSingleData))
                {
                    Uri uri = new Uri(LinkDownloadSingleData);
                    string filename = System.IO.Path.GetFileName(uri.LocalPath);
                    saveFileDialog.FileName = filename;
                    saveFileDialog.InitialDirectory = @"C:\";
                    saveFileDialog.ShowDialog();
                    string selectedPath = saveFileDialog.FileName;
                    txtSaveLocation.Text = selectedPath;
                    buttonStart.Enabled = true;
                }
                else
                {

                    Uri uri = new Uri(ListDownload[comboboxLinkDownload.SelectedIndex]);

                    string filename = System.IO.Path.GetFileName(uri.LocalPath);
                    saveFileDialog.FileName = filename;
                    saveFileDialog.InitialDirectory = @"C:\";
                    saveFileDialog.ShowDialog();
                    string selectedPath = saveFileDialog.FileName;
                    txtSaveLocation.Text = selectedPath;
                    buttonStart.Enabled = true;
                }


            }
            catch
            {

                MessageBox.Show("Please check your URL!", "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            switch (buttonStart.Text)
            {
                case "Start Download":
                    startDownload();
                    break;


                case "Stop Download":
                    stopDownload();
                    break;
            }

            buttonGet.Enabled = false;
            buttonStart.Enabled = false;


            /* yerel metotlar */
            void startDownload()
            {

                //check the type of data and pass link download to downloader method
                if (!string.IsNullOrEmpty(LinkDownloadSingleData))
                {
                    downloaderMethod(LinkDownloadSingleData);
                    buttonStart.Text = "Stop Download";
                    buttonStart.BackColor = Color.LimeGreen;
                }
                else
                {
                    downloaderMethod(ListDownload[comboboxLinkDownload.SelectedIndex]);
                    buttonStart.Text = "Stop Download";
                    buttonStart.BackColor = Color.LimeGreen;

                }

            }

            void stopDownload()
            {

                if (webClient.IsBusy)
                {
                    webClient.CancelAsync();
                }

                labelPrgrs.Text = "0" + "%";
                progressBar1.Value = 0;
                labelPrgrs.Text = String.Empty;
                comboboxLinkDownload.Text = String.Empty;
                btnBrowse.Enabled = false;
                txtSaveLocation.Enabled = false;
                buttonStart.Text = "Start Download";
                comboboxLinkDownload.Enabled = false;
                txtUrl.Enabled = true;
                buttonGet.Enabled = true;
                txtSaveLocation.Text = String.Empty;
                LinkDownloadSingleData = String.Empty;
                buttonStart.Enabled = false;
                ListDownload.Clear();
                comboboxLinkDownload.Items.Clear();

            }

            void downloaderMethod(string URL)
            {
                try
                {


                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);

                    // Start the stopwatch which we will be using to calculate the download speed
                    stopWatch.Start();



                    Uri imguri = new Uri(URL);
                    webClient.DownloadFileAsync(imguri, txtSaveLocation.Text);

                }
                catch
                {
                    MessageBox.Show("Connection Lost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        // Download File Completed Events
        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // Reset the stopwatch.
            stopWatch.Reset();

            if (e.Cancelled == true)
            {

            }
            else
            {
                buttonStart.Enabled = false;
                labelPrgrs.Text = String.Empty;
                btnBrowse.Enabled = false;
                buttonStart.Text = "Start Download";
                labelPrgrs.Text = "100" + " %";
                comboboxLinkDownload.Text = String.Empty;
                comboboxLinkDownload.Enabled = false;
                txtUrl.Enabled = true;
                buttonGet.Enabled = true;
                txtSaveLocation.Enabled = false;
                txtSaveLocation.Text = String.Empty;
                LinkDownloadSingleData = String.Empty;
                buttonStart.Enabled = false;
                ListDownload.Clear();
                comboboxLinkDownload.Items.Clear();

            }
        }
        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

            // Update the progressbar percentage only when the value is not the same.
            progressBar1.Value = e.ProgressPercentage;

            // Show the percentage on our label.
            labelPrgrs.Text = e.ProgressPercentage.ToString() + " %";
        }

    }
}
