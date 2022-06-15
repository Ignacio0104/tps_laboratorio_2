namespace Blockbuster_UI
{
    partial class ReponerProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReponerProducto));
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnLlamarProveedor = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPuntoUno = new System.Windows.Forms.Label();
            this.picPhone = new System.Windows.Forms.PictureBox();
            this.picNoStock = new System.Windows.Forms.PictureBox();
            this.panLlamada = new System.Windows.Forms.Panel();
            this.lblLlamando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNoStock)).BeginInit();
            this.panLlamada.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblMensaje.Location = new System.Drawing.Point(41, 32);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(265, 30);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Producto agotado!!";
            // 
            // btnLlamarProveedor
            // 
            this.btnLlamarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLlamarProveedor.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLlamarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnLlamarProveedor.Location = new System.Drawing.Point(21, 227);
            this.btnLlamarProveedor.Name = "btnLlamarProveedor";
            this.btnLlamarProveedor.Size = new System.Drawing.Size(110, 46);
            this.btnLlamarProveedor.TabIndex = 1;
            this.btnLlamarProveedor.Text = "Llamar al proveedor";
            this.btnLlamarProveedor.UseVisualStyleBackColor = true;
            this.btnLlamarProveedor.Click += new System.EventHandler(this.btnLlamarProveedor_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(205, 227);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 46);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPuntoUno
            // 
            this.lblPuntoUno.AutoSize = true;
            this.lblPuntoUno.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPuntoUno.Location = new System.Drawing.Point(124, 45);
            this.lblPuntoUno.Name = "lblPuntoUno";
            this.lblPuntoUno.Size = new System.Drawing.Size(160, 86);
            this.lblPuntoUno.TabIndex = 12;
            this.lblPuntoUno.Text = ".  .  .";
            this.lblPuntoUno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picPhone
            // 
            this.picPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPhone.BackgroundImage")));
            this.picPhone.Location = new System.Drawing.Point(3, 13);
            this.picPhone.Name = "picPhone";
            this.picPhone.Size = new System.Drawing.Size(125, 118);
            this.picPhone.TabIndex = 11;
            this.picPhone.TabStop = false;
            // 
            // picNoStock
            // 
            this.picNoStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picNoStock.BackgroundImage")));
            this.picNoStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picNoStock.Location = new System.Drawing.Point(92, 76);
            this.picNoStock.Name = "picNoStock";
            this.picNoStock.Size = new System.Drawing.Size(162, 118);
            this.picNoStock.TabIndex = 13;
            this.picNoStock.TabStop = false;
            // 
            // panLlamada
            // 
            this.panLlamada.Controls.Add(this.lblLlamando);
            this.panLlamada.Controls.Add(this.picPhone);
            this.panLlamada.Controls.Add(this.lblPuntoUno);
            this.panLlamada.Location = new System.Drawing.Point(23, 76);
            this.panLlamada.Name = "panLlamada";
            this.panLlamada.Size = new System.Drawing.Size(292, 134);
            this.panLlamada.TabIndex = 14;
            this.panLlamada.Visible = false;
            // 
            // lblLlamando
            // 
            this.lblLlamando.AutoSize = true;
            this.lblLlamando.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLlamando.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblLlamando.Location = new System.Drawing.Point(116, 45);
            this.lblLlamando.Name = "lblLlamando";
            this.lblLlamando.Size = new System.Drawing.Size(176, 19);
            this.lblLlamando.TabIndex = 13;
            this.lblLlamando.Text = "Llamando, por favor espere";
            // 
            // ReponerProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(349, 309);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLlamarProveedor);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.panLlamada);
            this.Controls.Add(this.picNoStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReponerProducto";
            this.Text = "Reponer productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReponerProducto_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNoStock)).EndInit();
            this.panLlamada.ResumeLayout(false);
            this.panLlamada.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnLlamarProveedor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPuntoUno;
        private System.Windows.Forms.PictureBox picPhone;
        private System.Windows.Forms.PictureBox picNoStock;
        private System.Windows.Forms.Panel panLlamada;
        private System.Windows.Forms.Label lblLlamando;
    }
}