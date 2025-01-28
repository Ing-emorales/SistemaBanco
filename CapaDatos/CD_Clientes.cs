using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Clientes
    {
       private CD_Conexion cd_conexion = new CD_Conexion();

       public DataTable MostrarClientes()
        {
            string QueryMostrarClientes = "usp_clientes_mostrar";
            SqlDataAdapter AdapterClientes = new SqlDataAdapter(QueryMostrarClientes, cd_conexion.AbrirConexion());
            DataTable dtMostrarClientes = new DataTable();
            AdapterClientes.Fill(dtMostrarClientes);
            cd_conexion.CerrarConexion();
            return dtMostrarClientes;
        }

    }
}
