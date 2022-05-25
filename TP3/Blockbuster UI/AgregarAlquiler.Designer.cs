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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dGridProducto = new System.Windows.Forms.DataGridView();
            this.picLogoBlockbuster = new System.Windows.Forms.PictureBox();
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
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 476);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(179, 41);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(963, 476);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(179, 41);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dGridProducto
            // 
            this.dGridProducto.AllowUserToAddRows = false;
            this.dGridProducto.AllowUserToDeleteRows = false;
            this.dGridProducto.AllowUserToOrderColumns = true;
            this.dGridProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // AgregarAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 541);
            this.Controls.Add(this.picLogoBlockbuster);
            this.Controls.Add(this.dGridProducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.richAlquileresParcial);
            this.Controls.Add(this.dGridPeliculas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarAlquiler";
            this.Text = "AgregarAlquiler";
            ((System.ComponentModel.ISupportInitialize)(this.dGridPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBlockbuster)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dGridProducto;
        private System.Windows.Forms.PictureBox picLogoBlockbuster;
    }
}