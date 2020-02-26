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
    public partial class winregad : Form
    {
        public winregad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuad m = new menuad();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            winreges est = new winreges();
            est.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            winregcur cur = new winregcur();
            cur.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WinRegistroDoc docente = new WinRegistroDoc();
            docente.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            winregas asignatura = new winregas();
            asignatura.Show();
            this.Hide();
        }

        private void winregad_Load(object sender, EventArgs e)
        {

        }
    }
}
