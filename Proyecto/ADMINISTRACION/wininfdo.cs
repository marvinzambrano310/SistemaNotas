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
    public partial class wininfdo : Form
    {
        int codigo = 0;
        public wininfdo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            winmenuad m = new winmenuad();
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cadena = new SqlConnection("data source = femm.database.windows.net,1433; initial catalog = SistemaNotas; user id = Marvin; password = Fundamentos28");
            cadena.Open();
            string clave = textBox1.Text;
            string query = "select * FROM DOCENTE WHERE IDDOCENTE='" + clave + "'";
            SqlCommand cmd = new SqlCommand(query, cadena);
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.Read())
            {
                textBox2.Text = registro["NOMBRE1DOC"].ToString();
                textBox3.Text = registro["NOMBRE2DOC"].ToString();
                textBox4.Text = registro["APELPDOC"].ToString();
                textBox5.Text = registro["APELMDOC"].ToString();
                textBox6.Text = registro["DIRDOCENTE"].ToString();
                textBox7.Text = registro["CELULARDOC"].ToString();
                textBox8.Text = registro["TELEFONODOC"].ToString();
                textBox9.Text = registro["EMAILDOC"].ToString();
                textBox10.Text = registro["FECHNACDOC"].ToString();
            }
            else
            {
                MessageBox.Show("No se ha encontrado el registro", "Sistema Estudiantil de Notas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                textBox1.Text = null;
                textBox1.Focus();
            }
        }

        private void wininfdo_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

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
            string id = textBox1.Text;
            string pnombre = textBox2.Text;
            string snombre = textBox3.Text;
            string papell = textBox4.Text;
            string sapell = textBox5.Text;
            string direccion = textBox6.Text;
            string celular = textBox7.Text;
            string telefono = textBox8.Text;
            string email = textBox9.Text;
            string fecha = textBox10.Text;
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
                string query = "UPDATE DOCENTE SET NOMBRE1DOC=@NOMBRE1,NOMBRE2DOC=@NOMBRE2,APELPDOC=@APELL1,APELMDOC=@APEL2,DIRDOCENTE=@DIRECCION,CELULARDOC=@CELULAR,TELEFONODOC=@TELEFONO,EMAILDOC=@EMAIL,FECHNACDOC=@FECHA WHERE IDDOCENTE=@ID";
                SqlCommand cmd = new SqlCommand(query, cadena);
                cmd.Parameters.AddWithValue("@NOMBRE1", textBox2.Text);
                cmd.Parameters.AddWithValue("@NOMBRE2", textBox3.Text);
                cmd.Parameters.AddWithValue("@APELL1", textBox4.Text);
                cmd.Parameters.AddWithValue("@APEL2", textBox5.Text);
                cmd.Parameters.AddWithValue("@DIRECCION", textBox6.Text);
                cmd.Parameters.AddWithValue("@CELULAR", textBox7.Text);
                cmd.Parameters.AddWithValue("@TELEFONO", textBox8.Text);
                cmd.Parameters.AddWithValue("@EMAIL", textBox9.Text);
                cmd.Parameters.AddWithValue("@FECHA", textBox10.Text);
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
                string sql = "DELETE FROM DOCENTE WHERE IDDOCENTE=@ID";
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
        }
    }
}
