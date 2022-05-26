namespace Blockbuster_UI
{
    partial class Devolucion
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
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblTituloPelicula = new System.Windows.Forms.Label();
            this.lblFechaAlquiler = new System.Windows.Forms.Label();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.lblDevolucion = new System.Windows.Forms.Label();
            this.lblPenalidad = new System.Windows.Forms.Label();
            this.lblPenalidadFinal = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPelicula.Location = new System.Drawing.Point(29, 19);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(107, 37);
            this.lblPelicula.TabIndex = 0;
            this.lblPelicula.Text = "Pelicula";
            // 
            // lblTituloPelicula
            // 
            this.lblTituloPelicula.AutoSize = true;
            this.lblTituloPelicula.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloPelicula.Location = new System.Drawing.Point(29, 77);
            this.lblTituloPelicula.Name = "lblTituloPelicula";
            this.lblTituloPelicula.Size = new System.Drawing.Size(142, 25);
            this.lblTituloPelicula.TabIndex = 1;
            this.lblTituloPelicula.Text = "titulo de pelicula";
            // 
            // lblFechaAlquiler
            // 
            this.lblFechaAlquiler.AutoSize = true;
            this.lblFechaAlquiler.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaAlquiler.Location = new System.Drawing.Point(38, 151);
            this.lblFechaAlquiler.Name = "lblFechaAlquiler";
            this.lblFechaAlquiler.Size = new System.Drawing.Size(164, 31);
            this.lblFechaAlquiler.TabIndex = 2;
            this.lblFechaAlquiler.Text = "Fecha Alquiler:";
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlquiler.Location = new System.Drawing.Point(258, 158);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(119, 25);
            this.lblAlquiler.TabIndex = 3;
            this.lblAlquiler.Text = "Fecha alquiler";
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaDevolucion.Location = new System.Drawing.Point(38, 215);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(198, 31);
            this.lblFechaDevolucion.TabIndex = 4;
            this.lblFechaDevolucion.Text = "Fecha Devolucion:";
            // 
            // lblDevolucion
            // 
            this.lblDevolucion.AutoSize = true;
            this.lblDevolucion.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDevolucion.Location = new System.Drawing.Point(258, 215);
            this.lblDevolucion.Name = "lblDevolucion";
            this.lblDevolucion.Size = new System.Drawing.Size(149, 25);
            this.lblDevolucion.TabIndex = 5;
            this.lblDevolucion.Text = "Fecha devolucion";
            // 
            // lblPenalidad
            // 
            this.lblPenalidad.AutoSize = true;
            this.lblPenalidad.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPenalidad.Location = new System.Drawing.Point(38, 273);
            this.lblPenalidad.Name = "lblPenalidad";
            this.lblPenalidad.Size = new System.Drawing.Size(126, 31);
            this.lblPenalidad.TabIndex = 6;
            this.lblPenalidad.Text = "Penalidad: ";
            // 
            // lblPenalidadFinal
            // 
            this.lblPenalidadFinal.AutoSize = true;
            this.lblPenalidadFinal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPenalidadFinal.Location = new System.Drawing.Point(258, 273);
            this.lblPenalidadFinal.Name = "lblPenalidadFinal";
            this.lblPenalidadFinal.Size = new System.Drawing.Size(88, 25);
            this.lblPenalidadFinal.TabIndex = 7;
            this.lblPenalidadFinal.Text = "Penalidad";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(262, 344);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(136, 39);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 410);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblPenalidadFinal);
            this.Controls.Add(this.lblPenalidad);
            this.Controls.Add(this.lblDevolucion);
            this.Controls.Add(this.lblFechaDevolucion);
            this.Controls.Add(this.lblAlquiler);
            this.Controls.Add(this.lblFechaAlquiler);
            this.Controls.Add(this.lblTituloPelicula);
            this.Controls.Add(this.lblPelicula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Devolucion";
            this.Text = "Devolucion";
            this.Load += new System.EventHandler(this.Devolucion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.Label lblTituloPelicula;
        private System.Windows.Forms.Label lblFechaAlquiler;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.Label lblDevolucion;
        private System.Windows.Forms.Label lblPenalidad;
        private System.Windows.Forms.Label lblPenalidadFinal;
        private System.Windows.Forms.Button btnConfirmar;
    }
}