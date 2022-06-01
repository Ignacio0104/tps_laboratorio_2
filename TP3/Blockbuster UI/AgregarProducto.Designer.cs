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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            this.rdtPeliculas = new System.Windows.Forms.RadioButton();
            this.rdtProductos = new System.Windows.Forms.RadioButton();
            this.panPeliculas = new System.Windows.Forms.Panel();
            this.lblStock = new System.Windows.Forms.Label();
            this.nupStock = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioAlquiler = new System.Windows.Forms.Label();
            this.cmbPrecioAlquiler = new System.Windows.Forms.ComboBox();
            this.lblDiasAlquiler = new System.Windows.Forms.Label();
            this.cmbDiasDeAlquiler = new System.Windows.Forms.ComboBox();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.rdtTerror = new System.Windows.Forms.RadioButton();
            this.rdtSuspenso = new System.Windows.Forms.RadioButton();
            this.rdtAnimada = new System.Windows.Forms.RadioButton();
            this.rdtDrama = new System.Windows.Forms.RadioButton();
            this.rdtComedia = new System.Windows.Forms.RadioButton();
            this.rdtCienciaFiccion = new System.Windows.Forms.RadioButton();
            this.rdtAccion = new System.Windows.Forms.RadioButton();
            this.lblAclaracion = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.nupDuracion = new System.Windows.Forms.NumericUpDown();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBoxTituloPelicula = new System.Windows.Forms.TextBox();
            this.panProductos = new System.Windows.Forms.Panel();
            this.picPopcorn = new System.Windows.Forms.PictureBox();
            this.lblStockProducto = new System.Windows.Forms.Label();
            this.nupStockProducto = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.nupPrecioProducto = new System.Windows.Forms.NumericUpDown();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtBoxNombreProducto = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.panPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).BeginInit();
            this.grpGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDuracion)).BeginInit();
            this.panProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPopcorn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStockProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecioProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // rdtPeliculas
            // 
            this.rdtPeliculas.AutoSize = true;
            this.rdtPeliculas.Checked = true;
            this.rdtPeliculas.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdtPeliculas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.rdtPeliculas.Location = new System.Drawing.Point(12, 26);
            this.rdtPeliculas.Name = "rdtPeliculas";
            this.rdtPeliculas.Size = new System.Drawing.Size(124, 29);
            this.rdtPeliculas.TabIndex = 0;
            this.rdtPeliculas.TabStop = true;
            this.rdtPeliculas.Text = "Peliculas";
            this.rdtPeliculas.UseVisualStyleBackColor = true;
            this.rdtPeliculas.CheckedChanged += new System.EventHandler(this.rdtPeliculas_CheckedChanged);
            // 
            // rdtProductos
            // 
            this.rdtProductos.AutoSize = true;
            this.rdtProductos.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdtProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.rdtProductos.Location = new System.Drawing.Point(268, 26);
            this.rdtProductos.Name = "rdtProductos";
            this.rdtProductos.Size = new System.Drawing.Size(138, 29);
            this.rdtProductos.TabIndex = 1;
            this.rdtProductos.Text = "Productos";
            this.rdtProductos.UseVisualStyleBackColor = true;
            // 
            // panPeliculas
            // 
            this.panPeliculas.Controls.Add(this.lblStock);
            this.panPeliculas.Controls.Add(this.nupStock);
            this.panPeliculas.Controls.Add(this.lblPrecioAlquiler);
            this.panPeliculas.Controls.Add(this.cmbPrecioAlquiler);
            this.panPeliculas.Controls.Add(this.lblDiasAlquiler);
            this.panPeliculas.Controls.Add(this.cmbDiasDeAlquiler);
            this.panPeliculas.Controls.Add(this.grpGenero);
            this.panPeliculas.Controls.Add(this.lblAclaracion);
            this.panPeliculas.Controls.Add(this.lblDuracion);
            this.panPeliculas.Controls.Add(this.nupDuracion);
            this.panPeliculas.Controls.Add(this.lblTitulo);
            this.panPeliculas.Controls.Add(this.txtBoxTituloPelicula);
            this.panPeliculas.Location = new System.Drawing.Point(12, 82);
            this.panPeliculas.Name = "panPeliculas";
            this.panPeliculas.Size = new System.Drawing.Size(389, 296);
            this.panPeliculas.TabIndex = 2;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblStock.Location = new System.Drawing.Point(22, 246);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(54, 21);
            this.lblStock.TabIndex = 11;
            this.lblStock.Text = "Stock: ";
            // 
            // nupStock
            // 
            this.nupStock.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nupStock.Location = new System.Drawing.Point(128, 246);
            this.nupStock.Name = "nupStock";
            this.nupStock.Size = new System.Drawing.Size(67, 23);
            this.nupStock.TabIndex = 10;
            // 
            // lblPrecioAlquiler
            // 
            this.lblPrecioAlquiler.AutoSize = true;
            this.lblPrecioAlquiler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioAlquiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblPrecioAlquiler.Location = new System.Drawing.Point(22, 185);
            this.lblPrecioAlquiler.Name = "lblPrecioAlquiler";
            this.lblPrecioAlquiler.Size = new System.Drawing.Size(161, 21);
            this.lblPrecioAlquiler.TabIndex = 9;
            this.lblPrecioAlquiler.Text = "Categoria de alquiler: ";
            // 
            // cmbPrecioAlquiler
            // 
            this.cmbPrecioAlquiler.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbPrecioAlquiler.FormattingEnabled = true;
            this.cmbPrecioAlquiler.Location = new System.Drawing.Point(22, 209);
            this.cmbPrecioAlquiler.Name = "cmbPrecioAlquiler";
            this.cmbPrecioAlquiler.Size = new System.Drawing.Size(173, 23);
            this.cmbPrecioAlquiler.TabIndex = 8;
            // 
            // lblDiasAlquiler
            // 
            this.lblDiasAlquiler.AutoSize = true;
            this.lblDiasAlquiler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiasAlquiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblDiasAlquiler.Location = new System.Drawing.Point(22, 117);
            this.lblDiasAlquiler.Name = "lblDiasAlquiler";
            this.lblDiasAlquiler.Size = new System.Drawing.Size(124, 21);
            this.lblDiasAlquiler.TabIndex = 7;
            this.lblDiasAlquiler.Text = "Dias de alquiler: ";
            // 
            // cmbDiasDeAlquiler
            // 
            this.cmbDiasDeAlquiler.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDiasDeAlquiler.FormattingEnabled = true;
            this.cmbDiasDeAlquiler.Location = new System.Drawing.Point(22, 141);
            this.cmbDiasDeAlquiler.Name = "cmbDiasDeAlquiler";
            this.cmbDiasDeAlquiler.Size = new System.Drawing.Size(173, 23);
            this.cmbDiasDeAlquiler.TabIndex = 6;
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
            this.grpGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.grpGenero.Location = new System.Drawing.Point(251, 70);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(113, 204);
            this.grpGenero.TabIndex = 5;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Genero";
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
            this.rdtTerror.CheckedChanged += new System.EventHandler(this.rdtAccion_CheckedChanged);
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
            this.rdtSuspenso.CheckedChanged += new System.EventHandler(this.rdtAccion_CheckedChanged);
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
            this.rdtAnimada.CheckedChanged += new System.EventHandler(this.rdtAccion_CheckedChanged);
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
            this.rdtDrama.CheckedChanged += new System.EventHandler(this.rdtAccion_CheckedChanged);
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
            this.rdtComedia.CheckedChanged += new System.EventHandler(this.rdtAccion_CheckedChanged);
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
            this.rdtCienciaFiccion.CheckedChanged += new System.EventHandler(this.rdtAccion_CheckedChanged);
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
            this.rdtAccion.CheckedChanged += new System.EventHandler(this.rdtAccion_CheckedChanged);
            // 
            // lblAclaracion
            // 
            this.lblAclaracion.AutoSize = true;
            this.lblAclaracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblAclaracion.Location = new System.Drawing.Point(22, 88);
            this.lblAclaracion.Name = "lblAclaracion";
            this.lblAclaracion.Size = new System.Drawing.Size(72, 15);
            this.lblAclaracion.TabIndex = 4;
            this.lblAclaracion.Text = "*en minutos";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblDuracion.Location = new System.Drawing.Point(22, 67);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(76, 21);
            this.lblDuracion.TabIndex = 3;
            this.lblDuracion.Text = "Duracion:";
            // 
            // nupDuracion
            // 
            this.nupDuracion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nupDuracion.Location = new System.Drawing.Point(128, 70);
            this.nupDuracion.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.nupDuracion.Name = "nupDuracion";
            this.nupDuracion.Size = new System.Drawing.Size(67, 23);
            this.nupDuracion.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(22, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(52, 21);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo:";
            // 
            // txtBoxTituloPelicula
            // 
            this.txtBoxTituloPelicula.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxTituloPelicula.Location = new System.Drawing.Point(22, 36);
            this.txtBoxTituloPelicula.Name = "txtBoxTituloPelicula";
            this.txtBoxTituloPelicula.Size = new System.Drawing.Size(342, 23);
            this.txtBoxTituloPelicula.TabIndex = 0;
            // 
            // panProductos
            // 
            this.panProductos.Controls.Add(this.picPopcorn);
            this.panProductos.Controls.Add(this.lblStockProducto);
            this.panProductos.Controls.Add(this.nupStockProducto);
            this.panProductos.Controls.Add(this.lblPrecioProducto);
            this.panProductos.Controls.Add(this.nupPrecioProducto);
            this.panProductos.Controls.Add(this.lblNombreProducto);
            this.panProductos.Controls.Add(this.txtBoxNombreProducto);
            this.panProductos.Location = new System.Drawing.Point(12, 82);
            this.panProductos.Name = "panProductos";
            this.panProductos.Size = new System.Drawing.Size(389, 296);
            this.panProductos.TabIndex = 12;
            this.panProductos.Visible = false;
            // 
            // picPopcorn
            // 
            this.picPopcorn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPopcorn.BackgroundImage")));
            this.picPopcorn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPopcorn.Location = new System.Drawing.Point(239, 88);
            this.picPopcorn.Name = "picPopcorn";
            this.picPopcorn.Size = new System.Drawing.Size(125, 141);
            this.picPopcorn.TabIndex = 12;
            this.picPopcorn.TabStop = false;
            // 
            // lblStockProducto
            // 
            this.lblStockProducto.AutoSize = true;
            this.lblStockProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStockProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblStockProducto.Location = new System.Drawing.Point(22, 127);
            this.lblStockProducto.Name = "lblStockProducto";
            this.lblStockProducto.Size = new System.Drawing.Size(54, 21);
            this.lblStockProducto.TabIndex = 11;
            this.lblStockProducto.Text = "Stock: ";
            // 
            // nupStockProducto
            // 
            this.nupStockProducto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nupStockProducto.Location = new System.Drawing.Point(128, 127);
            this.nupStockProducto.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nupStockProducto.Name = "nupStockProducto";
            this.nupStockProducto.Size = new System.Drawing.Size(67, 23);
            this.nupStockProducto.TabIndex = 10;
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblPrecioProducto.Location = new System.Drawing.Point(22, 67);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(60, 21);
            this.lblPrecioProducto.TabIndex = 3;
            this.lblPrecioProducto.Text = "Precio: ";
            // 
            // nupPrecioProducto
            // 
            this.nupPrecioProducto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nupPrecioProducto.DecimalPlaces = 2;
            this.nupPrecioProducto.Location = new System.Drawing.Point(128, 70);
            this.nupPrecioProducto.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.nupPrecioProducto.Name = "nupPrecioProducto";
            this.nupPrecioProducto.Size = new System.Drawing.Size(67, 23);
            this.nupPrecioProducto.TabIndex = 2;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblNombreProducto.Location = new System.Drawing.Point(22, 12);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(73, 21);
            this.lblNombreProducto.TabIndex = 1;
            this.lblNombreProducto.Text = "Producto";
            // 
            // txtBoxNombreProducto
            // 
            this.txtBoxNombreProducto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxNombreProducto.Location = new System.Drawing.Point(22, 36);
            this.txtBoxNombreProducto.Name = "txtBoxNombreProducto";
            this.txtBoxNombreProducto.Size = new System.Drawing.Size(342, 23);
            this.txtBoxNombreProducto.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnConfirmar.Location = new System.Drawing.Point(228, 393);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(173, 43);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 407);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(102, 15);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "Mensaje de error";
            this.lblError.Visible = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrar.BackgroundImage")));
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.Location = new System.Drawing.Point(165, 16);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnBorrar.Size = new System.Drawing.Size(65, 52);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Visible = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(418, 448);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.rdtProductos);
            this.Controls.Add(this.rdtPeliculas);
            this.Controls.Add(this.panProductos);
            this.Controls.Add(this.panPeliculas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarProducto";
            this.Text = "AgregarProducto";
            this.Load += new System.EventHandler(this.AgregarProducto_Load);
            this.panPeliculas.ResumeLayout(false);
            this.panPeliculas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).EndInit();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDuracion)).EndInit();
            this.panProductos.ResumeLayout(false);
            this.panProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPopcorn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStockProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecioProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdtPeliculas;
        private System.Windows.Forms.RadioButton rdtProductos;
        private System.Windows.Forms.Panel panPeliculas;
        private System.Windows.Forms.TextBox txtBoxTituloPelicula;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.NumericUpDown nupDuracion;
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
        private System.Windows.Forms.Panel panProductos;
        private System.Windows.Forms.Label lblStockProducto;
        private System.Windows.Forms.NumericUpDown nupStockProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.NumericUpDown nupPrecioProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtBoxNombreProducto;
        private System.Windows.Forms.PictureBox picPopcorn;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnBorrar;
    }
}