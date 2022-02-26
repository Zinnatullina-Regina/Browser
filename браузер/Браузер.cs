using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace браузер
{
    public partial class Браузер : Form
    {
        
        public Браузер()
        {
            InitializeComponent();
            //webBrowser1.CanGoBackChanged += new EventHandler(webBrowser1_toolStripLabel1);
           // webBrowser1.CanGoForwardChanged += new EventHandler(webBrowser1_CanGoForwardChanged);
        }

        private void чтотоОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dop dop = new Dop();
            dop.ShowDialog();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        string str;
       
           

        
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            str = toolStrip1.Text.ToString();
            this.webBrowser1.Navigate(str);
            webBrowser1.GoSearch();
        }

       
    }
}
