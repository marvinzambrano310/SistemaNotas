﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMINISTRACION
{
    public partial class wininfdo : Form
    {
        public wininfdo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            winmenuad m = new winmenuad();
            m.Show();
            this.Hide();
        }
    }
}
