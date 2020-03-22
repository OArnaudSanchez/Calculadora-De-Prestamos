namespace CapaPresentacionn
{
    partial class AnularPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnularPrestamo));
            this.tBusqueda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bAnularPrestamo = new System.Windows.Forms.Button();
            this.bBuscarPrestamo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBusqueda
            // 
            this.tBusqueda.Cursor = System.Windows.Forms.Cursors.No;
            this.tBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBusqueda.Location = new System.Drawing.Point(44, 23);
            this.tBusqueda.Multiline = true;
            this.tBusqueda.Name = "tBusqueda";
            this.tBusqueda.ReadOnly = true;
            this.tBusqueda.Size = new System.Drawing.Size(78, 25);
            this.tBusqueda.TabIndex = 0;
            this.tBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "ID";
            // 
            // bAnularPrestamo
            // 
            this.bAnularPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAnularPrestamo.FlatAppearance.BorderSize = 0;
            this.bAnularPrestamo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bAnularPrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bAnularPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAnularPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnularPrestamo.Location = new System.Drawing.Point(34, 63);
            this.bAnularPrestamo.Name = "bAnularPrestamo";
            this.bAnularPrestamo.Size = new System.Drawing.Size(88, 32);
            this.bAnularPrestamo.TabIndex = 2;
            this.bAnularPrestamo.Text = "Anular";
            this.bAnularPrestamo.UseVisualStyleBackColor = true;
            this.bAnularPrestamo.Click += new System.EventHandler(this.bAnularPrestamo_Click);
            // 
            // bBuscarPrestamo
            // 
            this.bBuscarPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBuscarPrestamo.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarPrestamo.Image = global::CapaPresentacionn.Properties.Resources.buscar1;
            this.bBuscarPrestamo.Location = new System.Drawing.Point(149, 14);
            this.bBuscarPrestamo.Name = "bBuscarPrestamo";
            this.bBuscarPrestamo.Size = new System.Drawing.Size(41, 43);
            this.bBuscarPrestamo.TabIndex = 1;
            this.bBuscarPrestamo.UseVisualStyleBackColor = true;
            this.bBuscarPrestamo.Click += new System.EventHandler(this.bBuscarPrestamo_Click);
            // 
            // AnularPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 105);
            this.Controls.Add(this.bBuscarPrestamo);
            this.Controls.Add(this.tBusqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bAnularPrestamo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(239, 148);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(239, 148);
            this.Name = "AnularPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anular Prestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBusqueda;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button bAnularPrestamo;
        private System.Windows.Forms.Button bBuscarPrestamo;
    }
}