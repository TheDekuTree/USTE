using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NathansProgram
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Website_Click(object sender, EventArgs e)
        {
            string websiteName = "http://nathanlaha.azurewebsites.net/index.html";   
            System.Diagnostics.Process.Start("iexplore.exe", websiteName); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string websiteName = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=2FUVGRWSZF8Y4";
            System.Diagnostics.Process.Start("iexplore.exe", websiteName);
           
        }
    }
}
