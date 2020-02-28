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
    public partial class winregas : Form
    {
        public winregas()
        {
            InitializeComponent();
        }
        int codigo = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            winregad regreso = new winregad();
            regreso.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cadena = new SqlConnection("data source = femm.database.windows.net,1433; initial catalog = SistemaNotas; user id = Marvin; password = Fundamentos28");
            cadena.Open();
            string id = textBox1.Text;
            string nombre = textBox2.Text;
            string query = "insert into ASIGANTURAS(IDASIGNATURA,NOMBRE) VALUES ('" + id + "','"+nombre+"')";
            SqlCommand cmd = new SqlCommand(query, cadena);
            cmd.ExecuteNonQuery();
            MessageBox.Show("LA asignatura se ha registrado exitosamente", "Sistema Estudiantil de Notas SEN");
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text="";
            textBox1.Focus();
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
                string query = "UPDATE ASIGANTURAS SET NOMBRE=@NOMBRE WHERE IDASIGNATURA=@ID";
                SqlCommand cmd = new SqlCommand(query, cadena);
                cmd.Parameters.AddWithValue("@NOMBRE", textBox2.Text);
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
                string sql = "DELETE FROM asidanturas WHERE IDASIGNATURA=@ID";
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
