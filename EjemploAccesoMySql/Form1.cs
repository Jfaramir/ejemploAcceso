using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Odbc;
using MySql.Data.Types;
using MySql.Data.MySqlClient;

namespace EjemploAccesoMySql
{
    public partial class Form1 : Form
    {
        private MySqlConnection conexion;
        private static MySqlCommand comando;
        private String consulta;
        private MySqlDataReader resultado;
        private DataTable datos = new DataTable();

        public Form1()
        {
            InitializeComponent();

            conexion = new MySqlConnection("Server = 127.0.0.1; Database = discografica; Uid = root; Pwd=;");
            conexion.Open();

            comando = new MySqlCommand("Select * from album", conexion);
            resultado = comando.ExecuteReader();

            datos.Load(resultado);
            dataGridView1.DataSource = datos;
        }
    }
}
