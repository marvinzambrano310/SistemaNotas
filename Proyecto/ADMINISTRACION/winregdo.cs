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
    public partial class winregdo : Form
    {
        public winregdo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            winregad a = new winregad();
            a.Show();
            this.Hide();
        }
    }
}