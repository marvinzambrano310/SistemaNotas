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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {
            CmbUser.Items.Add("ADMINISTRATIVO");
            CmbUser.Items.Add("PROFESOR");
            CmbUser.Items.Add("ESTUDIANTE");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CmbUser.SelectedItem.ToString()=="ADMINISTRATIVO")
            {
                menuad a = new menuad();
                a.Show();
                this.Hide();
            }else if(CmbUser.SelectedItem.ToString() == "PROFESOR")
            {
                Form1 p= new Form1();
                p.Show();
                this.Hide();
            }
        }
    }
}
