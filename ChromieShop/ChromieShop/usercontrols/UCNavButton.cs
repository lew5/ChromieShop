using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ChromieShop.usercontrols
{
    public partial class UCNavButton : UserControl
    {

        private UserControl seccion = null;
        private Control container = null;
        public UCNavButton()
        {
            InitializeComponent();
        }

        public static void unCheck(UCNavButton btn,Control con)
        {
            if (btn.Checked)
            {
                foreach (UCNavButton myBut in con.Controls.OfType<UCNavButton>())
                {
                    if (myBut is UCNavButton && !myBut.Equals(btn))
                    {
                        myBut.gab_Button.Checked = false;
                    }
                }
            }
        }

        private void UCNavButton_Load(object sender, EventArgs e)
        {
            BackColor = Parent.BackColor;
            BringToFront();
            Dock = DockStyle.Left;
            
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            List<UCNavButton> lis = new List<UCNavButton>();

            for (int i = 0; i < Parent.Controls.IndexOf(this); i++)
            {
                lis.Add(Parent.Controls.OfType<UCNavButton>().ElementAt(i));
            }

            foreach (var grp in Parent.Controls.OfType<UCNavButton>().Intersect
                        (lis).ToList())
            {
                Parent.Controls.Remove(grp);
            }

            unCheck(this,Parent);

            Form1.MostrarSeccion(Seccion, Container);
            //funciona pero al revez
            //for (int i = 0; i <= Parent.Controls.IndexOf(this); i++)
            //{
            //    lis.Add(Parent.Controls.OfType<UCNavButton>().ElementAt(i));
            //}

            //foreach (var grp in Parent.Controls.OfType<UCNavButton>().
            //            Except(lis).ToList())
            //{
            //    MessageBox.Show(Parent.Controls.IndexOf(this).ToString());
            //    Parent.Controls.Remove(grp);
            //}
        }


        public bool Checked
        {
            get => gab_Button.Checked;
            set => gab_Button.Checked = value;
        }
        public string Texto
        {
            get => gab_Button.Text;
            set => gab_Button.Text = value;
        }

        public UserControl Seccion
        {
            get => this.seccion;
            set => this.seccion = value;
        }

        public Control Container
        {
            get => this.container;
            set => this.container = value;
        }

        private void gab_Button_TextChanged(object sender, EventArgs e)
        {
            if (gab_Button.Text.Length > 4)
            {
                this.Width += (gab_Button.Text.Length - 4) * 4;
            }
            else
            {
                this.Width = 160;
            }
        }

    }
}
