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
    public static class ClassData
    {

        public static string stringConexionSQL = ConfigurationManager.ConnectionStrings["DBConexionStringSQL"].ConnectionString;


        public static SqlConnection SQLServerConexionDB()
        {

            //Forma para conectar a una base de datos
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ClassData.stringConexionSQL;
            sqlConnection.Open();

            return sqlConnection;
        }

        public static SqlCommand SQLServerComando(String stringSqlComando, CommandType SQLTipoComando)
        {

            //Forma para el codigo de SQL
            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = ClassData.SQLServerConexionDB();
            sqlComando.CommandType = SQLTipoComando;
            sqlComando.CommandText = stringSqlComando;
            return sqlComando;
        }

        public static void SQLServerEjecutar(SqlCommand sqlComando) {
            sqlComando.ExecuteNonQuery();
        }

        public static SqlDataReader SQLServerDataReader(SqlCommand SQLServerComando)
        {
            //Forma para devolver lo leido
            SqlDataReader sqlDataReader = SQLServerComando.ExecuteReader();
            return sqlDataReader;
        }

        public static DataTable MostrarLista() {

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SP_MOSTRARDATOS", ClassData.SQLServerConexionDB());
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

    }
}
