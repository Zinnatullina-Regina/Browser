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
    public partial class Dop : Form
    {
        public Dop()
        {
            InitializeComponent();
        }
        public int t;
        public Color[] clr = new Color[4];  

        private void Form1_Load(object sender, EventArgs e)
        {
            clr[0] = Color.WhiteSmoke;
            clr[1] = Color.AliceBlue;
            clr[2] = Color.Gray;
            clr[3] = Color.Azure;
           
            t = 0;
            timer1.Start();
            timer1.Interval = 1000;

        }
        private void timer1_Tick(object sender, EventArgs e)  
        {
            splitContainer2.Panel2.BackColor = clr[t];
            t++;
            if (t > 3)
                timer1.Stop();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            help one = new help();
            one.ShowDialog();
        }
    }
    
}
