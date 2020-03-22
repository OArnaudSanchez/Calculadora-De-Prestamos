namespace CapaPresentacionn
{
    partial class BorrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrarUsuario));
            this.bBorrarUsuario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bBorrarUsuario
            // 
            this.bBorrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBorrarUsuario.FlatAppearance.BorderSize = 0;
            this.bBorrarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bBorrarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bBorrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBorrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrarUsuario.Location = new System.Drawing.Point(35, 68);
            this.bBorrarUsuario.Name = "bBorrarUsuario";
            this.bBorrarUsuario.Size = new System.Drawing.Size(88, 32);
            this.bBorrarUsuario.TabIndex = 1;
            this.bBorrarUsuario.Text = "Borrar";
            this.bBorrarUsuario.UseVisualStyleBackColor = true;
            this.bBorrarUsuario.Click += new System.EventHandler(this.bBorrarUsuario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "ID";
            // 
            // tID
            // 
            this.tID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tID.Location = new System.Drawing.Point(42, 24);
            this.tID.Multiline = true;
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(81, 25);
            this.tID.TabIndex = 0;
            this.tID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BorrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 121);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bBorrarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(194, 164);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(194, 164);
            this.Name = "BorrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button bBorrarUsuario;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tID;
    }
}