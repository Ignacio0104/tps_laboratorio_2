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
            ((System.ComponentModel.ISupportInitialize)(this.dGridEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridEmpleados
            // 
            this.dGridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridEmpleados.Location = new System.Drawing.Point(45, 29);
            this.dGridEmpleados.Name = "dGridEmpleados";
            this.dGridEmpleados.RowTemplate.Height = 25;
            this.dGridEmpleados.Size = new System.Drawing.Size(691, 373);
            this.dGridEmpleados.TabIndex = 0;
            // 
            // ListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGridEmpleados);
            this.Name = "ListaEmpleados";
            this.Text = "ListaEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.dGridEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridEmpleados;
    }
}