namespace Presentacion
{
    partial class FormProveedor
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
            this.dgv_proveedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_proveedores
            // 
            this.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proveedores.Location = new System.Drawing.Point(115, 55);
            this.dgv_proveedores.Name = "dgv_proveedores";
            this.dgv_proveedores.RowTemplate.Height = 25;
            this.dgv_proveedores.Size = new System.Drawing.Size(496, 249);
            this.dgv_proveedores.TabIndex = 0;
            // 
            // FormProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_proveedores);
            this.Name = "FormProveedor";
            this.Text = "FormProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_proveedores;
    }
}