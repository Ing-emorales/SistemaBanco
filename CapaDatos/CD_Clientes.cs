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
       /*
       private CD_Conexion cd_conexion = new CD_Conexion();

       public DataTable MostrarClientes()
        {
            string QueryMostrarClientes = "usp_clientes_mostrar";
            SqlDataAdapter AdapterClientes = new SqlDataAdapter(QueryMostrarClientes, cd_conexion.MtdAbrirConexion());
            DataTable dtMostrarClientes = new DataTable();
            AdapterClientes.Fill(dtMostrarClientes);
            cd_conexion.MtdCerrarConexion();
            return dtMostrarClientes;
        }
       */
    
        CD_Conexion db_conexion = new CD_Conexion();

        public DataTable MtMostrarClientes()
        {
            string QryMostrarClientes = "Select * from tbl_clientes";
            SqlDataAdapter adapter = new SqlDataAdapter(QryMostrarClientes,db_conexion.MtdAbrirConexion());
            DataTable dtMostrarClientes = new DataTable();
            adapter.Fill(dtMostrarClientes);
            db_conexion.MtdCerrarConexion();
            return dtMostrarClientes;
        }


    }
}
