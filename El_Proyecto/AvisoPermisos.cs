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
    public partial class AvisoPermisos : Form
    {
        public AvisoPermisos()
        {
            InitializeComponent();
        }

        private void PBImagenAyuda_Click(object sender, EventArgs e)
        {
            this.Close();

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FmMenuPrincipal);

            if (frm != null)
            {
                frm.Show();
                return;
            }
        }
    }
}
