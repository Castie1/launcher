using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;
using Newtonsoft.Json;
using System.Xml;
using System.Net;
using System.IO;

namespace WindowsFormsApplication1
{
    class autoupdate
    {
        //=========================================================//
        //    Проверка Updater'a на его наличие и сверку CRC32     //
        //=========================================================//
        public void check_updater()
        {
            if (System.IO.File.Exists("updater.exe"))
            {
                Crc32 crc32 = new Crc32();
                String hash = String.Empty;
                using (FileStream fs = File.Open("updater.exe", FileMode.Open))
                    foreach (byte b in crc32.ComputeHash(fs)) hash += b.ToString("x2").ToLower();
                if (hash != "25e0ef5f")
                {
                    MessageBox.Show("Updater будет переустановлен");
                    File.Delete("updater.exe");
                    var client = new WebClient();
                    client.DownloadFileAsync(new Uri(@"http://dle.ru/launcher/updater.exe"), "updater.exe");

                }
            }
            else
            {
                MessageBox.Show("У вас нет Updater, он будет автоматически загружен");
                var client = new WebClient();
                client.DownloadFileAsync(new Uri(@"http://dle.ru/launcher/updater.exe"), "updater.exe");
            }
        }

        //============================================================//
        //Проверка актуальности версии лаунчера и закачка новой версии//
        //============================================================//
        public void search_version()
        {
            try
            {
                double thisversion = Convert.ToDouble(Application.ProductVersion.Replace(".", ""));
                XmlDocument doc;
                doc = new XmlDocument();
                doc.Load("http://dle.ru/launcher/version.xml");
                double newversion = Convert.ToDouble(doc.GetElementsByTagName("myprogram")[0].InnerText.Replace(".", ""));
                if (thisversion < newversion)
                {
                     MessageBox.Show(Program.myForm, "Обнаружена новая версия (" + doc.GetElementsByTagName("myprogram")[0].InnerText + ")" + Environment.NewLine +
                        "Приложение будет автоматически обновлено и перезапущено.", Application.ProductName + " v" + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var client = new WebClient();
                    //client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(download_ProgressChanged);
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(download_Completed);
                    client.DownloadFileAsync(new Uri(@"http://dle.ru/launcher/Launcher.exe"), "temp_Launcher");
                }
            }
            catch (Exception) { }
        }

        //=========================================================//
        //        При завершении закачки запуск Updater            //
        //=========================================================//
        public void download_Completed(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("updater.exe", "temp_Launcher Launcher.exe");
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            catch (Exception) { }
        }

        //=========================================================//
        //       Прогрессбар закачки но пока не нужен              //
        //=========================================================//
        public void download_ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                //progressBar1.Value = e.ProgressPercentage;
            }
            catch (Exception) { }
        }

    }
}
