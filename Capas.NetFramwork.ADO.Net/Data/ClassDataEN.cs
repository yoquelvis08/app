using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace Capas.NetFramwork.ADO.Net.Data
{
    public static class ClassDataEN
    {
        public static DataTable MostrarLista()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(MostrarListaComando(), ClassData.SQLServerConexionDB());
            sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static String MostrarListaComando()
        {
            return "select * from Entidades";
        }
    }
}
