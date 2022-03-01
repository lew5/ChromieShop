using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChromieShop.usercontrols
{
    public partial class UCSeccionCategorias : UserControl
    {
        public UCSeccionCategorias()
        {
            InitializeComponent();
        }

        private void ucob_ChromiePoints_OpcionClick(object sender, EventArgs e)
        {
            ucob_ChromiePoints.Seccion = new UCSeccionChromiePoints();
        }

        private void ucob_Services_OpcionClick(object sender, EventArgs e)
        {
            ucob_Services.Seccion = new UCSeccionServices();
        }
    }
}
