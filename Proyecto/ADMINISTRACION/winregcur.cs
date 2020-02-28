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
    public partial class winregcur : Form
    {
        public winregcur()
        {
            InitializeComponent();
        }
        int codigo=0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            winregad a = new winregad();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cadena = new SqlConnection("data source = femm.database.windows.net,1433; initial catalog = SistemaNotas; user id = Marvin; password = Fundamentos28");
            cadena.Open();
            string id = textBox1.Text;
            string nombre = textBox2.Text;
            string jornada = textBox3.Text;
            string especial = textBox4.Text;
            string paralelo = textBox5.Text;
            string query = "insert into CURSO(IDCURSO,NOMBRECURSO,JORNADA,ESPECIALIDAD,PARALELO) VALUES ('" + id + "','" + nombre + "','"+jornada+"','"+especial+"','"+paralelo+"')";
            SqlCommand cmd = new SqlCommand(query, cadena);
            cmd.ExecuteNonQuery();
            MessageBox.Show("El curso se ha registrado exitosamente", "Sistema Estudiantil de Notas SEN");
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Focus();
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            DatosCurso a = new DatosCurso();
            a.Show();
            this.Hide();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            button4.Enabled = true;
            codigo = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            codigo = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (codigo == 1)
            {
                SqlConnection cadena = new SqlConnection("data source = femm.database.windows.net,1433; initial catalog = SistemaNotas; user id = Marvin; password = Fundamentos28");
                cadena.Open();
                string query = "UPDATE CURSO SET NOMBRECURSO=@NOMBRE,JORNADA=@JOR,ESPECIALIDAD=@ESPE,PARALELO=@PARA WHERE IDCURSO=@ID";
                SqlCommand cmd = new SqlCommand(query, cadena);
                cmd.Parameters.AddWithValue("@NOMBRE", textBox2.Text);
                cmd.Parameters.AddWithValue("@JOR", textBox3.Text);
                cmd.Parameters.AddWithValue("@ESPE", textBox4.Text);
                cmd.Parameters.AddWithValue("@PARA", textBox5.Text);
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
                string sql = "DELETE FROM CURSO WHERE IDCURSO=@ID";
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
            textBox1.Enabled = true;
            textBox2.Text = "";
            textBox1.Focus();
            button4.Enabled = false;
        }
    }
}
