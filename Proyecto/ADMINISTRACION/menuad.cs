using System;
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
    public partial class menuad : Form
    {
        public menuad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            winmenuad m = new winmenuad();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            winregad r = new winregad();
            r.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
            this.Hide();
        }
    }
}
