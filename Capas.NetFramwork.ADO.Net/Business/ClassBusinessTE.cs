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
    public static class ClassBusinessTE
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

        public static String BTCrearComando(string descripcion, string idgrupo, string comentario, string status, string editable)
        {
            return "insert into TiposEntidades(Descripcion, IdGrupoEntidad, Comentario, Status, NoEliminable, FechaRegistro) values ('"
                + descripcion + "','" + idgrupo + "','" + comentario + "','" + status + "','" + editable + "', GETDATE())";
        }

        public static SqlCommand CargarDatosLogica(String stringSqlCommand, CommandType SQLCommandType)
        {

            //Forma para el codigo de SQl
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = ClassData.SQLServerConexionDB();
            sqlCommand.CommandType = SQLCommandType;
            sqlCommand.CommandText = stringSqlCommand;
            sqlCommand.ExecuteNonQuery();
            return sqlCommand;

        }

        public static String CargarDatosComando()
        {
            return "select IdGrupoEntidad, Comentario from GruposEntidades";
        }

        public static DataTable CargarDatos()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(CargarDatosLogica(CargarDatosComando(), CommandType.Text));
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static SqlDataReader BTBuscarLogica(string id)
        {

            SqlDataReader datos = ClassData.SQLServerDataReader(ClassData.SQLServerComando(BTBuscarComando(id), CommandType.Text));
            return datos;
        }

        public static String BTBuscarComando(string idSQL)
        {
            return "select Descripcion, IdGrupoEntidad, Comentario, Status, NoEliminable from TiposEntidades where IdTipoEntidad=" + idSQL;
        }

        public static String CargarDatosGrupoComando(string idGrupo)
        {
            return "select Comentario from GruposEntidades where IdGrupoEntidad = " + idGrupo;
        }

        public static SqlDataReader CargarDatosGrupo(string idGrupo)
        {
            SqlDataReader datos = ClassData.SQLServerDataReader(ClassData.SQLServerComando(CargarDatosGrupoComando(idGrupo), CommandType.Text));
            return datos;
        }

        public static String BTModificarComando(string descripcion, string idGrupo, string comentario, string status, string editable, string idSQL)
        {
            return "update TiposEntidades set Descripcion='" + descripcion + "', IdGrupoEntidad='" + idGrupo + "', Comentario='" + comentario + "', Status='" + status + "', NoEliminable='" + editable + "' where IdTipoEntidad=" + idSQL;
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
            return "delete from TiposEntidades where IdTipoEntidad=" + idSQL;
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
