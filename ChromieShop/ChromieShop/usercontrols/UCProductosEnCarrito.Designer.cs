
namespace ChromieShop.usercontrols
{
    partial class UCProductosEnCarrito
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
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel1);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(100, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(40, 40);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(40, 40);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "56";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.gunaLabel2.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(100, 40);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Carrito:";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // UCProductosEnCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(140, 40);
            this.MinimumSize = new System.Drawing.Size(140, 40);
            this.Name = "UCProductosEnCarrito";
            this.Size = new System.Drawing.Size(140, 40);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}
