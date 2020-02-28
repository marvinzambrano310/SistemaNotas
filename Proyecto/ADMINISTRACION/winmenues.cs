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
    public partial class winmenues : Form
    {
        public winmenues()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu inicio = new menu();
            inicio.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wininfes estudiante = new wininfes();
            estudiante.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            winnotases n = new winnotases();
            n.Show();
            this.Hide();
        }
    }
}
