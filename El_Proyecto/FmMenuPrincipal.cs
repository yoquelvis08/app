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
    public partial class FmMenuPrincipal : Form
    {
        public FmMenuPrincipal()
        {
            InitializeComponent();
            LBRuta.Text = "MenuPrincipal/";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBHora.Text = DateTime.Now.ToLongTimeString();
            LBFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmLogin);

            if (frm != null)
            {
                frm.Show();
                return;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void grupoEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ususario = LBEstado.Text;
            bool permisos = ClassBusiness.IdentificarUsuario(ususario);
            if (permisos == true)
            {
                FuncionGP();
            }
            else
            {
                InvAvisoPermisos();
            }
            
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmAcerca);

            if (frm != null)
            {
                frm.Hide();
                frm.Show();
                return;
            }
            else {
                FmAcerca fmAcerca = new FmAcerca();
                fmAcerca.MdiParent = this;
                fmAcerca.Show();
            }

            LBRuta.Text = "MenuPrincipal/Acerca de...";

        }

        private void tiposEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ususario = LBEstado.Text;
            bool permisos = ClassBusiness.IdentificarUsuario(ususario);
            if (permisos == true)
            {
                FuncionTE();
            }
            else
            {
                InvAvisoPermisos();
            }
        }

        private void entidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ususario = LBEstado.Text;
            bool permisos = ClassBusiness.IdentificarUsuario(ususario);
            if (permisos == false || permisos == true)
            {
                FuncionEN();
            }
            else
            {
                InvAvisoPermisos();
            }
        }

        public void FuncionGP() {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmGruposEntidades);

            if (frm != null)
            {
                frm.Hide();
                frm.Show();
                return;
            }
            else
            {
                FmGruposEntidades fmGruposEntidades = new FmGruposEntidades();
                fmGruposEntidades.MdiParent = this;
                fmGruposEntidades.Show();
            }

            LBRuta.Text = "MenuPrincipal/Grupos entidades";
        }

        public void FuncionTE() {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmTiposEntidades);

            if (frm != null)
            {
                frm.Hide();
                frm.Show();
                return;
            }
            else
            {
                FmTiposEntidades fmTiposEntidades = new FmTiposEntidades();
                fmTiposEntidades.MdiParent = this;
                fmTiposEntidades.Show();
            }

            LBRuta.Text = "MenuPrincipal/Tipos entidades";
        }

        public void FuncionEN() {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmEntidades);

            if (frm != null)
            {
                frm.Hide();
                frm.Show();
                return;
            }
            else
            {
                FmEntidades fmEntidades = new FmEntidades();
                fmEntidades.MdiParent = this;
                fmEntidades.Show();
            }

            LBRuta.Text = "MenuPrincipal/Entidades";
        }
        public void InvAvisoPermisos()
        {
            this.Hide();
            AvisoPermisos aviso = new AvisoPermisos();
            aviso.Show();
        }

    }
}
