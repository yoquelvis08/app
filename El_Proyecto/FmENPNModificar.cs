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
    public partial class FmENPNModificar : Form
    {
        public FmENPNModificar()
        {
            InitializeComponent();
            cargarGrupo();
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

        private void BTModificar_Click_1(object sender, EventArgs e)
        {
            if (TBDescripcion.Text == "" || TBDireccion.Text == "" || TBLocalidad.Text == "" || TBNumeroDoc.Text == ""
                             || TBTelefono.Text == "" || TBURLPaginaWeb.Text == "" || TBURLFacebook.Text == "" || TBURLTwitter.Text == "" || TBURLInstagram.Text == ""
                             || TBURLTikTok.Text == "" || TBLimiteCredito.Text == "" || TBComentario.Text == "")
            {
                InvAvisoVacio();
            }
            else if (LBStatus.SelectedItem == null || LBEditable.SelectedItem == null || LBGrupoEntidad == null || LBTipoEntidad == null || LBTipoDocumento == null)
            {
                InvAvisoVacio();
            }
            else
            {
                string descripcion = TBDescripcion.Text;
                string direccion = TBDireccion.Text;
                string localidad = TBLocalidad.Text;
                string numerodoc = TBNumeroDoc.Text;
                string telefono = TBTelefono.Text;
                string urlpaginaweb = TBURLPaginaWeb.Text;
                string urlfacebook = TBURLFacebook.Text;
                string urltwitter = TBURLTwitter.Text;
                string urlinstagram = TBURLInstagram.Text;
                string urltiktok = TBURLTikTok.Text;
                string limitecredito = TBLimiteCredito.Text;
                string comentario = TBComentario.Text;

                Object objGrupo = LBGrupoEntidad.SelectedValue;
                string idGrupo = objGrupo.ToString();

                Object objTipo = LBTipoEntidad.SelectedValue;
                string idTipo = objTipo.ToString();

                string tipodocumento = LBTipoDocumento.Text;

                string status = LBStatus.SelectedItem.ToString();
                string editable = "0";

                if (LBEditable.SelectedItem.ToString() == "Editable")
                {
                    editable = "1";
                }
                else
                {
                    editable = "0";
                }

                string id = TBId.Text;

                string comando = ClassBusinessEN.BTModificarComando(descripcion, direccion, localidad, idGrupo, idTipo, tipodocumento, numerodoc, telefono, urlpaginaweb
                    , urlfacebook, urltwitter, urlinstagram, urltiktok, limitecredito, comentario, status, editable, id);

                ClassBusinessEN.BTModificarLogica(comando, CommandType.Text);

                InvAvisoModificada();

                PNBuscar.Visible = true;
                PNLista.Visible = true;
                PNDatos.Visible = false;

                TBId.Text = "";
                TBComentario.Text = "";
                TBDescripcion.Text = "";
                LBStatus.SelectedItem = null;
                LBEditable.SelectedItem = null;

            }
        }

        public void InvAvisoVacio()
        {
            AvisoVacio aviso = new AvisoVacio();
            aviso.Show();
        }

        public void InvAvisoNoExiste()
        {
            AvisoInstanciaNoExiste aviso = new AvisoInstanciaNoExiste();
            aviso.Show();
        }

        public void InvAvisoModificada()
        {
            AvisoInstanciaModificada aviso = new AvisoInstanciaModificada();
            aviso.Show();
        }

        private void BTRefrescar_Click(object sender, EventArgs e)
        {
            dvgLista.DataSource = ClassDataEN.MostrarLista();
        }

        private void FmENPNModificar_Load(object sender, EventArgs e)
        {
            dvgLista.DataSource = ClassDataEN.MostrarLista();
        }

        public void cargarGrupo()
        {
            SqlDataAdapter dataAdapterGrupo = new SqlDataAdapter(ClassBusinessEN.CargarDatosLogica(ClassBusinessEN.CargarDatosGrupoComando(), CommandType.Text));
            DataTable dataGrupo = new DataTable();
            dataAdapterGrupo.Fill(dataGrupo);

            LBGrupoEntidad.ValueMember = "IdGrupoEntidad";
            LBGrupoEntidad.DisplayMember = "Comentario";
            LBGrupoEntidad.DataSource = dataGrupo;
        }

        public void cargarTipo(string idGrupo)
        {
            SqlDataAdapter dataAdapterTipo = new SqlDataAdapter(ClassBusinessEN.CargarDatosLogica(ClassBusinessEN.CargarDatosTipoComando(idGrupo), CommandType.Text));
            DataTable dataTipo = new DataTable();
            dataAdapterTipo.Fill(dataTipo);

            LBTipoEntidad.ValueMember = "IdTipoEntidad";
            LBTipoEntidad.DisplayMember = "Comentario";
            LBTipoEntidad.DataSource = dataTipo;
        }

        private void LBGrupoEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBGrupoEntidad.SelectedValue.ToString() != null)
            {
                string idGrupo = LBGrupoEntidad.SelectedValue.ToString();
                cargarTipo(idGrupo);
            }
        }

        private void BTAtras_Click_1(object sender, EventArgs e)
        {
            TBId.Text = "";

            PNBuscar.Visible = true;
            PNLista.Visible = true;
            PNDatos.Visible = false;
        }
    }
}
