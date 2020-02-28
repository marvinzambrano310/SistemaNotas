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
    public partial class wininfes : Form
    {
        public wininfes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cadena = new SqlConnection("data source = femm.database.windows.net,1433; initial catalog = SistemaNotas; user id = Marvin; password = Fundamentos28");
            cadena.Open();
            string clave = textBox1.Text;
            string query = "select * FROM ESTUDIANTE WHERE IDESTUDIANTE='" + clave + "'";
            SqlCommand cmd = new SqlCommand(query, cadena);
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.Read())
            {
                textBox2.Text = registro["NOMBRE1ESTUD"].ToString();
                textBox3.Text = registro["NOMBRE2ESTUD"].ToString();
                textBox4.Text = registro["APELPESTUD"].ToString();
                textBox5.Text = registro["APELMESTUD"].ToString();
                textBox6.Text = registro["GENEROESTUD"].ToString();
                textBox7.Text = registro["DIRECCIONESTUD"].ToString();
                textBox8.Text = registro["FECHNACESTUD"].ToString();
                textBox9.Text = registro["CELULAREST"].ToString();
                textBox10.Text = registro["TELEFONOEST"].ToString();
                textBox11.Text = registro["EMAILEST"].ToString();

            }
            else
            {
                MessageBox.Show("No se ha encontrado el registro", "Sistema Estudiantil de Notas");
                textBox1.Text = null;
                textBox1.Focus();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void wininfes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            winmenuad m = new winmenuad();
            m.Show();
            this.Hide();
        }
    }
}
