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
    public partial class ConsultarAsig : Form
    {
        public ConsultarAsig()
        {
            InitializeComponent();
        }

        private void ConsultarAsig_Load(object sender, EventArgs e)
        {
            SqlConnection cadena = new SqlConnection("data source = femm.database.windows.net,1433; initial catalog = SistemaNotas; user id = Marvin; password = Fundamentos28");
            cadena.Open();
            string query = "SELECT IDASIGNATURA, NOMBRE from ASIGANTURAS";
            SqlCommand cmd = new SqlCommand(query, cadena);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            comboBox1.DataSource = tabla;
            comboBox1.DisplayMember = "NOMBRE";
            comboBox1.ValueMember = "IDASIGNATURA";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            winmenuad a = new winmenuad();
            a.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cadena = new SqlConnection("data source = femm.database.windows.net,1433; initial catalog = SistemaNotas; user id = Marvin; password = Fundamentos28");
            cadena.Open();
            string clave = comboBox1.SelectedItem.ToString();
            string query = "select ASIGANTURAS.IDASIGNATURA,NOMBRE, NOMBRE1DOC, APELPDOC FROM DOCENTE, ASIGANTURA WHERE ASIGANTURAS.IDASIGNATURA=DOCENTE.IDASIGNATURA AND ASIGANTURAS.IDASIGNATURA='" + comboBox1.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(query, cadena);
            SqlDataAdapter adaptador = new SqlDataAdapter(query, cadena);
            DataTable ds = new DataTable();
            adaptador.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
