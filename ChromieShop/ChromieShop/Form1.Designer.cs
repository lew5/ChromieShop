
namespace ChromieShop
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.customPanel1 = new ChromieShop.custom.CustomPanel();
            this.Container = new System.Windows.Forms.Panel();
            this.ucSeccionMenu1 = new ChromieShop.usercontrols.UCSeccionMenu();
            this.ucNavBar1 = new ChromieShop.usercontrols.UCNavBar();
            this.customPanel1.SuspendLayout();
            this.Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.Controls.Add(this.Container);
            this.customPanel1.Controls.Add(this.ucNavBar1);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1280, 720);
            this.customPanel1.TabIndex = 2;
            // 
            // Container
            // 
            this.Container.Controls.Add(this.ucSeccionMenu1);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 80);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1280, 640);
            this.Container.TabIndex = 2;
            // 
            // ucSeccionMenu1
            // 
            this.ucSeccionMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSeccionMenu1.Location = new System.Drawing.Point(0, 0);
            this.ucSeccionMenu1.Name = "ucSeccionMenu1";
            this.ucSeccionMenu1.Size = new System.Drawing.Size(1280, 640);
            this.ucSeccionMenu1.TabIndex = 0;
            // 
            // ucNavBar1
            // 
            this.ucNavBar1.BackColor = System.Drawing.Color.Transparent;
            this.ucNavBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucNavBar1.Location = new System.Drawing.Point(0, 0);
            this.ucNavBar1.MinimumSize = new System.Drawing.Size(0, 80);
            this.ucNavBar1.Name = "ucNavBar1";
            this.ucNavBar1.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.ucNavBar1.Size = new System.Drawing.Size(1280, 80);
            this.ucNavBar1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.customPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.customPanel1.ResumeLayout(false);
            this.Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private custom.CustomPanel customPanel1;
        private System.Windows.Forms.Panel Container;
        private usercontrols.UCSeccionMenu ucSeccionMenu1;
        private usercontrols.UCNavBar ucNavBar1;
    }
}

