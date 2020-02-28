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
    public partial class winregdo : Form
    {
        public winregdo()
        {
            InitializeComponent();
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
            string asignatura = textBox2.Text;
            string pnombre = textBox3.Text;
            string snombre = textBox4.Text;
            string papell = textBox5.Text;
            string sapell = textBox6.Text;
            string direc = textBox7.Text;
            string celular = textBox8.Text;
            string tlf = textBox9.Text;
            string email = textBox10.Text;
            string fecha = textBox11.Text;
            string clave = textBox12.Text;
            string query = "insert into DOCENTE(IDDOCENTE,IDASIGNATURA,NOMBRE1DOC,NOMBRE2DOC,APELPDOC,APELMDOC,DIRDOCENTE,CELULARDOC,TELEFONODOC,EMAILDOC,FECHNACDOC,CLAVEDOC) VALUES ('" + id + "','" + asignatura + "','" + pnombre + "','" + snombre + "','" + papell + "','" + sapell + "','" + direc + "','" + celular + "','" + tlf + "','" + email + "','" +fecha + "','" + clave + "')";
            try
            {
                SqlCommand cmd = new SqlCommand(query, cadena);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El docente se ha registrado exitosamente", "Sistema Estudiantil de Notas SEN");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Datos de Docente no fueron Ingresados", "Sistema Estudiantil de Notas SEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            WinDatosDoc a = new WinDatosDoc();
            a.Show();
            this.Hide();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox1.Focus();
        }
    }
}
