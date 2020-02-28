﻿using System;
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
    public partial class WinDatosDoc : Form
    {
        public WinDatosDoc()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            winregdo a = new winregdo();
            a.Show();
            this.Hide();
        }

        private void WinDatosDoc_Load(object sender, EventArgs e)
        {
            SqlConnection cadena = new SqlConnection("data source = femm.database.windows.net,1433; initial catalog = SistemaNotas; user id = Marvin; password = Fundamentos28");
            cadena.Open();
            try
            {
                cadena.Open();
                Console.WriteLine("Conexion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Conexion Fallida");
            }
            string query = "SELECT * FROM DOCENTE";
            try
            {
                SqlCommand cmd = new SqlCommand(query, cadena);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = cmd;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                DatoDocentes.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta" + ex.ToString());
            }
        }
    }
}
