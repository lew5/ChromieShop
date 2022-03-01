
namespace ChromieShop.usercontrols
{
    partial class UCNavBar
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
            this.pnl_ButtonsNav = new System.Windows.Forms.Panel();
            this.ucProductosEnCarrito1 = new ChromieShop.usercontrols.UCProductosEnCarrito();
            this.SuspendLayout();
            // 
            // pnl_ButtonsNav
            // 
            this.pnl_ButtonsNav.AutoSize = true;
            this.pnl_ButtonsNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_ButtonsNav.Location = new System.Drawing.Point(30, 20);
            this.pnl_ButtonsNav.Name = "pnl_ButtonsNav";
            this.pnl_ButtonsNav.Size = new System.Drawing.Size(0, 40);
            this.pnl_ButtonsNav.TabIndex = 0;
            // 
            // ucProductosEnCarrito1
            // 
            this.ucProductosEnCarrito1.BackColor = System.Drawing.Color.Transparent;
            this.ucProductosEnCarrito1.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucProductosEnCarrito1.Location = new System.Drawing.Point(1110, 20);
            this.ucProductosEnCarrito1.Margin = new System.Windows.Forms.Padding(0);
            this.ucProductosEnCarrito1.MaximumSize = new System.Drawing.Size(140, 40);
            this.ucProductosEnCarrito1.MinimumSize = new System.Drawing.Size(140, 40);
            this.ucProductosEnCarrito1.Name = "ucProductosEnCarrito1";
            this.ucProductosEnCarrito1.Size = new System.Drawing.Size(140, 40);
            this.ucProductosEnCarrito1.TabIndex = 1;
            // 
            // UCNavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ucProductosEnCarrito1);
            this.Controls.Add(this.pnl_ButtonsNav);
            this.MinimumSize = new System.Drawing.Size(0, 80);
            this.Name = "UCNavBar";
            this.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.Size = new System.Drawing.Size(1280, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ButtonsNav;
        private UCProductosEnCarrito ucProductosEnCarrito1;
    }
}
