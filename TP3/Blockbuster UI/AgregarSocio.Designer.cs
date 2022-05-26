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
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMemberCard)).BeginInit();
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
            this.txtBoxNombreSocio.Location = new System.Drawing.Point(12, 213);
            this.txtBoxNombreSocio.Name = "txtBoxNombreSocio";
            this.txtBoxNombreSocio.Size = new System.Drawing.Size(177, 23);
            this.txtBoxNombreSocio.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 195);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre : ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 248);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 15);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido : ";
            // 
            // txtBoxApellidoSocio
            // 
            this.txtBoxApellidoSocio.Location = new System.Drawing.Point(12, 266);
            this.txtBoxApellidoSocio.Name = "txtBoxApellidoSocio";
            this.txtBoxApellidoSocio.Size = new System.Drawing.Size(177, 23);
            this.txtBoxApellidoSocio.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 306);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 15);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 23);
            this.textBox1.TabIndex = 5;
            // 
            // AgregarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 404);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtBoxApellidoSocio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBoxNombreSocio);
            this.Controls.Add(this.picMemberCard);
            this.Name = "AgregarSocio";
            this.Text = "AgregarSocio";
            this.Load += new System.EventHandler(this.AgregarSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMemberCard)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
    }
}