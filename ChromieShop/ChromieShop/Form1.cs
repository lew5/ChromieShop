using ChromieShop.custom;
using ChromieShop.usercontrols;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChromieShop
{
    public partial class Form1 : Form
    {

        public static Form1 Form1Instance;

        public static void MostrarSeccion(UserControl Seccion,Control p)
        {
            
            foreach (UserControl uc in p.Controls.OfType<UserControl>())
            {
                p.Controls.Clear();
                p.Controls.Add(Seccion);
                Seccion.Dock = DockStyle.Fill;
                Seccion.BringToFront();
            }
        }
        public Form1()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = 720;
            foreach (CustomPanel cust in this.Controls.OfType<CustomPanel>())
            {
                foreach (UCNavBar nav in cust.Controls.OfType<UCNavBar>())
                {
                    foreach (Panel panel in nav.Controls.OfType<Panel>())
                    {
                        UCNavButton navbtn = new UCNavButton();
                        navbtn.Checked = true;
                        panel.Controls.Add(navbtn);
                        foreach (Panel conteiner in cust.Controls.OfType<Panel>())
                        {
                            navbtn.Container = conteiner;
                            foreach (UserControl sec in conteiner.Controls.OfType<UserControl>())
                            {
                                navbtn.Seccion = sec;
                            }
                        }
                    }
                }
            }

            Form1Instance = this;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            //UCSeccionMenu seccionMenu = new UCSeccionMenu();
            //seccionMenu.Dock = DockStyle.Fill;
            //customPanel1.Controls.Add(seccionMenu);
        }
    }
}
