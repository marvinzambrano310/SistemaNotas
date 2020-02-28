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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cadena = new SqlConnection("data source = femm.database.windows.net,1433; initial catalog = SistemaNotas; user id = Marvin; password = Fundamentos28");
            cadena.Open();
            string idmat = textBox13.Text;
            string idadmin = textBox14.Text;
            string idcurso = textBox15.Text;
            string fechamat = textBox16.Text;
            string anolec = textBox17.Text;

            string query = "insert into MATRICULA(IDMATRICULA,IDADMIN,IDCURSO,FECHA,ANOLECTIVO) VALUES ('" + idmat + "','" + idadmin + "','" + idcurso + "','" + fechamat + "','" + anolec + "')";
            SqlCommand cmd = new SqlCommand(query, cadena);
            cmd.ExecuteNonQuery();
            MessageBox.Show("La matricula se ha registrado exitosamente", "Sistema Estudiantil de Notas SEN");
            textBox1.Enabled = true;
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
            textBox12.Enabled = true;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = true;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cadena = new SqlConnection("data source = femm.database.windows.net,1433; initial catalog = SistemaNotas; user id = Marvin; password = Fundamentos28");
            cadena.Open();
            string id = textBox2.Text;
            string matricula = textBox3.Text;
            string pnombre = textBox4.Text;
            string snombre = textBox5.Text;
            string papell = textBox6.Text;
            string sapell = textBox7.Text;
            string genero = textBox8.Text;
            string direc = textBox9.Text;
            string fecha = textBox10.Text;
            string celular = textBox11.Text;
            string tlf = textBox1.Text;
            string email = textBox12.Text;
            string clave = textBox18.Text;
          
            string query = "insert into ESTUDIANTE(IDESTUDIANTE,IDMATRICULA,NOMBRE1ESTUD,NOMBRE2ESTUD,APELPESTUD,APELMESTUD,GENEROESTUD,DIRECCIONESTUD,FECHNACESTUD,CELULAREST,TELEFONOEST,EMAILEST,CLAVEEST) VALUES ('" + id + "','" + matricula + "','" + pnombre + "','" + snombre + "','" + papell + "','" + sapell + "','" + genero + "','" + direc + "','" + fecha + "','" + celular + "','" + tlf + "','" + email+ "','" + clave + "')";
            SqlCommand cmd = new SqlCommand(query, cadena);
            cmd.ExecuteNonQuery();
            MessageBox.Show("El estudiante se ha registrado exitosamente", "Sistema Estudiantil de Notas SEN");
        }

        private void winreges_Load(object sender, EventArgs e)
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
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox1.Enabled = false;
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
            textBox12.Enabled = false;
            textBox13.Enabled = true;
            textBox14.Enabled = true;
            textBox15.Enabled = true;
            textBox16.Enabled = true;
            textBox17.Enabled = true;
            textBox18.Enabled = false;
            button1.Enabled = false;
            textBox13.Focus();
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            DatosEstudiante a = new DatosEstudiante();
            a.Show();
            this.Hide();
        }
    }
}

