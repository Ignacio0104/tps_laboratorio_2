namespace Blockbuster_UI
{
    partial class ListaSocios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGridSocios = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimitePeliculas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPenalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarjetaCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridSocios
            // 
            this.dGridSocios.AllowUserToAddRows = false;
            this.dGridSocios.AllowUserToDeleteRows = false;
            this.dGridSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colApellido,
            this.colEmail,
            this.colTelefono,
            this.colLimitePeliculas,
            this.colPenalidad,
            this.colTarjetaCredito});
            this.dGridSocios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGridSocios.Location = new System.Drawing.Point(12, 75);
            this.dGridSocios.Name = "dGridSocios";
            this.dGridSocios.RowTemplate.Height = 25;
            this.dGridSocios.ShowEditingIcon = false;
            this.dGridSocios.Size = new System.Drawing.Size(872, 378);
            this.dGridSocios.TabIndex = 0;
            this.dGridSocios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridSocios_CellClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id Socio";
            this.colId.Name = "colId";
            this.colId.Width = 60;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 150;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "E-mail";
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 150;
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Telefono";
            this.colTelefono.Name = "colTelefono";
            // 
            // colLimitePeliculas
            // 
            this.colLimitePeliculas.HeaderText = "Limite";
            this.colLimitePeliculas.Name = "colLimitePeliculas";
            this.colLimitePeliculas.Width = 50;
            // 
            // colPenalidad
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colPenalidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPenalidad.HeaderText = "Penalidad";
            this.colPenalidad.Name = "colPenalidad";
            this.colPenalidad.Width = 70;
            // 
            // colTarjetaCredito
            // 
            this.colTarjetaCredito.HeaderText = "Tarjeta garantia";
            this.colTarjetaCredito.Name = "colTarjetaCredito";
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnAgregar.Location = new System.Drawing.Point(696, 476);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 46);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar +";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ListaSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(896, 534);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dGridSocios);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaSocios";
            this.Load += new System.EventHandler(this.ListaSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridSocios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridSocios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimitePeliculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPenalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarjetaCredito;
    }
}