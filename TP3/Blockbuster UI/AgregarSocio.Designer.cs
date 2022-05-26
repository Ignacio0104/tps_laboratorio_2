namespace Blockbuster_UI
{
    partial class AgregarSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarSocio));
            this.picMemberCard = new System.Windows.Forms.PictureBox();
            this.txtBoxNombreSocio = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBoxApellidoSocio = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxEmailSocio = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            this.rdtSocioClasico = new System.Windows.Forms.RadioButton();
            this.rdtSocioPremium = new System.Windows.Forms.RadioButton();
            this.panTarjeta = new System.Windows.Forms.Panel();
            this.lblTarjetaSocio = new System.Windows.Forms.Label();
            this.txtBoxTarjetaSocio = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMemberCard)).BeginInit();
            this.panTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMemberCard
            // 
            this.picMemberCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMemberCard.BackgroundImage")));
            this.picMemberCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMemberCard.Location = new System.Drawing.Point(94, 2);
            this.picMemberCard.Name = "picMemberCard";
            this.picMemberCard.Size = new System.Drawing.Size(287, 165);
            this.picMemberCard.TabIndex = 0;
            this.picMemberCard.TabStop = false;
            // 
            // txtBoxNombreSocio
            // 
            this.txtBoxNombreSocio.Location = new System.Drawing.Point(12, 200);
            this.txtBoxNombreSocio.Name = "txtBoxNombreSocio";
            this.txtBoxNombreSocio.Size = new System.Drawing.Size(177, 23);
            this.txtBoxNombreSocio.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 182);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre : ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 235);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 15);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido : ";
            // 
            // txtBoxApellidoSocio
            // 
            this.txtBoxApellidoSocio.Location = new System.Drawing.Point(12, 253);
            this.txtBoxApellidoSocio.Name = "txtBoxApellidoSocio";
            this.txtBoxApellidoSocio.Size = new System.Drawing.Size(177, 23);
            this.txtBoxApellidoSocio.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 293);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 15);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail :";
            // 
            // txtBoxEmailSocio
            // 
            this.txtBoxEmailSocio.Location = new System.Drawing.Point(12, 311);
            this.txtBoxEmailSocio.Name = "txtBoxEmailSocio";
            this.txtBoxEmailSocio.Size = new System.Drawing.Size(177, 23);
            this.txtBoxEmailSocio.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(12, 350);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(58, 15);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono :";
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Location = new System.Drawing.Point(12, 368);
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.Size = new System.Drawing.Size(177, 23);
            this.txtBoxTelefono.TabIndex = 7;
            // 
            // rdtSocioClasico
            // 
            this.rdtSocioClasico.AutoSize = true;
            this.rdtSocioClasico.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdtSocioClasico.Location = new System.Drawing.Point(275, 226);
            this.rdtSocioClasico.Name = "rdtSocioClasico";
            this.rdtSocioClasico.Size = new System.Drawing.Size(134, 29);
            this.rdtSocioClasico.TabIndex = 9;
            this.rdtSocioClasico.Text = "Socio Clasico";
            this.rdtSocioClasico.UseVisualStyleBackColor = true;
            // 
            // rdtSocioPremium
            // 
            this.rdtSocioPremium.AutoSize = true;
            this.rdtSocioPremium.Checked = true;
            this.rdtSocioPremium.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdtSocioPremium.Location = new System.Drawing.Point(275, 293);
            this.rdtSocioPremium.Name = "rdtSocioPremium";
            this.rdtSocioPremium.Size = new System.Drawing.Size(150, 29);
            this.rdtSocioPremium.TabIndex = 10;
            this.rdtSocioPremium.TabStop = true;
            this.rdtSocioPremium.Text = "Socio Premium";
            this.rdtSocioPremium.UseVisualStyleBackColor = true;
            this.rdtSocioPremium.CheckedChanged += new System.EventHandler(this.rdtSocioPremium_CheckedChanged);
            // 
            // panTarjeta
            // 
            this.panTarjeta.Controls.Add(this.lblTarjetaSocio);
            this.panTarjeta.Controls.Add(this.txtBoxTarjetaSocio);
            this.panTarjeta.Location = new System.Drawing.Point(229, 328);
            this.panTarjeta.Name = "panTarjeta";
            this.panTarjeta.Size = new System.Drawing.Size(239, 89);
            this.panTarjeta.TabIndex = 11;
            this.panTarjeta.Visible = false;
            // 
            // lblTarjetaSocio
            // 
            this.lblTarjetaSocio.AutoSize = true;
            this.lblTarjetaSocio.Location = new System.Drawing.Point(27, 22);
            this.lblTarjetaSocio.Name = "lblTarjetaSocio";
            this.lblTarjetaSocio.Size = new System.Drawing.Size(105, 15);
            this.lblTarjetaSocio.TabIndex = 13;
            this.lblTarjetaSocio.Text = "Tarjeta de Credito :";
            // 
            // txtBoxTarjetaSocio
            // 
            this.txtBoxTarjetaSocio.Location = new System.Drawing.Point(27, 40);
            this.txtBoxTarjetaSocio.Name = "txtBoxTarjetaSocio";
            this.txtBoxTarjetaSocio.Size = new System.Drawing.Size(177, 23);
            this.txtBoxTarjetaSocio.TabIndex = 12;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(152, 441);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(156, 44);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // AgregarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 497);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.panTarjeta);
            this.Controls.Add(this.rdtSocioPremium);
            this.Controls.Add(this.rdtSocioClasico);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtBoxTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtBoxEmailSocio);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtBoxApellidoSocio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBoxNombreSocio);
            this.Controls.Add(this.picMemberCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarSocio";
            this.Text = "AgregarSocio";
            this.Load += new System.EventHandler(this.AgregarSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMemberCard)).EndInit();
            this.panTarjeta.ResumeLayout(false);
            this.panTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMemberCard;
        private System.Windows.Forms.TextBox txtBoxNombreSocio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtBoxApellidoSocio;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxEmailSocio;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtBoxTelefono;
        private System.Windows.Forms.RadioButton rdtSocioClasico;
        private System.Windows.Forms.RadioButton rdtSocioPremium;
        private System.Windows.Forms.Panel panTarjeta;
        private System.Windows.Forms.Label lblTarjetaSocio;
        private System.Windows.Forms.TextBox txtBoxTarjetaSocio;
        private System.Windows.Forms.Button btnConfirmar;
    }
}