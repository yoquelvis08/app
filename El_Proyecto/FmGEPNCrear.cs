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
    public partial class FmGEPNCrear : Form
    {
        public FmGEPNCrear()
        {
            InitializeComponent();
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
            else
            {
                string comentario = TBComentario.Text;
                string descripcion = TBDescripcion.Text;
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

                string comando = ClassBusinessGP.BTCrearComando(comentario, descripcion, status, editable);
                ClassBusinessGP.BTCrearLogica(comando, CommandType.Text);

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

    }
}
