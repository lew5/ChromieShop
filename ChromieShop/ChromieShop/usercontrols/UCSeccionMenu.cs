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
    public partial class UCSeccionMenu : UserControl
    {
        public UCSeccionMenu()
        {
            InitializeComponent();
        }

        private void ucOpcionButton1_OpcionClick(object sender, EventArgs e)
        {
            ucob_Categorias.Seccion = new UCSeccionCategorias();
        }

        private void ucob_Carrito_OpcionClick(object sender, EventArgs e)
        {
            ucob_Carrito.Seccion = new UCSeccionCarrito();
        }

        private void ucob_Salir_OpcionClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
