using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capas.NetFramwork.ADO.Net.Business;

namespace El_Proyecto
{
    public partial class FmRegistro : Form
    {
        public FmRegistro()
        {
            InitializeComponent();

            TBContraseñaRegistro.UseSystemPasswordChar = true;

            //Subscribe to Event
            PBImagenOcultar.MouseDown += new MouseEventHandler(PBImagenOcultar_MouseDown);
            PBImagenOcultar.MouseUp += new MouseEventHandler(PBImagenOcultar_MouseUp);

        }

        private void BTCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmLogin);

            if (frm != null)
            {
                frm.Show();
                return;
            }

        }

        private void BTRegistrar_Click(object sender, EventArgs e)
        {

            if (TBUsuarioRegistro.Text.Contains(" ") || TBContraseñaRegistro.Text.Contains(" "))
            {
                InvAvisoEspacio();
            } else if (TBUsuarioRegistro.Text == "" || TBContraseñaRegistro.Text == "") {
                InvAvisoVacio();
            }
            else {
                string usuario = TBUsuarioRegistro.Text;
                string contraseña = TBContraseñaRegistro.Text;

                bool existencia = ClassBusiness.ComprobarExistencia(usuario);

                if (existencia == false)
                {
                    InvAvisoExiste();
                }
                else {
                    string comando = ClassBusiness.BTRegistrarComando(usuario, contraseña);
                    ClassBusiness.BTRegistrarLogica(comando, CommandType.Text);
                    InvAvisoRegistro();
                    TBUsuarioRegistro.Text = "";
                    TBContraseñaRegistro.Text = "";
                }
  
            }
            
        }

        public void InvAvisoEspacio()
        {
            this.Hide();
            AvisoEspacio aviso = new AvisoEspacio();
            aviso.Show();
        }

        public void InvAvisoVacio()
        {
            this.Hide();
            AvisoVacio aviso = new AvisoVacio();
            aviso.Show();
        }

        public void InvAvisoRegistro()
        {
            this.Hide();
            AvisoRegistro aviso = new AvisoRegistro();
            aviso.Show();

        }

        public void InvAvisoExiste()
        {
            this.Hide();
            AvisoExiste aviso = new AvisoExiste();
            aviso.Show();
        }

        private void PBImagenOcultar_MouseDown(object sender, MouseEventArgs e)
        {
            TBContraseñaRegistro.UseSystemPasswordChar = false;
        }

        private void PBImagenOcultar_MouseUp(object sender, MouseEventArgs e)
        {
            TBContraseñaRegistro.UseSystemPasswordChar = true;
        }

    }
}
