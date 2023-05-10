using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Configuration;


namespace WindowsFormsApplication1
{
    class Estudiante
    {
        SqlConnection conn;
        string miConexion = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;

        public Estudiante()
        {

        }
        /*
        public void InsertarEstudiante()
        {
            conn = new SqlConnection(miConexion);
            conn.Open();
        }
        */
        public void InsertarEstudiante()
        {
            conn = new SqlConnection(miConexion);
            conn.Open();
        }

    }
}
