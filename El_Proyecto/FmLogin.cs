using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capas.NetFramwork.ADO.Net.Business;

namespace El_Proyecto
{
    public partial class FmLogin : Form
    {
        public FmLogin()
        {
            Thread t = new Thread(new ThreadStart(InvSplash));
            t.Start();
            Thread.Sleep(4000);
            t.Abort();

            InitializeComponent();

            TBContraseña.UseSystemPasswordChar = true;

            //Subscribe to Event
            PBImagenOcultar.MouseDown += new MouseEventHandler(PBImagenOcultar_MouseDown);
            PBImagenOcultar.MouseUp += new MouseEventHandler(PBImagenOcultar_MouseUp);

        }

        public void InvSplash()
        {
            Application.Run(new FmSplash());
        }

        private void BTCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBImagenOcultar_MouseDown(object sender, MouseEventArgs e)
        {
            TBContraseña.UseSystemPasswordChar = false;
        }

        private void PBImagenOcultar_MouseUp(object sender, MouseEventArgs e)
        {
            TBContraseña.UseSystemPasswordChar = true;
        }

        public void BTIngresar_Click(object sender, EventArgs e)
        {
            string usuario = TBUsuario.Text;
            string contraseña = TBContraseña.Text;
            string comando = ClassBusiness.BTIngresarComando();

            Boolean credenciales = ClassBusiness.BTIngresarLogica(usuario, contraseña, comando);

            if (credenciales == true)
            {
                InvAvisoPositivo();
            }
            else {
                InvAvisoNegativo();
            }

            TBUsuario.Text = "";
            TBContraseña.Text = "";
        }

        private void limpiarCampos(object sender, FormClosedEventArgs e)
        {
            this.TBUsuario.Text = string.Empty;
            this.TBContraseña.Text = string.Empty;

        }

        public void InvAvisoPositivo()
        {
            this.Hide();

            FmMenuPrincipal fmMenuPrincipal = new FmMenuPrincipal();
            fmMenuPrincipal.LBEstado.Text = TBUsuario.Text;
            fmMenuPrincipal.Show();

        }

        public void InvAvisoNegativo()
        {
            this.Hide();
            AvisoNegativo aviso = new AvisoNegativo();
            aviso.Show();

        }

        private void BTRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmRegistro);

            if (frm != null)
            {
                frm.Show();
                return;
            }
            else {
                FmRegistro fmRegistro = new FmRegistro();
                fmRegistro.Show();
            }

        }

        private void BTAcerca_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmInformacion);

            if (frm != null)
            {
                frm.Show();
                return;
            }
            else {
                FmInformacion fmInformacion = new FmInformacion();
                fmInformacion.Show();
                return;
            }
        }

        

    }
}
