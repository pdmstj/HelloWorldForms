using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldForms
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 헬로월드정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            //모달창
            Form formAbout1 = new FormAbout();
            formAbout1.Text = "모달창(Modal)";
            formAbout1.ShowDialog();
            
           //모달리스창
            Form formAbout2 = new FormAbout();
            formAbout2.Text = "모달리스창(Modeless)";
            formAbout2.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limkLabel1_limkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/pdmstj --incognito");
        }
        
    }
}