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
    public partial class FmGruposEntidades : Form
    {
        public FmGruposEntidades()
        {
            InitializeComponent();
        }


        private void BTCrear_Click(object sender, EventArgs e)
        {
                FuncionBTCrear();
        }

        private void BTLeer_Click(object sender, EventArgs e)
        {
                FuncionBTLeer();
        }

        private void BTModificar_Click(object sender, EventArgs e)
        {
                FuncionBTModificar();
        }

        private void BTEliminar_Click(object sender, EventArgs e)
        {
                FuncionBTEliminar();
        }

        public void FuncionBTCrear()
        {
            PNContenidoCrear.Dock = DockStyle.Fill;
            PNContenidoCrear.Visible = true;
            PNContenidoLeer.Visible = false;
            PNContenidoModificar.Visible = false;
            PNContenidoEliminar.Visible = false;

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmGEPNCrear);

            if (frm != null)
            {
                frm.Show();
                return;
            }
            else
            {
                FmGEPNCrear fmPNCrear = new FmGEPNCrear();
                fmPNCrear.TopLevel = false;
                PNContenidoCrear.Controls.Add(fmPNCrear);
                fmPNCrear.Show();
            }
        }

        public void FuncionBTLeer() 
        {

            PNContenidoLeer.Dock = DockStyle.Fill;
            PNContenidoCrear.Visible = false;
            PNContenidoLeer.Visible = true;
            PNContenidoModificar.Visible = false;
            PNContenidoEliminar.Visible = false;

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmGEPNLeer);

            if (frm != null)
            {
                frm.Show();
                return;
            }
            else
            {
                FmGEPNLeer fmPNLeer = new FmGEPNLeer();
                fmPNLeer.TopLevel = false;
                PNContenidoLeer.Controls.Add(fmPNLeer);
                fmPNLeer.Show();
            }

        }

        public void FuncionBTModificar() 
        {

            PNContenidoModificar.Dock = DockStyle.Fill;
            PNContenidoCrear.Visible = false;
            PNContenidoLeer.Visible = false;
            PNContenidoModificar.Visible = true;
            PNContenidoEliminar.Visible = false;

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmGEPNModificar);

            if (frm != null)
            {
                frm.Show();
                return;
            }
            else
            {
                FmGEPNModificar fmPNModificar = new FmGEPNModificar();
                fmPNModificar.TopLevel = false;
                PNContenidoModificar.Controls.Add(fmPNModificar);
                fmPNModificar.Show();
            }

        }

        public void FuncionBTEliminar() 
        {
            PNContenidoEliminar.Dock = DockStyle.Fill;
            PNContenidoCrear.Visible = false;
            PNContenidoLeer.Visible = false;
            PNContenidoModificar.Visible = false;
            PNContenidoEliminar.Visible = true;

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmGEPNEliminar);

            if (frm != null)
            {
                frm.Show();
                return;
            }
            else
            {
                FmGEPNEliminar fmPNEliminar = new FmGEPNEliminar();
                fmPNEliminar.TopLevel = false;
                PNContenidoEliminar.Controls.Add(fmPNEliminar);
                fmPNEliminar.Show();
            }
        }
        public void InvAvisoPermisos()
        {
            AvisoPermisos aviso = new AvisoPermisos();
            aviso.Show();
        }
    }
}
