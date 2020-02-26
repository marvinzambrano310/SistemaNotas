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
    public partial class WinRegistroDoc : Form
    {
        public WinRegistroDoc()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            winregad a = new winregad();
            a.Show();
            this.Hide();
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            WinDocente a = new WinDocente();
            a.ShowDialog();
        }
    }
}
