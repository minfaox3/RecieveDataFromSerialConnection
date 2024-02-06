using RecieveDataFromSerialConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecieveDataFromSerialCommunication
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.Owner).about_visible = false;
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            this.Text = ((MainForm)this.Owner).GetValueFromLanguageDictionary("title_about");
        }
    }
}
