﻿namespace Blockbuster_UI
{
    partial class Inventario
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
            this.dGridInventario = new System.Windows.Forms.DataGridView();
            this.cmbFiltroBusqueda = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridInventario
            // 
            this.dGridInventario.AllowUserToAddRows = false;
            this.dGridInventario.AllowUserToDeleteRows = false;
            this.dGridInventario.AllowUserToOrderColumns = true;
            this.dGridInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridInventario.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGridInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridInventario.Location = new System.Drawing.Point(31, 57);
            this.dGridInventario.MultiSelect = false;
            this.dGridInventario.Name = "dGridInventario";
            this.dGridInventario.ReadOnly = true;
            this.dGridInventario.RowTemplate.Height = 25;
            this.dGridInventario.Size = new System.Drawing.Size(825, 392);
            this.dGridInventario.TabIndex = 0;
            this.dGridInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridInventario_CellClick);
            this.dGridInventario.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridInventario_CellMouseLeave);
            this.dGridInventario.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGridInventario_CellMouseMove);
            // 
            // cmbFiltroBusqueda
            // 
            this.cmbFiltroBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.cmbFiltroBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.cmbFiltroBusqueda.FormattingEnabled = true;
            this.cmbFiltroBusqueda.Location = new System.Drawing.Point(31, 12);
            this.cmbFiltroBusqueda.Name = "cmbFiltroBusqueda";
            this.cmbFiltroBusqueda.Size = new System.Drawing.Size(260, 23);
            this.cmbFiltroBusqueda.TabIndex = 1;
            this.cmbFiltroBusqueda.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroBusqueda_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnAgregar.Location = new System.Drawing.Point(680, 464);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(176, 50);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar +";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(896, 534);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbFiltroBusqueda);
            this.Controls.Add(this.dGridInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dGridInventario;
        private System.Windows.Forms.ComboBox cmbFiltroBusqueda;
        private System.Windows.Forms.Button btnAgregar;
    }
}