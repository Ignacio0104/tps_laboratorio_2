namespace Blockbuster_UI
{
    partial class ListaEmpleados
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
            this.dGridEmpleados = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.colLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGridEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridEmpleados
            // 
            this.dGridEmpleados.AllowUserToAddRows = false;
            this.dGridEmpleados.AllowUserToDeleteRows = false;
            this.dGridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLegajo,
            this.colNombre,
            this.colApellido,
            this.colDni,
            this.colUsuario,
            this.colSalario,
            this.colIngreso,
            this.colNacimiento});
            this.dGridEmpleados.Location = new System.Drawing.Point(30, 28);
            this.dGridEmpleados.Name = "dGridEmpleados";
            this.dGridEmpleados.RowTemplate.Height = 25;
            this.dGridEmpleados.Size = new System.Drawing.Size(831, 417);
            this.dGridEmpleados.TabIndex = 0;
            this.dGridEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridEmpleados_CellClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnAgregar.Location = new System.Drawing.Point(668, 462);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(176, 50);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar +";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // colLegajo
            // 
            this.colLegajo.HeaderText = "Legajo";
            this.colLegajo.Name = "colLegajo";
            this.colLegajo.Width = 70;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            // 
            // colDni
            // 
            this.colDni.HeaderText = "DNI";
            this.colDni.Name = "colDni";
            // 
            // colUsuario
            // 
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            // 
            // colSalario
            // 
            this.colSalario.HeaderText = "Salario";
            this.colSalario.Name = "colSalario";
            // 
            // colIngreso
            // 
            this.colIngreso.HeaderText = "Ingreso";
            this.colIngreso.Name = "colIngreso";
            // 
            // colNacimiento
            // 
            this.colNacimiento.HeaderText = "Fecha de nacimiento";
            this.colNacimiento.Name = "colNacimiento";
            // 
            // ListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(896, 534);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dGridEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dGridEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridEmpleados;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLegajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNacimiento;
    }
}