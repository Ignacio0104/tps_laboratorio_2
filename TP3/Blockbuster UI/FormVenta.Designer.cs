namespace Blockbuster_UI
{
    partial class FormVenta
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
            this.txtNumeroSocio = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumeroSocio
            // 
            this.txtNumeroSocio.Location = new System.Drawing.Point(36, 21);
            this.txtNumeroSocio.Name = "txtNumeroSocio";
            this.txtNumeroSocio.PlaceholderText = "Numero de socio";
            this.txtNumeroSocio.Size = new System.Drawing.Size(170, 23);
            this.txtNumeroSocio.TabIndex = 0;
            this.txtNumeroSocio.Leave += new System.EventHandler(this.txtNumeroSocio_Leave);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(165, 307);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(36, 47);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(165, 15);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "*Error, favor verificar los datos";
            this.lblError.Visible = false;
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtNumeroSocio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroSocio;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblError;
    }
}