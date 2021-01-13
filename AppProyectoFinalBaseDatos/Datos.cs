using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Npgsql;
using System.Windows.Forms;

namespace AppProyectoFinalBaseDatos
{
   
    class Datos
    {
        static string server;
        static string cadenaConexion;
        static SqlConnection ConexionSQL;
        static MySqlConnection conexionMySQL;
        static NpgsqlConnection conexionPOSTGRE;

        public static void EstablecerConexion(string coneccionSolicitada)
        {
            switch (coneccionSolicitada)
            {
                //Caso 1: Cuando elegimos conectarnos al sql server
            case "SQL SERVER":
            cadenaConexion = "Server=localhost\\SQLEXPRESS;Database = ProyectoFinalHospital; Trusted_Connection = True;";
            ConexionSQL = new SqlConnection(cadenaConexion);
            MessageBox.Show("☀ Success ☀");
            server = "SQL SERVER ELEGIDO";
            break;

               //Caso 2: cuando elegimos conectarnos al postgre sql
            case "POSTGRE SQL":
            cadenaConexion = "Server = localhost;User id= postgres; Password = ilv12065amo; Database = ProyectoFinalHospital;";
            conexionPOSTGRE = new NpgsqlConnection(cadenaConexion);
            MessageBox.Show("☀ Success ☀");
            server = "POSTGRE SQL ELEGIDO";
            break;

                //Caso 3: cuando elegimos conectarnos al Maria db
            case "MARIA DB":
            cadenaConexion= "Server = localhost; Port = 1234; Database = ProyectoFinalHospital; Uid = root; Pwd = ilv12065amo; SslMode = Preferred;";
            conexionMySQL = new MySqlConnection(cadenaConexion);
            MessageBox.Show("☀ Success ☀");
            server = "MARIA DB ELEGIDO";
            break;
            }
        }


        public static void AgregarDataTable(DataSet ds, string consulta, string nombreTabla, DataGridView DataGridView1)
        {
            if (server == "SQL SERVER ELEGIDO")
            {
                SqlDataAdapter da = new SqlDataAdapter(consulta, cadenaConexion);
                ds = new DataSet();
                da.Fill(ds, nombreTabla);
                DataGridView1.DataSource = ds.Tables["Hospital"];
            }
            else if (server == "POSTGRE SQL ELEGIDO")
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(consulta, cadenaConexion);
                ds = new DataSet();
                da.Fill(ds, nombreTabla);
                DataGridView1.DataSource = ds.Tables["Hospital"];
            }
            else if (server == "MARIA DB ELEGIDO")
            {
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, cadenaConexion);
                ds = new DataSet();
                da.Fill(ds, nombreTabla);
                DataGridView1.DataSource = ds.Tables["Hospital"];
            }


        }
        static int registroAfectados = 0;
        public static int EjecutarComando(string consulta)
        {
            //Primer if: cuando utilizamos SQL server
            if (server == "SQL SERVER ELEGIDO")
            {

                SqlCommand comando = new SqlCommand(consulta, ConexionSQL);
                ConexionSQL.Open();
                registroAfectados = comando.ExecuteNonQuery();
                ConexionSQL.Close();

            }
            //Segundo if: cuando utilizamos Postgre SQL
           else if (server == "POSTGRE SQL ELEGIDO")
                {
                    NpgsqlCommand comando = new NpgsqlCommand(consulta, conexionPOSTGRE);
                    conexionPOSTGRE.Open();
                    registroAfectados = comando.ExecuteNonQuery();
                    conexionPOSTGRE.Close();
                }
            //Tercer if: cuando utilizamos Maria DB
            else if (server == "MARIA DB ELEGIDO")
            {
                MySqlCommand comando = new MySqlCommand(consulta, conexionMySQL);
                conexionMySQL.Open();
                registroAfectados = comando.ExecuteNonQuery();
                conexionMySQL.Close();
            }
            return registroAfectados;
            
        }

    }
}
 
