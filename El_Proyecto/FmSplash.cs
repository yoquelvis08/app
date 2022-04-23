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

namespace El_Proyecto
{
    public partial class FmSplash : Form
    {
        public FmSplash()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            PNProgresoBarra.Width += 3;

            if(PNProgresoBarra.Width >= 346){
                Timer.Stop();
            }

        }

    }
}
