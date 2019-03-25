using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AppUnoTallerDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) {
            string query_persona = "INSERT INTO Personas VALUES(" + nombre_txt.Text + "," +
                apellidos_txt.Text + "," +
                calle_txt.Text + "," +
                noext_txt.Text + "," +
                poblacion_txt.Text + "," +
                pais_txt.Text + "," +
                fechanac_txt.Text + "," +
                curp_txt.Text + ")";
            SQLConn.SQLConn.OpenConnection();
            SQLConn.SQLConn.ExecuteQuery(query_persona);
            try
            {
                SqlDataReader list = SQLConn.SQLConn.ExecuteQuery("SELECT * FROM Personas");
                Console.WriteLine(list['id']);
            } catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            string query_alumno = "INSERT INTO Personas VALUES(" + numcontrol_txt.Text + "," +
                escuelaprocede_txt.Text + "," +
                 + ")";
            SQLConn.SQLConn.ExecuteQuery(query_persona);
        }
    }
}
