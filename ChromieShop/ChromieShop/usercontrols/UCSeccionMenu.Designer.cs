
namespace ChromieShop.usercontrols
{
    partial class UCSeccionMenu
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSeccionMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucob_Salir = new ChromieShop.usercontrols.UCOpcionButton();
            this.ucob_Carrito = new ChromieShop.usercontrols.UCOpcionButton();
            this.ucob_Categorias = new ChromieShop.usercontrols.UCOpcionButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.ucob_Salir);
            this.panel1.Controls.Add(this.ucob_Carrito);
            this.panel1.Controls.Add(this.ucob_Categorias);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 560);
            this.panel1.TabIndex = 0;
            // 
            // ucob_Salir
            // 
            this.ucob_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ucob_Salir.BotonMenu = true;
            this.ucob_Salir.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ucob_Salir.Imagen = ((System.Drawing.Image)(resources.GetObject("ucob_Salir.Imagen")));
            this.ucob_Salir.ImagenHover = global::ChromieShop.Properties.Resources.salirHover;
            this.ucob_Salir.Location = new System.Drawing.Point(765, 193);
            this.ucob_Salir.Margin = new System.Windows.Forms.Padding(25);
            this.ucob_Salir.Modo = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ucob_Salir.Name = "ucob_Salir";
            this.ucob_Salir.Seccion = null;
            this.ucob_Salir.Size = new System.Drawing.Size(150, 175);
            this.ucob_Salir.TabIndex = 2;
            this.ucob_Salir.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucob_Salir.Texto = "Salir";
            this.ucob_Salir.TipoNav = false;
            this.ucob_Salir.OpcionClick += new System.EventHandler(this.ucob_Salir_OpcionClick);
            // 
            // ucob_Carrito
            // 
            this.ucob_Carrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ucob_Carrito.BotonMenu = true;
            this.ucob_Carrito.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ucob_Carrito.Imagen = ((System.Drawing.Image)(resources.GetObject("ucob_Carrito.Imagen")));
            this.ucob_Carrito.ImagenHover = global::ChromieShop.Properties.Resources.carritoHover;
            this.ucob_Carrito.Location = new System.Drawing.Point(565, 193);
            this.ucob_Carrito.Margin = new System.Windows.Forms.Padding(25);
            this.ucob_Carrito.Modo = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ucob_Carrito.Name = "ucob_Carrito";
            this.ucob_Carrito.Seccion = null;
            this.ucob_Carrito.Size = new System.Drawing.Size(150, 175);
            this.ucob_Carrito.TabIndex = 1;
            this.ucob_Carrito.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucob_Carrito.Texto = "Carrito";
            this.ucob_Carrito.TipoNav = true;
            this.ucob_Carrito.OpcionClick += new System.EventHandler(this.ucob_Carrito_OpcionClick);
            // 
            // ucob_Categorias
            // 
            this.ucob_Categorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ucob_Categorias.BotonMenu = true;
            this.ucob_Categorias.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ucob_Categorias.Imagen = ((System.Drawing.Image)(resources.GetObject("ucob_Categorias.Imagen")));
            this.ucob_Categorias.ImagenHover = global::ChromieShop.Properties.Resources.categoriasHover;
            this.ucob_Categorias.Location = new System.Drawing.Point(365, 193);
            this.ucob_Categorias.Margin = new System.Windows.Forms.Padding(25);
            this.ucob_Categorias.Modo = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ucob_Categorias.Name = "ucob_Categorias";
            this.ucob_Categorias.Seccion = null;
            this.ucob_Categorias.Size = new System.Drawing.Size(150, 175);
            this.ucob_Categorias.TabIndex = 0;
            this.ucob_Categorias.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucob_Categorias.Texto = "Categorías";
            this.ucob_Categorias.TipoNav = true;
            this.ucob_Categorias.OpcionClick += new System.EventHandler(this.ucOpcionButton1_OpcionClick);
            // 
            // UCSeccionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCSeccionMenu";
            this.Size = new System.Drawing.Size(1280, 560);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UCOpcionButton ucob_Salir;
        private UCOpcionButton ucob_Carrito;
        private UCOpcionButton ucob_Categorias;
    }
}
