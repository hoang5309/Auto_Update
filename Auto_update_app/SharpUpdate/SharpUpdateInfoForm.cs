using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpUpdate
{
    public partial class SharpUpdateInfoForm : Form
    {
        public SharpUpdateInfoForm(ISharpUpdate applicationInfo, SharpUpdateXml updateInfo)
        {
            InitializeComponent();

            this.lblVersions.Text = String.Format("Current Version: {0} \n Update Version: {1}", 
                applicationInfo.ApplicationAssembly.GetName().Version.ToString(), updateInfo.Version.ToString());
        }
    }
}
