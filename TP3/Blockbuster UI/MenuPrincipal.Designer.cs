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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnSocios = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnDevolucion);
            this.panel1.Controls.Add(this.btnSocios);
            this.panel1.Controls.Add(this.btnInventario);
            this.panel1.Controls.Add(this.btnVenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 534);
            this.panel1.TabIndex = 0;
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Location = new System.Drawing.Point(0, 279);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(204, 41);
            this.btnDevolucion.TabIndex = 4;
            this.btnDevolucion.Text = "Devolucion";
            this.btnDevolucion.UseVisualStyleBackColor = true;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // btnSocios
            // 
            this.btnSocios.Location = new System.Drawing.Point(0, 217);
            this.btnSocios.Name = "btnSocios";
            this.btnSocios.Size = new System.Drawing.Size(204, 41);
            this.btnSocios.TabIndex = 3;
            this.btnSocios.Text = "Lista de socios";
            this.btnSocios.UseVisualStyleBackColor = true;
            this.btnSocios.Click += new System.EventHandler(this.btnSocios_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(0, 156);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(204, 41);
            this.btnInventario.TabIndex = 2;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(0, 98);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(204, 41);
            this.btnVenta.TabIndex = 1;
            this.btnVenta.Text = "Nueva venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.button1_Click);
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
            this.Controls.Add(this.panel1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.Button btnSocios;
    }
}