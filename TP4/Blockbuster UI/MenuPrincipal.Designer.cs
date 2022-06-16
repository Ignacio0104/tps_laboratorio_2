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
            this.lblActualizacionInfo = new System.Windows.Forms.Label();
            this.lblAutoGuardado = new System.Windows.Forms.Label();
            this.lblReloj = new System.Windows.Forms.Label();
            this.btnListaEmpleados = new System.Windows.Forms.Button();
            this.btnSalirSinGuardar = new System.Windows.Forms.Button();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnSocios = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.picSwitchOn = new System.Windows.Forms.PictureBox();
            this.picSwitchOff = new System.Windows.Forms.PictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitchOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitchOff)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(157)))));
            this.panelMenu.Controls.Add(this.lblActualizacionInfo);
            this.panelMenu.Controls.Add(this.lblAutoGuardado);
            this.panelMenu.Controls.Add(this.lblReloj);
            this.panelMenu.Controls.Add(this.btnListaEmpleados);
            this.panelMenu.Controls.Add(this.btnSalirSinGuardar);
            this.panelMenu.Controls.Add(this.picUsuario);
            this.panelMenu.Controls.Add(this.lblNombreUsuario);
            this.panelMenu.Controls.Add(this.btnSocios);
            this.panelMenu.Controls.Add(this.btnInventario);
            this.panelMenu.Controls.Add(this.btnVenta);
            this.panelMenu.Controls.Add(this.picSwitchOn);
            this.panelMenu.Controls.Add(this.picSwitchOff);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(204, 534);
            this.panelMenu.TabIndex = 0;
            // 
            // lblActualizacionInfo
            // 
            this.lblActualizacionInfo.AutoSize = true;
            this.lblActualizacionInfo.Location = new System.Drawing.Point(3, 459);
            this.lblActualizacionInfo.Name = "lblActualizacionInfo";
            this.lblActualizacionInfo.Size = new System.Drawing.Size(198, 15);
            this.lblActualizacionInfo.TabIndex = 13;
            this.lblActualizacionInfo.Text = "La base de datos está desactualizada";
            // 
            // lblAutoGuardado
            // 
            this.lblAutoGuardado.AutoSize = true;
            this.lblAutoGuardado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAutoGuardado.Location = new System.Drawing.Point(3, 429);
            this.lblAutoGuardado.Name = "lblAutoGuardado";
            this.lblAutoGuardado.Size = new System.Drawing.Size(50, 20);
            this.lblAutoGuardado.TabIndex = 12;
            this.lblAutoGuardado.Text = "label1";
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReloj.Location = new System.Drawing.Point(12, 9);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(137, 20);
            this.lblReloj.TabIndex = 9;
            this.lblReloj.Text = "Error al cargar reloj";
            // 
            // btnListaEmpleados
            // 
            this.btnListaEmpleados.FlatAppearance.BorderSize = 0;
            this.btnListaEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListaEmpleados.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListaEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnListaEmpleados.Image")));
            this.btnListaEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListaEmpleados.Location = new System.Drawing.Point(0, 356);
            this.btnListaEmpleados.Name = "btnListaEmpleados";
            this.btnListaEmpleados.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnListaEmpleados.Size = new System.Drawing.Size(204, 41);
            this.btnListaEmpleados.TabIndex = 8;
            this.btnListaEmpleados.Text = "Lista de empleados";
            this.btnListaEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaEmpleados.UseVisualStyleBackColor = true;
            this.btnListaEmpleados.Click += new System.EventHandler(this.btnListaEmpleados_Click);
            // 
            // btnSalirSinGuardar
            // 
            this.btnSalirSinGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            this.btnSalirSinGuardar.FlatAppearance.BorderSize = 0;
            this.btnSalirSinGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirSinGuardar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalirSinGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(157)))));
            this.btnSalirSinGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalirSinGuardar.Image")));
            this.btnSalirSinGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirSinGuardar.Location = new System.Drawing.Point(0, 493);
            this.btnSalirSinGuardar.Name = "btnSalirSinGuardar";
            this.btnSalirSinGuardar.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnSalirSinGuardar.Size = new System.Drawing.Size(204, 41);
            this.btnSalirSinGuardar.TabIndex = 7;
            this.btnSalirSinGuardar.Text = "Salir sin guardar";
            this.btnSalirSinGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirSinGuardar.UseVisualStyleBackColor = false;
            this.btnSalirSinGuardar.Click += new System.EventHandler(this.btnSalirSinGuardar_Click);
            // 
            // picUsuario
            // 
            this.picUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUsuario.BackgroundImage")));
            this.picUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picUsuario.Location = new System.Drawing.Point(0, 39);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(204, 132);
            this.picUsuario.TabIndex = 6;
            this.picUsuario.TabStop = false;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreUsuario.Location = new System.Drawing.Point(3, 180);
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
            this.btnSocios.Location = new System.Drawing.Point(0, 309);
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
            this.btnInventario.Location = new System.Drawing.Point(0, 262);
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
            // picSwitchOn
            // 
            this.picSwitchOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSwitchOn.BackgroundImage")));
            this.picSwitchOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSwitchOn.Location = new System.Drawing.Point(128, 423);
            this.picSwitchOn.Name = "picSwitchOn";
            this.picSwitchOn.Size = new System.Drawing.Size(76, 33);
            this.picSwitchOn.TabIndex = 11;
            this.picSwitchOn.TabStop = false;
            this.picSwitchOn.Click += new System.EventHandler(this.picSwitchOn_Click);
            // 
            // picSwitchOff
            // 
            this.picSwitchOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSwitchOff.BackgroundImage")));
            this.picSwitchOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSwitchOff.Location = new System.Drawing.Point(128, 423);
            this.picSwitchOff.Name = "picSwitchOff";
            this.picSwitchOff.Size = new System.Drawing.Size(76, 33);
            this.picSwitchOff.TabIndex = 10;
            this.picSwitchOff.TabStop = false;
            this.picSwitchOff.Click += new System.EventHandler(this.picSwitchOff_Click);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitchOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwitchOff)).EndInit();
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
        private System.Windows.Forms.Button btnSalirSinGuardar;
        private System.Windows.Forms.Button btnListaEmpleados;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Label lblAutoGuardado;
        private System.Windows.Forms.PictureBox picSwitchOn;
        private System.Windows.Forms.PictureBox picSwitchOff;
        private System.Windows.Forms.Label lblActualizacionInfo;
    }
}