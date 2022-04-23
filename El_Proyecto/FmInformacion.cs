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
    public partial class FmInformacion : Form
    {
        public FmInformacion()
        {
            InitializeComponent();
        }

        private void BTAtras_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmLogin);

            if (frm != null)
            {
                frm.Show();
                return;
            }
            else
            {
                FmLogin fmLogin = new FmLogin();
                fmLogin.Show();
                return;
            }
        }
    }
}
