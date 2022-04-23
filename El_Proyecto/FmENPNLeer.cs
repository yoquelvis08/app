using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capas.NetFramwork.ADO.Net.Data;
using Capas.NetFramwork.ADO.Net.Business;
using System.Data.SqlClient;

namespace El_Proyecto
{
    public partial class FmENPNLeer : Form
    {
        public FmENPNLeer()
        {
            InitializeComponent();
        }

        private void BTBuscar_Click(object sender, EventArgs e)
        {
            string id = TBId.Text;
            if (TBId.Text != "")
            {
                SqlDataReader datos = ClassBusinessEN.BTBuscarLogica(id);
                if (datos.Read())
                {
                    TBComentario.Text = datos["Comentario"].ToString();
                    TBDescripcion.Text = datos["Descripcion"].ToString();
                    TBDireccion.Text = datos["Direccion"].ToString();
                    TBLocalidad.Text = datos["Localidad"].ToString();

                    string idGrupo = datos["IdGrupoEntidad"].ToString();
                    SqlDataReader datoGrupo = ClassBusinessEN.InsertarDatosGrupo(idGrupo);
                    datoGrupo.Read();
                    LBGrupoEntidad.Text = datoGrupo["Comentario"].ToString();

                    string idTipo = datos["IdTipoEntidad"].ToString();
                    SqlDataReader datoTipo = ClassBusinessEN.InsertarDatosTipo(idTipo);
                    datoTipo.Read();
                    LBTipoEntidad.Text = datoTipo["Comentario"].ToString();

                    LBTipoDocumento.Text = datos["TipoDocumento"].ToString();
                    TBNumeroDoc.Text = datos["NumeroDocumento"].ToString();
                    TBTelefono.Text = datos["Telefonos"].ToString();
                    TBURLPaginaWeb.Text = datos["URLPaginaWeb"].ToString();
                    TBURLFacebook.Text = datos["URLFacebook"].ToString();
                    TBURLTwitter.Text = datos["URLTwitter"].ToString();
                    TBURLInstagram.Text = datos["URLInstagram"].ToString();
                    TBURLTikTok.Text = datos["URLTikTok"].ToString();
                    TBLimiteCredito.Text = datos["LimiteCredito"].ToString();
                    TBComentario.Text = datos["Comentario"].ToString();

                    LBStatus.Text = datos["Status"].ToString();
                    if (datos["NoEliminable"].ToString() == "0")
                    {
                        LBEditable.Text = "Editable";
                    }
                    else
                    {
                        LBEditable.Text = "No editable";
                    }

                    LBEditable.Text = datos["NoEliminable"].ToString();

                    PNBuscar.Visible = false;
                    PNLista.Visible = false;
                    PNDatos.Visible = true;

                }
                else
                {
                    InvAvisoNoExiste();
                }
            }
            else
            {
                InvAvisoVacio();
            }
        }

        public void InvAvisoNoExiste()
        {
            AvisoInstanciaNoExiste aviso = new AvisoInstanciaNoExiste();
            aviso.Show();
        }

        public void InvAvisoVacio()
        {
            AvisoVacio aviso = new AvisoVacio();
            aviso.Show();
        }

        private void BTRefrescar_Click(object sender, EventArgs e)
        {
            dvgLista.DataSource = ClassDataEN.MostrarLista();
        }


        private void FmENPNLeer_Load(object sender, EventArgs e)
        {
            dvgLista.DataSource = ClassDataEN.MostrarLista();
        }

        private void BTAtras_Click(object sender, EventArgs e)
        {
            TBId.Text = "";

            PNBuscar.Visible = true;
            PNLista.Visible = true;
            PNDatos.Visible = false;
        }
    }
}
