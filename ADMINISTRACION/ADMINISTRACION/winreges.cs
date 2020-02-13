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
    public partial class winreges : Form
    {
        public winreges()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            winregad r = new winregad();
            r.Show();
            this.Hide();
        }
    }
}
