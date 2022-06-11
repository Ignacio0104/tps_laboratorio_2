namespace Blockbuster_UI
{
    partial class AgregarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEmpleado));
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.chkEsAdmin = new System.Windows.Forms.CheckBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSignoPesos = new System.Windows.Forms.Label();
            this.dateFechaNacimiento = new System.Windows.Forms.MonthCalendar();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.picMostrar = new System.Windows.Forms.PictureBox();
            this.picOcultar = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(40, 69);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(188, 23);
            this.txtNombreEmpleado.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.Location = new System.Drawing.Point(322, 325);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(141, 39);
            this.btnConfirmar.TabIndex = 23;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(40, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblApellido.Location = new System.Drawing.Point(40, 95);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(40, 113);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(188, 23);
            this.txtApellidoEmpleado.TabIndex = 3;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblDni.Location = new System.Drawing.Point(40, 139);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(30, 15);
            this.lblDni.TabIndex = 6;
            this.lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(40, 157);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(188, 23);
            this.txtDni.TabIndex = 5;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(40, 183);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(66, 15);
            this.lblNombreUsuario.TabIndex = 8;
            this.lblNombreUsuario.Text = "Username: ";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(40, 201);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(188, 23);
            this.txtUsername.TabIndex = 7;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblClave.Location = new System.Drawing.Point(40, 227);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(39, 15);
            this.lblClave.TabIndex = 10;
            this.lblClave.Text = "Clave:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(40, 245);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(188, 23);
            this.txtClave.TabIndex = 9;
            // 
            // chkEsAdmin
            // 
            this.chkEsAdmin.AutoSize = true;
            this.chkEsAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.chkEsAdmin.Location = new System.Drawing.Point(40, 335);
            this.chkEsAdmin.Name = "chkEsAdmin";
            this.chkEsAdmin.Size = new System.Drawing.Size(102, 19);
            this.chkEsAdmin.TabIndex = 11;
            this.chkEsAdmin.Text = "Administrador";
            this.chkEsAdmin.UseVisualStyleBackColor = true;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblSalario.Location = new System.Drawing.Point(91, 271);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(45, 15);
            this.lblSalario.TabIndex = 15;
            this.lblSalario.Text = "Salario:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(91, 289);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(137, 23);
            this.txtSalario.TabIndex = 14;
            // 
            // lblSignoPesos
            // 
            this.lblSignoPesos.AutoSize = true;
            this.lblSignoPesos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblSignoPesos.Location = new System.Drawing.Point(57, 292);
            this.lblSignoPesos.Name = "lblSignoPesos";
            this.lblSignoPesos.Size = new System.Drawing.Size(13, 15);
            this.lblSignoPesos.TabIndex = 16;
            this.lblSignoPesos.Text = "$";
            // 
            // dateFechaNacimiento
            // 
            this.dateFechaNacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.dateFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.dateFechaNacimiento.Location = new System.Drawing.Point(272, 75);
            this.dateFechaNacimiento.Name = "dateFechaNacimiento";
            this.dateFechaNacimiento.TabIndex = 18;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(272, 51);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(104, 15);
            this.lblFechaNacimiento.TabIndex = 19;
            this.lblFechaNacimiento.Text = "Fecha nacimiento:";
            // 
            // picMostrar
            // 
            this.picMostrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMostrar.BackgroundImage")));
            this.picMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picMostrar.Location = new System.Drawing.Point(234, 245);
            this.picMostrar.Name = "picMostrar";
            this.picMostrar.Size = new System.Drawing.Size(36, 27);
            this.picMostrar.TabIndex = 20;
            this.picMostrar.TabStop = false;
            this.picMostrar.Click += new System.EventHandler(this.picMostrar_Click);
            // 
            // picOcultar
            // 
            this.picOcultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picOcultar.BackgroundImage")));
            this.picOcultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picOcultar.Location = new System.Drawing.Point(234, 245);
            this.picOcultar.Name = "picOcultar";
            this.picOcultar.Size = new System.Drawing.Size(36, 27);
            this.picOcultar.TabIndex = 21;
            this.picOcultar.TabStop = false;
            this.picOcultar.Visible = false;
            this.picOcultar.Click += new System.EventHandler(this.picOcultar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(387, 245);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 53);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 351);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 24;
            this.lblError.Visible = false;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLegajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblLegajo.Location = new System.Drawing.Point(36, 9);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(61, 20);
            this.lblLegajo.TabIndex = 25;
            this.lblLegajo.Text = "Legajo: ";
            // 
            // AgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(505, 382);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.dateFechaNacimiento);
            this.Controls.Add(this.lblSignoPesos);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.chkEsAdmin);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellidoEmpleado);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.picMostrar);
            this.Controls.Add(this.picOcultar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarEmpleado";
            this.Text = "Agregar empleado";
            this.Load += new System.EventHandler(this.AgregarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.CheckBox chkEsAdmin;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSignoPesos;
        private System.Windows.Forms.MonthCalendar dateFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.PictureBox picMostrar;
        private System.Windows.Forms.PictureBox picOcultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblLegajo;
    }
}