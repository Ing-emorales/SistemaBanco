using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal class CD_Conexion
    {
        private SqlConnection conexion = new SqlConnection("Data Source=EMORALES\\SQLEXPRESS;Initial Catalog=db_ferreteria;Integrated Security=True;");

        public SqlConnection AbrirConexion()
        {
            if ( conexion.State == ConnectionState.Closed) 
            conexion.Open();
            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if(conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }

    }
}
