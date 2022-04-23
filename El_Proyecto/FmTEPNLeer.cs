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
    public partial class FmTEPNLeer : Form
    {
        public FmTEPNLeer()
        {
            InitializeComponent();
        }

        private void BTBuscar_Click(object sender, EventArgs e)
        {
            string id = TBId.Text;
            if (TBId.Text != "")
            {
                SqlDataReader datos = ClassBusinessTE.BTBuscarLogica(id);
                if (datos.Read())
                {
                    TBComentario.Text = datos["Comentario"].ToString();
                    TBDescripcion.Text = datos["Descripcion"].ToString();
                    
                    string idGrupo = datos["IdGrupoEntidad"].ToString();
                    SqlDataReader datoGrupo = ClassBusinessTE.CargarDatosGrupo(idGrupo);
                    datoGrupo.Read();
                    LBGrupoEntidad.Text = datoGrupo["Comentario"].ToString();

                    LBStatus.Text = datos["Status"].ToString();
                    if (datos["NoEliminable"].ToString() == "0")
                    {
                        LBEditable.Text = "Editable";
                    }
                    else
                    {
                        LBEditable.Text = "No editable";
                    }

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

        private void FmTEPNLeer_Load(object sender, EventArgs e)
        {
            dvgLista.DataSource = ClassDataTE.MostrarLista();
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

        private void BTAtras_Click(object sender, EventArgs e)
        {
            TBId.Text = "";

            PNBuscar.Visible = true;
            PNLista.Visible = true;
            PNDatos.Visible = false;
        }

        private void BTRefrescar_Click(object sender, EventArgs e)
        {
            dvgLista.DataSource = ClassDataTE.MostrarLista();
        }

    }
}
