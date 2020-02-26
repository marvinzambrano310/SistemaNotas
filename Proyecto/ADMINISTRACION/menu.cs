using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            if (CmbUser.SelectedItem.ToString()=="ADMINISTRATIVO" && textBox2.Text==TextBoxClave.Text)
            {
                menuad a = new menuad();
                a.Show();
                this.Hide();
            }else if(CmbUser.SelectedItem.ToString() == "PROFESOR")
            {
                Form1 p= new Form1();
                p.Show();
                this.Hide();
            }else if (CmbUser.SelectedItem.ToString() == "ESTUDIANTE")
            {
                winmenues estudiante = new winmenues();
                estudiante.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cadena = new SqlConnection("data source = femm.database.windows.net,1433; initial catalog = SistemaNotas; user id = Marvin; password = Fundamentos28");
            cadena.Open();
            string clave = textBox2.Text;
            string query = "select CLAVEADMIN FROM ADMINISTRADOR WHERE CLAVEADMIN='" + clave+"'";
            SqlCommand cmd = new SqlCommand(query, cadena);
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.Read())
            {
                TextBoxClave.Text = registro["CLAVEADMIN"].ToString();
            }
            button1.Visible = true;
            button3.Visible = false;
            }
    }
}
