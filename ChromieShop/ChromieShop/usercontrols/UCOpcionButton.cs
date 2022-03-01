using ChromieShop.custom;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ChromieShop.usercontrols
{
    public partial class UCOpcionButton : UserControl
    {
        public event EventHandler OpcionClick;
        private bool botonMenu = false;
        private bool tipoNav = true;
        private Image imagen;
        private Image imagenHover;
        private UserControl seccion = null;
        public UCOpcionButton()
        {
            InitializeComponent();       
        }

        private void UCOpcionButton_Load(object sender, System.EventArgs e)
        {
            if (Parent != null)
            {
                BackColor = Parent.BackColor;
                picbox_Imagen.BackColor = Parent.BackColor;
            }
            else
            {
                BackColor = Color.White;
                pnl_Borde.BackColor = Color.White;
                picbox_Imagen.BackColor = Color.White;
            }
        }

        public bool BotonMenu
        {
            get => this.botonMenu;
            set => this.botonMenu = value;
        }

        public bool TipoNav
        {
            get => this.tipoNav;
            set => this.tipoNav = value;
        }

        public Image Imagen
        {
            get => this.imagen;
            set {
                this.imagen = value;
                this.picbox_Imagen.Image = imagen;
            }
        }

        public Image ImagenHover
        {
            get => this.imagenHover;
            set => this.imagenHover = value;
        }

        public PictureBoxSizeMode Modo
        {
            get => this.picbox_Imagen.SizeMode;
            set => this.picbox_Imagen.SizeMode = value;
        }

        public Color ColorBorde
        {
            get => this.pnl_Borde.BackColor;
            set => this.pnl_Borde.BackColor = value;
        }

        public Color TextColor
        {
            get => this.glbl_Texto.ForeColor;
            set => this.glbl_Texto.ForeColor = value;
        }
        public string Texto
        {
            get => this.glbl_Texto.Text;
            set => this.glbl_Texto.Text = value;
        }

        public UserControl Seccion
        {
            get => this.seccion;
            set => this.seccion = value;
        }

        private void picbox_Imagen_MouseEnter(object sender, System.EventArgs e)
        {
            ColorBorde = Color.FromArgb(224, 136, 36);
            if(botonMenu){
                picbox_Imagen.Image = imagenHover;
            }
        }

        private void picbox_Imagen_MouseLeave(object sender, System.EventArgs e)
        {
            ColorBorde = Color.FromArgb(29, 29, 29);
            if (botonMenu)
            {
                picbox_Imagen.Image = imagen;
            }
        }

        private void picbox_Imagen_Click(object sender, System.EventArgs e)
        {
            OpcionClick?.Invoke(this, e);
            if (TipoNav)
            {
                foreach (CustomPanel con in Form1.Form1Instance.Controls.OfType<CustomPanel>())
                {
                    foreach (UCNavBar nav in con.Controls.OfType<UCNavBar>())
                    {
                        foreach (Panel panel in nav.Controls.OfType<Panel>())
                        {
                            UCNavButton navbtn = new UCNavButton();
                            navbtn.Texto = glbl_Texto.Text;
                            navbtn.Checked = true;
                            UCNavButton.unCheck(navbtn, panel);
                            panel.Controls.Add(navbtn);
                            foreach (Panel conteiner in con.Controls.OfType<Panel>())
                            {
                                navbtn.Seccion = Seccion;
                                navbtn.Container = conteiner;
                                Form1.MostrarSeccion(Seccion, conteiner);
                            }
                        }
                    }
                }
            }
            else
            {
                //Application.Exit();
            }
            
        }
    }
}
