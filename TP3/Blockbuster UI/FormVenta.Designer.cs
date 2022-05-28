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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
            this.txtNumeroSocio = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.pnlInfoUsuario = new System.Windows.Forms.Panel();
            this.btnAgregarAlquiler = new System.Windows.Forms.Button();
            this.lblNoHayPeliculas = new System.Windows.Forms.Label();
            this.dGridAlquileres = new System.Windows.Forms.DataGridView();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlInfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAlquileres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumeroSocio
            // 
            this.txtNumeroSocio.Location = new System.Drawing.Point(12, 21);
            this.txtNumeroSocio.Name = "txtNumeroSocio";
            this.txtNumeroSocio.PlaceholderText = "Numero de socio";
            this.txtNumeroSocio.Size = new System.Drawing.Size(186, 23);
            this.txtNumeroSocio.TabIndex = 0;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.Control;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(33, 47);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(165, 15);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "*Error, favor verificar los datos";
            this.lblError.Visible = false;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreUsuario.Location = new System.Drawing.Point(61, 22);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(102, 32);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(262, 22);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(102, 32);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(465, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(49, 32);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID: ";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLimite.Location = new System.Drawing.Point(61, 94);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(141, 21);
            this.lblLimite.TabIndex = 6;
            this.lblLimite.Text = "Limite de películas:";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDisponible.Location = new System.Drawing.Point(312, 94);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(136, 21);
            this.lblDisponible.TabIndex = 7;
            this.lblDisponible.Text = "Limite disponible: ";
            // 
            // pnlInfoUsuario
            // 
            this.pnlInfoUsuario.Controls.Add(this.btnAgregarAlquiler);
            this.pnlInfoUsuario.Controls.Add(this.lblNoHayPeliculas);
            this.pnlInfoUsuario.Controls.Add(this.dGridAlquileres);
            this.pnlInfoUsuario.Controls.Add(this.lblDisponible);
            this.pnlInfoUsuario.Controls.Add(this.lblLimite);
            this.pnlInfoUsuario.Controls.Add(this.lblID);
            this.pnlInfoUsuario.Controls.Add(this.lblApellido);
            this.pnlInfoUsuario.Controls.Add(this.lblNombreUsuario);
            this.pnlInfoUsuario.Location = new System.Drawing.Point(204, 0);
            this.pnlInfoUsuario.Name = "pnlInfoUsuario";
            this.pnlInfoUsuario.Size = new System.Drawing.Size(693, 535);
            this.pnlInfoUsuario.TabIndex = 8;
            // 
            // btnAgregarAlquiler
            // 
            this.btnAgregarAlquiler.Location = new System.Drawing.Point(480, 408);
            this.btnAgregarAlquiler.Name = "btnAgregarAlquiler";
            this.btnAgregarAlquiler.Size = new System.Drawing.Size(137, 45);
            this.btnAgregarAlquiler.TabIndex = 10;
            this.btnAgregarAlquiler.Text = "Agregar +";
            this.btnAgregarAlquiler.UseVisualStyleBackColor = true;
            this.btnAgregarAlquiler.Click += new System.EventHandler(this.btnAgregarAlquiler_Click);
            // 
            // lblNoHayPeliculas
            // 
            this.lblNoHayPeliculas.AutoSize = true;
            this.lblNoHayPeliculas.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNoHayPeliculas.Location = new System.Drawing.Point(71, 218);
            this.lblNoHayPeliculas.Name = "lblNoHayPeliculas";
            this.lblNoHayPeliculas.Size = new System.Drawing.Size(473, 37);
            this.lblNoHayPeliculas.TabIndex = 9;
            this.lblNoHayPeliculas.Text = "Este usuario no tiene alquileres activos";
            this.lblNoHayPeliculas.Visible = false;
            // 
            // dGridAlquileres
            // 
            this.dGridAlquileres.AllowUserToAddRows = false;
            this.dGridAlquileres.AllowUserToDeleteRows = false;
            this.dGridAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridAlquileres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitulo,
            this.colDuracion,
            this.colPrecio,
            this.colDias,
            this.colFecha});
            this.dGridAlquileres.Location = new System.Drawing.Point(34, 183);
            this.dGridAlquileres.Name = "dGridAlquileres";
            this.dGridAlquileres.RowTemplate.Height = 25;
            this.dGridAlquileres.Size = new System.Drawing.Size(583, 196);
            this.dGridAlquileres.TabIndex = 8;
            this.dGridAlquileres.Visible = false;
            this.dGridAlquileres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridAlquileres_CellClick);
            // 
            // colTitulo
            // 
            this.colTitulo.HeaderText = "Titulo";
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.Width = 200;
            // 
            // colDuracion
            // 
            this.colDuracion.HeaderText = "Duracion";
            this.colDuracion.Name = "colDuracion";
            this.colDuracion.Width = 80;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Width = 80;
            // 
            // colDias
            // 
            this.colDias.HeaderText = "Dias de Alquiler";
            this.colDias.Name = "colDias";
            this.colDias.Width = 80;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha Alquiler";
            this.colFecha.Name = "colFecha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 378);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 94);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(181, 33);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 534);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pnlInfoUsuario);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtNumeroSocio);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVenta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            this.pnlInfoUsuario.ResumeLayout(false);
            this.pnlInfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAlquileres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroSocio;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Panel pnlInfoUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dGridAlquileres;
        private System.Windows.Forms.Label lblNoHayPeliculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.Button btnAgregarAlquiler;
    }
}