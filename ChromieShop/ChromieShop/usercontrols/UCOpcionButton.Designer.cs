
namespace ChromieShop.usercontrols
{
    partial class UCOpcionButton
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
            this.pnl_Borde = new System.Windows.Forms.Panel();
            this.picbox_Imagen = new System.Windows.Forms.PictureBox();
            this.glbl_Texto = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Borde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Borde
            // 
            this.pnl_Borde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnl_Borde.Controls.Add(this.picbox_Imagen);
            this.pnl_Borde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Borde.Location = new System.Drawing.Point(0, 0);
            this.pnl_Borde.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Borde.Name = "pnl_Borde";
            this.pnl_Borde.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_Borde.Size = new System.Drawing.Size(150, 150);
            this.pnl_Borde.TabIndex = 0;
            // 
            // picbox_Imagen
            // 
            this.picbox_Imagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.picbox_Imagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox_Imagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbox_Imagen.Image = global::ChromieShop.Properties.Resources.categorias;
            this.picbox_Imagen.Location = new System.Drawing.Point(10, 10);
            this.picbox_Imagen.Margin = new System.Windows.Forms.Padding(0);
            this.picbox_Imagen.Name = "picbox_Imagen";
            this.picbox_Imagen.Size = new System.Drawing.Size(130, 130);
            this.picbox_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picbox_Imagen.TabIndex = 0;
            this.picbox_Imagen.TabStop = false;
            this.picbox_Imagen.Click += new System.EventHandler(this.picbox_Imagen_Click);
            this.picbox_Imagen.MouseEnter += new System.EventHandler(this.picbox_Imagen_MouseEnter);
            this.picbox_Imagen.MouseLeave += new System.EventHandler(this.picbox_Imagen_MouseLeave);
            // 
            // glbl_Texto
            // 
            this.glbl_Texto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.glbl_Texto.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.glbl_Texto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.glbl_Texto.Location = new System.Drawing.Point(0, 150);
            this.glbl_Texto.Margin = new System.Windows.Forms.Padding(0);
            this.glbl_Texto.Name = "glbl_Texto";
            this.glbl_Texto.Size = new System.Drawing.Size(150, 25);
            this.glbl_Texto.TabIndex = 1;
            this.glbl_Texto.Text = "Change Faction";
            this.glbl_Texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.glbl_Texto.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // UCOpcionButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.pnl_Borde);
            this.Controls.Add(this.glbl_Texto);
            this.Name = "UCOpcionButton";
            this.Size = new System.Drawing.Size(150, 175);
            this.Load += new System.EventHandler(this.UCOpcionButton_Load);
            this.pnl_Borde.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Borde;
        private System.Windows.Forms.PictureBox picbox_Imagen;
        private Guna.UI.WinForms.GunaLabel glbl_Texto;
    }
}
