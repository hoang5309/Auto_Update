using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpUpdate
{
    public partial class DownloadFTP : Form
    {
        public DownloadFTP(int NV)
        {
            InitializeComponent();
            this.Version.Text = "Version: " + NV;
            this.Show();
            WebClient wc = new WebClient();

            string remoteUri = "https://dataconsulate.neteffx.net/DataConsulate";
            try
            {
                wc.DownloadFile(remoteUri, "Test.txt");
                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Error");
            }
        }
    }
}
