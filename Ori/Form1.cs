using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string url = toolStripTextBox1.Text.Trim();
                webBrowser2.Url = new Uri(url);
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            string url = toolStripTextBox1.Text.Trim();
            webBrowser2.Url = new Uri(url);
            webBrowser2.Navigate("");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Back
            webBrowser2.GoBack();
            string url = toolStripTextBox1.Text.Trim();
        }

        private void webBrowser2_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabPage1.Text = webBrowser2.Document.Title;
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser2.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser2.Refresh();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser2.Stop();
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {            
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabpage = new TabPage();
            tabpage.Text = "New tab";
            tabControl1.Controls.Add(tabpage);
            WebBrowser nWb = new WebBrowser();
            nWb.Parent = tabpage;
            nWb.Dock = DockStyle.Fill;
            nWb.Navigate("http://www.google.com");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(tabControl1.SelectedTab);
        }
    }
}
