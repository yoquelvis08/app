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
    public partial class FmENPNCrear : Form
    {
        public FmENPNCrear()
        {
            InitializeComponent();
            cargarGrupo();
        }

        private void BTCrear_Click(object sender, EventArgs e)
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

                string comando = ClassBusinessEN.BTCrearComando(descripcion, direccion, localidad, idGrupo, idTipo, tipodocumento, numerodoc, telefono, urlpaginaweb
                    , urlfacebook, urltwitter, urlinstagram, urltiktok, limitecredito, comentario, status, editable);

                ClassBusinessEN.BTCrearLogica(comando, CommandType.Text);

                InvAvisoCreado();
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

        public void InvAvisoCreado()
        {
            AvisoInstanciaCreada aviso = new AvisoInstanciaCreada();
            aviso.Show();
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
    }
}
