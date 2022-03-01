
namespace ChromieShop.usercontrols
{
    partial class UCNavButton
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
            this.gab_Button = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // gab_Button
            // 
            this.gab_Button.AnimationHoverSpeed = 0.07F;
            this.gab_Button.AnimationSpeed = 0.03F;
            this.gab_Button.BackColor = System.Drawing.Color.Transparent;
            this.gab_Button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.gab_Button.BorderColor = System.Drawing.Color.Black;
            this.gab_Button.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gab_Button.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(136)))), ((int)(((byte)(36)))));
            this.gab_Button.CheckedBorderColor = System.Drawing.Color.Black;
            this.gab_Button.CheckedForeColor = System.Drawing.Color.White;
            this.gab_Button.CheckedImage = null;
            this.gab_Button.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gab_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gab_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gab_Button.FocusedColor = System.Drawing.Color.Empty;
            this.gab_Button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gab_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.gab_Button.Image = null;
            this.gab_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gab_Button.ImageSize = new System.Drawing.Size(20, 20);
            this.gab_Button.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gab_Button.Location = new System.Drawing.Point(0, 0);
            this.gab_Button.Name = "gab_Button";
            this.gab_Button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.gab_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gab_Button.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.gab_Button.OnHoverImage = null;
            this.gab_Button.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gab_Button.OnPressedColor = System.Drawing.Color.Black;
            this.gab_Button.Radius = 10;
            this.gab_Button.Size = new System.Drawing.Size(150, 40);
            this.gab_Button.TabIndex = 0;
            this.gab_Button.Text = "Menú";
            this.gab_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gab_Button.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.gab_Button.TextChanged += new System.EventHandler(this.gab_Button_TextChanged);
            this.gab_Button.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // UCNavButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gab_Button);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UCNavButton";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Size = new System.Drawing.Size(160, 40);
            this.Load += new System.EventHandler(this.UCNavButton_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton gab_Button;
    }
}
