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
    public partial class FmEntidades : Form
    {
        public FmEntidades()
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

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmENPNCrear);

            if (frm != null)
            {
                frm.Show();
                return;
            }
            else
            {
                FmENPNCrear fmPNCrear = new FmENPNCrear();
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

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmENPNLeer);

            if (frm != null)
            {
                frm.Show();
                return;
            }
            else
            {
                FmENPNLeer fmPNLeer = new FmENPNLeer();
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

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmENPNModificar);

            if (frm != null)
            {
                frm.Show();
                return;
            }
            else
            {
                FmENPNModificar fmPNModificar = new FmENPNModificar();
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

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmENPNEliminar);

            if (frm != null)
            {
                frm.Show();
                return;
            }
            else
            {
                FmENPNEliminar fmPNEliminar = new FmENPNEliminar();
                fmPNEliminar.TopLevel = false;
                PNContenidoEliminar.Controls.Add(fmPNEliminar);
                fmPNEliminar.Show();
            }
        }
    }
}
