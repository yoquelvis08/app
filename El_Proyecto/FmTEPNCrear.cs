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
    public partial class FmTEPNCrear : Form
    {
        public FmTEPNCrear()
        {
            InitializeComponent();
        }

        private void FmTEPNCrear_Load(object sender, EventArgs e)
        {
            LBGrupoEntidad.DataSource = ClassBusinessTE.CargarDatos();
            LBGrupoEntidad.DisplayMember = "Comentario";
            LBGrupoEntidad.ValueMember = "IdGrupoEntidad";
        }

        private void BTCrear_Click(object sender, EventArgs e)
        {
            if (TBComentario.Text == "" || TBDescripcion.Text == "")
            {
                InvAvisoVacio();
            }
            else if (LBStatus.SelectedItem == null)
            {
                InvAvisoVacio();
            }
            else if (LBEditable.SelectedItem == null)
            {
                InvAvisoVacio();
            }
            else if (LBGrupoEntidad.SelectedItem == null)
            {
                InvAvisoVacio();
            }
            else
            {
                string comentario = TBComentario.Text;
                string descripcion = TBDescripcion.Text;
                Object objeto = LBGrupoEntidad.SelectedValue;
                string id = objeto.ToString();
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

                string comando = ClassBusinessTE.BTCrearComando(descripcion, id, comentario, status, editable);
                ClassBusinessTE.BTCrearLogica(comando, CommandType.Text);

                InvAvisoCreado();
                TBComentario.Text = "";
                TBDescripcion.Text = "";
                LBStatus.SelectedItem = null;
                LBEditable.SelectedItem = null;
                LBGrupoEntidad.SelectedItem = null;

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

    }
}
