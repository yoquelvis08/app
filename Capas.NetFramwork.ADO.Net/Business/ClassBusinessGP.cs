using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capas.NetFramwork.ADO.Net.Data;
using System.Data.SqlClient;
using System.Data;

namespace Capas.NetFramwork.ADO.Net.Business
{
    public static class ClassBusinessGP
    {
        public static SqlCommand BTCrearLogica(String stringSqlCommand, CommandType SQLCommandType)
        {

            //Forma para el codigo de SQl
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = ClassData.SQLServerConexionDB();
            sqlCommand.CommandType = SQLCommandType;
            sqlCommand.CommandText = stringSqlCommand;
            sqlCommand.ExecuteNonQuery();
            return sqlCommand;

        }

        public static String BTCrearComando(string comentario, string descripcion, string status, string editable)
        {
            return "insert into GruposEntidades(Comentario, Descripcion, Status, NoEliminable, FechaRegistro) values ('"
                + comentario + "','" + descripcion + "','" + status + "','" + editable + "', GETDATE())";
        }

        public static SqlDataReader BTBuscarLogica(string id)
        {

            SqlDataReader datos = ClassData.SQLServerDataReader(ClassData.SQLServerComando(BTBuscarComando(id), CommandType.Text));
            return datos;
        }

        public static String BTBuscarComando(string idSQL)
        {
            return "select Comentario, Descripcion, Status, NoEliminable, FechaRegistro from GruposEntidades where IdGrupoEntidad=" + idSQL;
        }

        public static String BTModificarComando(string comentario, string descripcion, string status, string editable, string idSQL)
        {
            return "update GruposEntidades set Comentario='" + comentario + "', Descripcion='" + descripcion + "', Status='" + status + "', NoEliminable='" + editable + "' where IdGrupoEntidad=" + idSQL;
        }

        public static SqlCommand BTModificarLogica(String stringSqlCommand, CommandType SQLCommandType)
        {

            //Forma para el codigo de SQl
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = ClassData.SQLServerConexionDB();
            sqlCommand.CommandType = SQLCommandType;
            sqlCommand.CommandText = stringSqlCommand;
            sqlCommand.ExecuteNonQuery();
            return sqlCommand;
        }

        public static String BTEliminarComando(string idSQL)
        {
            return "delete from GruposEntidades where IdGrupoEntidad=" + idSQL;
        }

        public static SqlCommand BTEliminarLogica(String stringSqlCommand, CommandType SQLCommandType)
        {

            //Forma para el codigo de SQl
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = ClassData.SQLServerConexionDB();
            sqlCommand.CommandType = SQLCommandType;
            sqlCommand.CommandText = stringSqlCommand;
            sqlCommand.ExecuteNonQuery();
            return sqlCommand;

        }

    }
}
