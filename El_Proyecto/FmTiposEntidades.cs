using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Proyecto
{
    public partial class FmTiposEntidades : Form
    {
        public FmTiposEntidades()
        {
            InitializeComponent();
        }

        private void BTCrear_Click(object sender, EventArgs e)
        {
            PNContenidoCrear.Dock = DockStyle.Fill;
            PNContenidoCrear.Visible = true;
            PNContenidoLeer.Visible = false;
            PNContenidoModificar.Visible = false;
            PNContenidoEliminar.Visible = false;

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmTEPNCrear);

            if (frm != null)
            {
                frm.Show();
                return;
            }
            else
            {
                FmTEPNCrear fmPNCrear = new FmTEPNCrear();
                fmPNCrear.TopLevel = false;
                PNContenidoCrear.Controls.Add(fmPNCrear);
                fmPNCrear.Show();
            }
        }

        private void BTLeer_Click(object sender, EventArgs e)
        {
            PNContenidoLeer.Dock = DockStyle.Fill;
            PNContenidoCrear.Visible = false;
            PNContenidoLeer.Visible = true;
            PNContenidoModificar.Visible = false;
            PNContenidoEliminar.Visible = false;

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmTEPNLeer);

            if (frm != null)
            {
                frm.Show();
                return;
            }
            else
            {
                FmTEPNLeer fmPNLeer = new FmTEPNLeer();
                fmPNLeer.TopLevel = false;
                PNContenidoLeer.Controls.Add(fmPNLeer);
                fmPNLeer.Show();
            }
        }

        private void BTModificar_Click(object sender, EventArgs e)
        {
            PNContenidoModificar.Dock = DockStyle.Fill;
            PNContenidoCrear.Visible = false;
            PNContenidoLeer.Visible = false;
            PNContenidoModificar.Visible = true;
            PNContenidoEliminar.Visible = false;

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmTEPNModificar);

            if (frm != null)
            {
                frm.Show();
                return;
            }
            else
            {
                FmTEPNModificar fmPNModificar = new FmTEPNModificar();
                fmPNModificar.TopLevel = false;
                PNContenidoModificar.Controls.Add(fmPNModificar);
                fmPNModificar.Show();
            }
        }

        private void BTEliminar_Click(object sender, EventArgs e)
        {
            PNContenidoEliminar.Dock = DockStyle.Fill;
            PNContenidoCrear.Visible = false;
            PNContenidoLeer.Visible = false;
            PNContenidoModificar.Visible = false;
            PNContenidoEliminar.Visible = true;

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmTEPNEliminar);

            if (frm != null)
            {
                frm.Show();
                return;
            }
            else
            {
                FmTEPNEliminar fmPNEliminar = new FmTEPNEliminar();
                fmPNEliminar.TopLevel = false;
                PNContenidoEliminar.Controls.Add(fmPNEliminar);
                fmPNEliminar.Show();
            }
        }
    }
}
