namespace Blockbuster_UI
{
    partial class AgregarProducto
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
            this.rdtPeliculas = new System.Windows.Forms.RadioButton();
            this.rdtProductos = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxTituloPelicula = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblAclaracion = new System.Windows.Forms.Label();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.rdtAccion = new System.Windows.Forms.RadioButton();
            this.rdtCienciaFiccion = new System.Windows.Forms.RadioButton();
            this.rdtComedia = new System.Windows.Forms.RadioButton();
            this.rdtDrama = new System.Windows.Forms.RadioButton();
            this.rdtAnimada = new System.Windows.Forms.RadioButton();
            this.rdtSuspenso = new System.Windows.Forms.RadioButton();
            this.rdtTerror = new System.Windows.Forms.RadioButton();
            this.cmbDiasDeAlquiler = new System.Windows.Forms.ComboBox();
            this.lblDiasAlquiler = new System.Windows.Forms.Label();
            this.lblPrecioAlquiler = new System.Windows.Forms.Label();
            this.cmbPrecioAlquiler = new System.Windows.Forms.ComboBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.nupStock = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grpGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).BeginInit();
            this.SuspendLayout();
            // 
            // rdtPeliculas
            // 
            this.rdtPeliculas.AutoSize = true;
            this.rdtPeliculas.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdtPeliculas.Location = new System.Drawing.Point(36, 43);
            this.rdtPeliculas.Name = "rdtPeliculas";
            this.rdtPeliculas.Size = new System.Drawing.Size(95, 29);
            this.rdtPeliculas.TabIndex = 0;
            this.rdtPeliculas.TabStop = true;
            this.rdtPeliculas.Text = "Peliculas";
            this.rdtPeliculas.UseVisualStyleBackColor = true;
            // 
            // rdtProductos
            // 
            this.rdtProductos.AutoSize = true;
            this.rdtProductos.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdtProductos.Location = new System.Drawing.Point(271, 43);
            this.rdtProductos.Name = "rdtProductos";
            this.rdtProductos.Size = new System.Drawing.Size(111, 29);
            this.rdtProductos.TabIndex = 1;
            this.rdtProductos.TabStop = true;
            this.rdtProductos.Text = "Productos";
            this.rdtProductos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblStock);
            this.panel1.Controls.Add(this.nupStock);
            this.panel1.Controls.Add(this.lblPrecioAlquiler);
            this.panel1.Controls.Add(this.cmbPrecioAlquiler);
            this.panel1.Controls.Add(this.lblDiasAlquiler);
            this.panel1.Controls.Add(this.cmbDiasDeAlquiler);
            this.panel1.Controls.Add(this.grpGenero);
            this.panel1.Controls.Add(this.lblAclaracion);
            this.panel1.Controls.Add(this.lblDuracion);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.txtBoxTituloPelicula);
            this.panel1.Location = new System.Drawing.Point(14, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 296);
            this.panel1.TabIndex = 2;
            // 
            // txtBoxTituloPelicula
            // 
            this.txtBoxTituloPelicula.Location = new System.Drawing.Point(22, 36);
            this.txtBoxTituloPelicula.Name = "txtBoxTituloPelicula";
            this.txtBoxTituloPelicula.Size = new System.Drawing.Size(342, 23);
            this.txtBoxTituloPelicula.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(22, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(52, 21);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(128, 70);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 23);
            this.numericUpDown1.TabIndex = 2;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDuracion.Location = new System.Drawing.Point(22, 67);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(76, 21);
            this.lblDuracion.TabIndex = 3;
            this.lblDuracion.Text = "Duracion:";
            // 
            // lblAclaracion
            // 
            this.lblAclaracion.AutoSize = true;
            this.lblAclaracion.Location = new System.Drawing.Point(22, 88);
            this.lblAclaracion.Name = "lblAclaracion";
            this.lblAclaracion.Size = new System.Drawing.Size(72, 15);
            this.lblAclaracion.TabIndex = 4;
            this.lblAclaracion.Text = "*en minutos";
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdtTerror);
            this.grpGenero.Controls.Add(this.rdtSuspenso);
            this.grpGenero.Controls.Add(this.rdtAnimada);
            this.grpGenero.Controls.Add(this.rdtDrama);
            this.grpGenero.Controls.Add(this.rdtComedia);
            this.grpGenero.Controls.Add(this.rdtCienciaFiccion);
            this.grpGenero.Controls.Add(this.rdtAccion);
            this.grpGenero.Location = new System.Drawing.Point(251, 70);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(113, 204);
            this.grpGenero.TabIndex = 5;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Genero";
            // 
            // rdtAccion
            // 
            this.rdtAccion.AutoSize = true;
            this.rdtAccion.Location = new System.Drawing.Point(6, 22);
            this.rdtAccion.Name = "rdtAccion";
            this.rdtAccion.Size = new System.Drawing.Size(62, 19);
            this.rdtAccion.TabIndex = 0;
            this.rdtAccion.TabStop = true;
            this.rdtAccion.Text = "Accion";
            this.rdtAccion.UseVisualStyleBackColor = true;
            // 
            // rdtCienciaFiccion
            // 
            this.rdtCienciaFiccion.AutoSize = true;
            this.rdtCienciaFiccion.Location = new System.Drawing.Point(6, 147);
            this.rdtCienciaFiccion.Name = "rdtCienciaFiccion";
            this.rdtCienciaFiccion.Size = new System.Drawing.Size(102, 19);
            this.rdtCienciaFiccion.TabIndex = 1;
            this.rdtCienciaFiccion.TabStop = true;
            this.rdtCienciaFiccion.Text = "CienciaFiccion";
            this.rdtCienciaFiccion.UseVisualStyleBackColor = true;
            // 
            // rdtComedia
            // 
            this.rdtComedia.AutoSize = true;
            this.rdtComedia.Location = new System.Drawing.Point(6, 72);
            this.rdtComedia.Name = "rdtComedia";
            this.rdtComedia.Size = new System.Drawing.Size(73, 19);
            this.rdtComedia.TabIndex = 2;
            this.rdtComedia.TabStop = true;
            this.rdtComedia.Text = "Comedia";
            this.rdtComedia.UseVisualStyleBackColor = true;
            // 
            // rdtDrama
            // 
            this.rdtDrama.AutoSize = true;
            this.rdtDrama.Location = new System.Drawing.Point(6, 47);
            this.rdtDrama.Name = "rdtDrama";
            this.rdtDrama.Size = new System.Drawing.Size(60, 19);
            this.rdtDrama.TabIndex = 3;
            this.rdtDrama.TabStop = true;
            this.rdtDrama.Text = "Drama";
            this.rdtDrama.UseVisualStyleBackColor = true;
            // 
            // rdtAnimada
            // 
            this.rdtAnimada.AutoSize = true;
            this.rdtAnimada.Location = new System.Drawing.Point(6, 172);
            this.rdtAnimada.Name = "rdtAnimada";
            this.rdtAnimada.Size = new System.Drawing.Size(73, 19);
            this.rdtAnimada.TabIndex = 4;
            this.rdtAnimada.TabStop = true;
            this.rdtAnimada.Text = "Animada";
            this.rdtAnimada.UseVisualStyleBackColor = true;
            // 
            // rdtSuspenso
            // 
            this.rdtSuspenso.AutoSize = true;
            this.rdtSuspenso.Location = new System.Drawing.Point(6, 122);
            this.rdtSuspenso.Name = "rdtSuspenso";
            this.rdtSuspenso.Size = new System.Drawing.Size(75, 19);
            this.rdtSuspenso.TabIndex = 5;
            this.rdtSuspenso.TabStop = true;
            this.rdtSuspenso.Text = "Suspenso";
            this.rdtSuspenso.UseVisualStyleBackColor = true;
            // 
            // rdtTerror
            // 
            this.rdtTerror.AutoSize = true;
            this.rdtTerror.Location = new System.Drawing.Point(6, 97);
            this.rdtTerror.Name = "rdtTerror";
            this.rdtTerror.Size = new System.Drawing.Size(55, 19);
            this.rdtTerror.TabIndex = 6;
            this.rdtTerror.TabStop = true;
            this.rdtTerror.Text = "Terror";
            this.rdtTerror.UseVisualStyleBackColor = true;
            // 
            // cmbDiasDeAlquiler
            // 
            this.cmbDiasDeAlquiler.FormattingEnabled = true;
            this.cmbDiasDeAlquiler.Location = new System.Drawing.Point(22, 141);
            this.cmbDiasDeAlquiler.Name = "cmbDiasDeAlquiler";
            this.cmbDiasDeAlquiler.Size = new System.Drawing.Size(173, 23);
            this.cmbDiasDeAlquiler.TabIndex = 6;
            // 
            // lblDiasAlquiler
            // 
            this.lblDiasAlquiler.AutoSize = true;
            this.lblDiasAlquiler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiasAlquiler.Location = new System.Drawing.Point(22, 117);
            this.lblDiasAlquiler.Name = "lblDiasAlquiler";
            this.lblDiasAlquiler.Size = new System.Drawing.Size(124, 21);
            this.lblDiasAlquiler.TabIndex = 7;
            this.lblDiasAlquiler.Text = "Dias de alquiler: ";
            // 
            // lblPrecioAlquiler
            // 
            this.lblPrecioAlquiler.AutoSize = true;
            this.lblPrecioAlquiler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioAlquiler.Location = new System.Drawing.Point(22, 185);
            this.lblPrecioAlquiler.Name = "lblPrecioAlquiler";
            this.lblPrecioAlquiler.Size = new System.Drawing.Size(161, 21);
            this.lblPrecioAlquiler.TabIndex = 9;
            this.lblPrecioAlquiler.Text = "Categoria de alquiler: ";
            // 
            // cmbPrecioAlquiler
            // 
            this.cmbPrecioAlquiler.FormattingEnabled = true;
            this.cmbPrecioAlquiler.Location = new System.Drawing.Point(22, 209);
            this.cmbPrecioAlquiler.Name = "cmbPrecioAlquiler";
            this.cmbPrecioAlquiler.Size = new System.Drawing.Size(173, 23);
            this.cmbPrecioAlquiler.TabIndex = 8;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStock.Location = new System.Drawing.Point(22, 246);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(54, 21);
            this.lblStock.TabIndex = 11;
            this.lblStock.Text = "Stock: ";
            // 
            // nupStock
            // 
            this.nupStock.Location = new System.Drawing.Point(128, 246);
            this.nupStock.Name = "nupStock";
            this.nupStock.Size = new System.Drawing.Size(67, 23);
            this.nupStock.TabIndex = 10;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdtProductos);
            this.Controls.Add(this.rdtPeliculas);
            this.Name = "AgregarProducto";
            this.Text = "AgregarProducto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdtPeliculas;
        private System.Windows.Forms.RadioButton rdtProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxTituloPelicula;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblAclaracion;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.RadioButton rdtAccion;
        private System.Windows.Forms.RadioButton rdtTerror;
        private System.Windows.Forms.RadioButton rdtSuspenso;
        private System.Windows.Forms.RadioButton rdtAnimada;
        private System.Windows.Forms.RadioButton rdtDrama;
        private System.Windows.Forms.RadioButton rdtComedia;
        private System.Windows.Forms.RadioButton rdtCienciaFiccion;
        private System.Windows.Forms.Label lblDiasAlquiler;
        private System.Windows.Forms.ComboBox cmbDiasDeAlquiler;
        private System.Windows.Forms.Label lblPrecioAlquiler;
        private System.Windows.Forms.ComboBox cmbPrecioAlquiler;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown nupStock;
    }
}