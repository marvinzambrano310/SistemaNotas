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
    public partial class wininformaciones : Form
    {
        public wininformaciones()
        {
            InitializeComponent();
        }
        int codigo = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            winmenues regreso = new winmenues();
            regreso.Show();
            this.Hide();
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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox1.Focus();
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            codigo = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            codigo = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (codigo == 1)
            {
                SqlConnection cadena = new SqlConnection("data source = femm.database.windows.net,1433; initial catalog = SistemaNotas; user id = Marvin; password = Fundamentos28");
                cadena.Open();
                string query = "UPDATE ESTUDIANTE SET NOMBRE1ESTUD=@NOMBRE1,NOMBRE2ESTUD=@NOMBRE2,APELPESTUD=@APELL1,APELESTUD=@APEL2,GENEROESTUD=@GENERO,DIRECCIONESTUD=@DIRECCION,FECHNACESTUD=@FECHA,CELULAREST=@CELULAR,TELEFONOEST=@TELEFONO,EMAILEST=@EMAIL WHERE IDESTUDIANTE=@ID";
                SqlCommand cmd = new SqlCommand(query, cadena);
                cmd.Parameters.AddWithValue("@NOMBRE1", textBox2.Text);
                cmd.Parameters.AddWithValue("@NOMBRE2", textBox3.Text);
                cmd.Parameters.AddWithValue("@APELL1", textBox4.Text);
                cmd.Parameters.AddWithValue("@APEL2", textBox5.Text);
                cmd.Parameters.AddWithValue("@GENERO", textBox6.Text);
                cmd.Parameters.AddWithValue("@DIRECCION", textBox7.Text);
                cmd.Parameters.AddWithValue("@FECHA", textBox11.Text);
                cmd.Parameters.AddWithValue("@CELULAR", textBox8.Text);
                cmd.Parameters.AddWithValue("@TELEFONO", textBox9.Text);
                cmd.Parameters.AddWithValue("@EMAIL", textBox10.Text);
                cmd.Parameters.AddWithValue("@ID", textBox1.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    cadena.Close();
                    MessageBox.Show("Registro actualizado correctamente !");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la Actualizacion", "Sistema Estudiantil de Notas 'SEN'", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            if (codigo == 2)
            {
                SqlConnection cadena = new SqlConnection("data source = femm.database.windows.net,1433; initial catalog = SistemaNotas; user id = Marvin; password = Fundamentos28");
                cadena.Open();
                string sql = "DELETE FROM ESTUDIANTE WHERE IDESTUDIANTE=@ID";
                SqlCommand cmd = new SqlCommand(sql, cadena);
                cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    cadena.Close();
                    MessageBox.Show("Registro eliminado correctamente !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en Borrar Datos", "Sistema Estudiantil de Notas 'SEN'", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox1.Focus();
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
        }

        private void wininformaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
