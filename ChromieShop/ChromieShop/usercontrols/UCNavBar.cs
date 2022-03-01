using ChromieShop.custom;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ChromieShop.usercontrols
{
    public partial class UCNavBar : UserControl
    {
        public UCNavBar()
        {
            InitializeComponent();
        }

        private void UCNavBar_Load(object sender, System.EventArgs e)
        {
            BackColor = Parent.BackColor;
        }

        //private void NavButtonBarSeccion()
        //{
        //    //foreach (Control con in Parent.Parent.Controls.OfType<CustomPanel>())
        //    //{
        //    //    MessageBox.Show(con.Name);
        //    //    foreach (Panel conteiner in con.Controls.OfType<Panel>())
        //    //    {
        //    //        MessageBox.Show(conteiner.Name);
        //    //        ucNavButton1.Container = conteiner;
        //    //        foreach (UserControl sec in conteiner.Controls.OfType<UserControl>())
        //    //        {
        //    //            MessageBox.Show(sec.Name);
        //    //            ucNavButton1.Seccion = sec;
        //    //        }
        //    //    }
        //    //}
        //}
    }
}
