using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FishMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateLbl.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLbl.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
