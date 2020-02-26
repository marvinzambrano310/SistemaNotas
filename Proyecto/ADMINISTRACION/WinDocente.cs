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
    public partial class WinDocente : Form
    {
        public WinDocente()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void WinDocente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaNotasDataSet.DOCENTE' Puede moverla o quitarla según sea necesario.
            this.dOCENTETableAdapter.Fill(this.sistemaNotasDataSet.DOCENTE);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
