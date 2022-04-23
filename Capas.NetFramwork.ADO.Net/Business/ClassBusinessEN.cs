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
    public static class ClassBusinessEN
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

        public static String BTCrearComando(string descripcion, string direccion, string localidad, string idGrupo, string idTipo, string tipodocumento, 
            string numerodoc, string telefono, string urlpaginaweb, string urlfacebook, string urltwitter, string urlinstagram, string urltiktok, 
            string limitecredito, string comentario, string status, string editable)
        {
            return "insert into Entidades(Descripcion, Direccion, Localidad, IdGrupoEntidad, IdTipoEntidad, TipoDocumento, NumeroDocumento, Telefonos, " +
                "URLPaginaWeb, URLFacebook, URLInstagram, URLTwitter, URLTikTok, LimiteCredito, Comentario, Status, NoEliminable, FechaRegistro) values ('"
                + descripcion + "','" + direccion + "','" + localidad + "','" + idGrupo + "','" + idTipo + "','" + tipodocumento + "','" + numerodoc + "','" + telefono 
                + "','" + urlpaginaweb + "','" + urlfacebook + "','" + urltwitter + "','" + urlinstagram + "','" + urltiktok + "','" + limitecredito + "','" + comentario 
                + "','" + status + "','" + editable + "', GETDATE())";
        }

    
        public static String CargarDatosGrupoComando()
        {
            return "select IdGrupoEntidad, Comentario from GruposEntidades";
        }

        public static String CargarDatosTipoComando(string idGrupo)
        {
            return "select IdTipoEntidad, Comentario from TiposEntidades where IdGrupoEntidad = "+idGrupo;
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

        public static SqlDataReader BTBuscarLogica(string id)
        {

            SqlDataReader datos = ClassData.SQLServerDataReader(ClassData.SQLServerComando(BTBuscarComando(id), CommandType.Text));
            return datos;
        }

        public static String BTBuscarComando(string idSQL)
        {
            return "select Descripcion, Direccion, Localidad, IdGrupoEntidad, IdTipoEntidad, TipoDocumento, NumeroDocumento, Telefonos, " +
                "URLPaginaWeb, URLFacebook, URLInstagram, URLTwitter, URLTikTok, LimiteCredito, Comentario, Status, NoEliminable, FechaRegistro from Entidades where IdEntidad=" + idSQL;
        }

        public static String CargarDatosComando()
        {
            return "select IdGrupoEntidad from Entidades";
        }

        public static DataTable CargarDatos()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(CargarDatosLogica(CargarDatosComando(), CommandType.Text));
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }


        public static String InsertarDatosGrupoComando(string idGrupo)
        {
            return "select Comentario from GruposEntidades where IdGrupoEntidad = " + idGrupo;
        }

        public static SqlDataReader InsertarDatosGrupo(string idGrupo)
        {
            SqlDataReader datos = ClassData.SQLServerDataReader(ClassData.SQLServerComando(InsertarDatosGrupoComando(idGrupo), CommandType.Text));
            return datos;
        }

        public static String InsertarDatosTipoComando(string idTipo)
        {
            return "select Comentario from TiposEntidades where IdTipoEntidad = " + idTipo;
        }

        public static SqlDataReader InsertarDatosTipo(string idTipo)
        {
            SqlDataReader datos = ClassData.SQLServerDataReader(ClassData.SQLServerComando(InsertarDatosTipoComando(idTipo), CommandType.Text));
            return datos;
        }

        public static String BTModificarComando(string descripcion, string direccion, string localidad, string idGrupo, string idTipo, string TipoDocumento, string numerodoc, string telefono, string urlpaginaweb
                    , string urlfacebook, string urltwitter, string urlinstagram, string urltiktok, string limitecredito, string comentario, string Status, string editable, string idSQL)
        {
            return "update Entidades set Descripcion='" + descripcion + "', Direccion='" + direccion + "', Localidad='" + localidad + "', IdGrupoEntidad='" + idGrupo + "', IdTipoEntidad='" + idTipo 
                + "', TipoDocumento='" + TipoDocumento + "', NumeroDocumento='" + numerodoc + "', Telefonos='" + telefono + "', URLPaginaWeb='" + urlpaginaweb + "', URLFacebook='" + urlfacebook + "', URLTwitter='" + urltwitter
                + "', URLInstagram='" + urlinstagram + "', URLTikTok='" + urltiktok + "', LimiteCredito='" + limitecredito + "', Comentario='" + comentario + "', Status='" + Status + "', NoEliminable='" + editable
                + "' where IdEntidad=" + idSQL;
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
            return "delete from Entidades where IdEntidad=" + idSQL;
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
