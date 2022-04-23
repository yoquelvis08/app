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
    public partial class FmGEPNModificar : Form
    {
        public FmGEPNModificar()
        {
            InitializeComponent();
        }

        private void BTBuscar_Click(object sender, EventArgs e)
        {
           
            string id = TBId.Text;
            if (TBId.Text != "")
            {
                SqlDataReader datos = ClassBusinessGP.BTBuscarLogica(id);
                if (datos.Read())
                {
                    TBComentario.Text = datos["Comentario"].ToString();
                    TBDescripcion.Text = datos["Descripcion"].ToString();
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
                else {
                    InvAvisoNoExiste();
                }
            }
            else {
                InvAvisoVacio();
            }
            
        }

        private void FmPNModificar_Load(object sender, EventArgs e)
        {
            dvgLista.DataSource = ClassData.MostrarLista();
        }

        private void BTModificar_Click(object sender, EventArgs e)
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
            else
            {

                string comentario = TBComentario.Text;
                string descripcion = TBDescripcion.Text;
                string status = LBStatus.SelectedItem.ToString();
                string editable = "0";
                string id = TBId.Text;
                if (LBEditable.SelectedItem.ToString() == "Editable")
                {
                    editable = "1";
                }
                else
                {
                    editable = "0";
                }

                string comando = ClassBusinessGP.BTModificarComando(comentario, descripcion, status, editable, id);
                ClassBusinessGP.BTModificarLogica(comando, CommandType.Text);
               
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

        private void BTAtras_Click(object sender, EventArgs e)
        {
            TBId.Text = "";

            PNBuscar.Visible = true;
            PNLista.Visible = true;
            PNDatos.Visible = false;
        }

        private void BTRefrescar_Click(object sender, EventArgs e)
        {
            dvgLista.DataSource = ClassData.MostrarLista();
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

        public void InvAvisoModificada() {
            AvisoInstanciaModificada aviso = new AvisoInstanciaModificada();
            aviso.Show();
        }

    }
}
