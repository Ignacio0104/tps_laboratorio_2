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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarAlquiler));
            this.dGridPeliculas = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richAlquileresParcial = new System.Windows.Forms.RichTextBox();
            this.dGridProducto = new System.Windows.Forms.DataGridView();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picLogoBlockbuster = new System.Windows.Forms.PictureBox();
            this.lblFacturacion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBlockbuster)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridPeliculas
            // 
            this.dGridPeliculas.AllowUserToAddRows = false;
            this.dGridPeliculas.AllowUserToDeleteRows = false;
            this.dGridPeliculas.AllowUserToOrderColumns = true;
            this.dGridPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTitulo,
            this.colDuracion,
            this.colGenero,
            this.colStock,
            this.colPrecio});
            this.dGridPeliculas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dGridPeliculas.Location = new System.Drawing.Point(12, 30);
            this.dGridPeliculas.MultiSelect = false;
            this.dGridPeliculas.Name = "dGridPeliculas";
            this.dGridPeliculas.ReadOnly = true;
            this.dGridPeliculas.RowTemplate.Height = 25;
            this.dGridPeliculas.Size = new System.Drawing.Size(604, 221);
            this.dGridPeliculas.TabIndex = 0;
            this.dGridPeliculas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridPeliculas_CellClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 70;
            // 
            // colTitulo
            // 
            this.colTitulo.HeaderText = "Titulo";
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.ReadOnly = true;
            this.colTitulo.Width = 200;
            // 
            // colDuracion
            // 
            this.colDuracion.HeaderText = "Duración";
            this.colDuracion.Name = "colDuracion";
            this.colDuracion.ReadOnly = true;
            this.colDuracion.Width = 80;
            // 
            // colGenero
            // 
            this.colGenero.HeaderText = "Genero";
            this.colGenero.Name = "colGenero";
            this.colGenero.ReadOnly = true;
            this.colGenero.Width = 80;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            this.colStock.Width = 60;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 70;
            // 
            // richAlquileresParcial
            // 
            this.richAlquileresParcial.Location = new System.Drawing.Point(734, 30);
            this.richAlquileresParcial.Name = "richAlquileresParcial";
            this.richAlquileresParcial.Size = new System.Drawing.Size(408, 426);
            this.richAlquileresParcial.TabIndex = 1;
            this.richAlquileresParcial.Text = "";
            // 
            // dGridProducto
            // 
            this.dGridProducto.AllowUserToAddRows = false;
            this.dGridProducto.AllowUserToDeleteRows = false;
            this.dGridProducto.AllowUserToOrderColumns = true;
            this.dGridProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProducto,
            this.colNombre,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.dGridProducto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dGridProducto.Location = new System.Drawing.Point(12, 265);
            this.dGridProducto.MultiSelect = false;
            this.dGridProducto.Name = "dGridProducto";
            this.dGridProducto.ReadOnly = true;
            this.dGridProducto.RowTemplate.Height = 25;
            this.dGridProducto.Size = new System.Drawing.Size(473, 191);
            this.dGridProducto.TabIndex = 4;
            this.dGridProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridProducto_CellClick);
            // 
            // colIdProducto
            // 
            this.colIdProducto.FillWeight = 65.65144F;
            this.colIdProducto.HeaderText = "ID";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.FillWeight = 203.0457F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 65.65144F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 65.65144F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // picLogoBlockbuster
            // 
            this.picLogoBlockbuster.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogoBlockbuster.BackgroundImage")));
            this.picLogoBlockbuster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogoBlockbuster.Location = new System.Drawing.Point(482, 265);
            this.picLogoBlockbuster.Name = "picLogoBlockbuster";
            this.picLogoBlockbuster.Size = new System.Drawing.Size(253, 191);
            this.picLogoBlockbuster.TabIndex = 5;
            this.picLogoBlockbuster.TabStop = false;
            // 
            // lblFacturacion
            // 
            this.lblFacturacion.AutoSize = true;
            this.lblFacturacion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFacturacion.Location = new System.Drawing.Point(734, 476);
            this.lblFacturacion.Name = "lblFacturacion";
            this.lblFacturacion.Size = new System.Drawing.Size(132, 28);
            this.lblFacturacion.TabIndex = 7;
            this.lblFacturacion.Text = "Facturacion: $";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(963, 474);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(179, 41);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // AgregarAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 541);
            this.Controls.Add(this.lblFacturacion);
            this.Controls.Add(this.picLogoBlockbuster);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.richAlquileresParcial);
            this.Controls.Add(this.dGridPeliculas);
            this.Controls.Add(this.dGridProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarAlquiler";
            this.Text = "AgregarAlquiler";
            ((System.ComponentModel.ISupportInitialize)(this.dGridPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBlockbuster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridPeliculas;
        private System.Windows.Forms.RichTextBox richAlquileresParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridView dGridProducto;
        private System.Windows.Forms.PictureBox picLogoBlockbuster;
        private System.Windows.Forms.Label lblFacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnAceptar;
    }
}