using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AGHTestApp
{
    public partial class Form1 : Form
    {
        int ctr = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDoNotTouch_Click(object sender, EventArgs e)
        {
            label1.Text = "Ouch! "+ ctr++;  // a comment with extra text
        }
    }
}
