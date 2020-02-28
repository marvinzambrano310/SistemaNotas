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
    public partial class wininfcur : Form
    {
        public wininfcur()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            winmenuad m = new winmenuad();
            m.Show();
            this.Hide();
        }

        private void wininfcur_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("1A");
            //comboBox1.Items.Add("6A");
            SqlConnection cadena = new SqlConnection("data source = femm.database.windows.net,1433; initial catalog = SistemaNotas; user id = Marvin; password = Fundamentos28");
            cadena.Open();
            string query = "SELECT IDCURSO from CURSO";
            SqlCommand cmd = new SqlCommand(query, cadena);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            comboBox1.DataSource = tabla;
            comboBox1.DisplayMember = "IDCURSO";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cadena = new SqlConnection("data source = femm.database.windows.net,1433; initial catalog = SistemaNotas; user id = Marvin; password = Fundamentos28");
            cadena.Open();
            string clave = comboBox1.SelectedItem.ToString();
            string query = "select CURSO.IDCURSO,MATRICULA.IDMATRICULA,IDESTUDIANTE,NOMBRE1ESTUD, APELPESTUD FROM ESTUDIANTE,MATRICULA,CURSO WHERE MATRICULA.IDMATRICULA=ESTUDIANTE.IDMATRICULA AND CURSO.IDCURSO='" + comboBox1.Text+ "'";
            SqlCommand cmd = new SqlCommand(query, cadena);
            SqlDataAdapter adaptador = new SqlDataAdapter(query, cadena);
            DataTable ds = new DataTable();
            adaptador.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds;
        }
    }
}
