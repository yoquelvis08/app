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
    public static class ClassBusiness
    {
        public static Boolean BTIngresarLogica(string usuario, string contraseña, string comando) {

            SqlDataReader datos = ClassData.SQLServerDataReader(ClassData.SQLServerComando(comando, CommandType.Text));

            string BDusuario, BDcontraseña;
            bool credenciales = false;

            try
            {

                while (datos.Read() && credenciales == false) {

                    BDusuario = datos["UserNameEntidad"].ToString();
                    BDcontraseña = datos["PasswordEntidad"].ToString();

                    if (usuario == BDusuario && contraseña == BDcontraseña)
                    {
                        credenciales = true;
                    }
                    else
                    {
                        credenciales = false;
                    }

                }

                return credenciales;

            }
            catch (Exception ex) {
                return false;
            }
        }

        public static String BTIngresarComando() {
            return "select UserNameEntidad, PasswordEntidad from Entidades";
        }

        public static SqlCommand BTRegistrarLogica(String stringSqlCommand, CommandType SQLCommandType)
        {
            //Forma para el codigo de SQl
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = ClassData.SQLServerConexionDB();
            sqlCommand.CommandType = SQLCommandType;
            sqlCommand.CommandText = stringSqlCommand;
            sqlCommand.ExecuteNonQuery();
            return sqlCommand;

        }

        public static Boolean ComprobarExistencia(string usuario) {
            string comando = ComprobarExistenciaComando(usuario);
            SqlDataReader datos = ClassData.SQLServerDataReader(ClassData.SQLServerComando(comando, CommandType.Text));

            string BDusuario;
            bool credenciales = true;

            try
            {

                while (datos.Read())
                {

                    BDusuario = datos["UserNameEntidad"].ToString();

                    if (usuario == BDusuario)
                    {
                        credenciales = false;
                    }else if(usuario != BDusuario){

                        credenciales = true;
                    }
                    else
                    {
                        credenciales = true;
                    }

                }

                return credenciales;

            }
            catch (Exception ex)
            {
                return credenciales;
            }
        }

        public static String BTRegistrarComando(string usuario, string contraseña)
        {
            return "insert into Entidades(UserNameEntidad, PasswordEntidad, IdTipoEntidad, IdGrupoEntidad) values ('"
                + usuario + "','" + contraseña + "', 7, 5)";    
        }

        public static Boolean IdentificarUsuario(string usuario)
        {
            string comando = IdentificarUsuarioComando(usuario);
            SqlDataReader datos = ClassData.SQLServerDataReader(ClassData.SQLServerComando(comando, CommandType.Text));

            string BDRol = "";
            bool credenciales = false;

            try
            {

                while (datos.Read() && credenciales == false)
                {

                    BDRol = datos["RolUserEntidad"].ToString();

                    if (BDRol == "Admin")
                    {
                        credenciales = true;
                    }
                    else if (BDRol == "Supervisor") {
                        credenciales = true;
                    }
                    else
                    {
                        credenciales = false;
                    }

                }

                return credenciales;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static String IdentificarUsuarioComando(string usuario) {
            return "select RolUserEntidad from Entidades where UserNameEntidad='"+usuario+"'";
        }

        public static String ComprobarExistenciaComando(string usuario)
        {
            return "select UserNameEntidad from Entidades where UserNameEntidad='" + usuario + "'";
        }
    }
}
