namespace Blockbuster_UI
{
    partial class AgregarAlquiler
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
            this.dGridPeliculas = new System.Windows.Forms.DataGridView();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGridPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridPeliculas
            // 
            this.dGridPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitulo,
            this.colDuracion,
            this.colGenero,
            this.colStock,
            this.colPrecio});
            this.dGridPeliculas.Location = new System.Drawing.Point(12, 39);
            this.dGridPeliculas.Name = "dGridPeliculas";
            this.dGridPeliculas.RowTemplate.Height = 25;
            this.dGridPeliculas.Size = new System.Drawing.Size(533, 269);
            this.dGridPeliculas.TabIndex = 0;
            // 
            // colTitulo
            // 
            this.colTitulo.HeaderText = "Titulo";
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.Width = 200;
            // 
            // colDuracion
            // 
            this.colDuracion.HeaderText = "Duración";
            this.colDuracion.Name = "colDuracion";
            this.colDuracion.Width = 80;
            // 
            // colGenero
            // 
            this.colGenero.HeaderText = "Genero";
            this.colGenero.Name = "colGenero";
            this.colGenero.Width = 80;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.Width = 60;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Width = 70;
            // 
            // AgregarAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 415);
            this.Controls.Add(this.dGridPeliculas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarAlquiler";
            this.Text = "AgregarAlquiler";
            ((System.ComponentModel.ISupportInitialize)(this.dGridPeliculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridPeliculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
    }
}