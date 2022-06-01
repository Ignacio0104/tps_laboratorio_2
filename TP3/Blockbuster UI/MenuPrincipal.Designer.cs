namespace Blockbuster_UI
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnSocios = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(157)))));
            this.panelMenu.Controls.Add(this.picUsuario);
            this.panelMenu.Controls.Add(this.lblNombreUsuario);
            this.panelMenu.Controls.Add(this.btnSocios);
            this.panelMenu.Controls.Add(this.btnInventario);
            this.panelMenu.Controls.Add(this.btnVenta);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(204, 534);
            this.panelMenu.TabIndex = 0;
            // 
            // picUsuario
            // 
            this.picUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUsuario.BackgroundImage")));
            this.picUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picUsuario.Location = new System.Drawing.Point(0, 5);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(204, 132);
            this.picUsuario.TabIndex = 6;
            this.picUsuario.TabStop = false;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreUsuario.Location = new System.Drawing.Point(12, 150);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(78, 25);
            this.lblNombreUsuario.TabIndex = 2;
            this.lblNombreUsuario.Text = "label1";
            // 
            // btnSocios
            // 
            this.btnSocios.FlatAppearance.BorderSize = 0;
            this.btnSocios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSocios.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSocios.Image = ((System.Drawing.Image)(resources.GetObject("btnSocios.Image")));
            this.btnSocios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSocios.Location = new System.Drawing.Point(0, 334);
            this.btnSocios.Name = "btnSocios";
            this.btnSocios.Padding = new System.Windows.Forms.Padding(10, 0, 23, 0);
            this.btnSocios.Size = new System.Drawing.Size(204, 41);
            this.btnSocios.TabIndex = 3;
            this.btnSocios.Text = "Lista de socios";
            this.btnSocios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSocios.UseVisualStyleBackColor = true;
            this.btnSocios.Click += new System.EventHandler(this.btnSocios_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventario.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInventario.Location = new System.Drawing.Point(0, 273);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(10, 0, 17, 0);
            this.btnInventario.Size = new System.Drawing.Size(204, 41);
            this.btnInventario.TabIndex = 2;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVenta.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnVenta.Image")));
            this.btnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVenta.Location = new System.Drawing.Point(0, 215);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnVenta.Size = new System.Drawing.Size(204, 41);
            this.btnVenta.TabIndex = 1;
            this.btnVenta.Text = "Alquileres";
            this.btnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPrincipal.BackgroundImage")));
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(204, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(896, 534);
            this.panelPrincipal.TabIndex = 1;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 534);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnSocios;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox picUsuario;
    }
}