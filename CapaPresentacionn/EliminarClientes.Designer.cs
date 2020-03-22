namespace CapaPresentacionn
{
    partial class EliminarClientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarClientes));
            this.tID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bBorrarUsuario = new System.Windows.Forms.Button();
            this.bSeleccionCliente = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tID
            // 
            this.tID.Cursor = System.Windows.Forms.Cursors.No;
            this.tID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tID.Location = new System.Drawing.Point(50, 21);
            this.tID.Multiline = true;
            this.tID.Name = "tID";
            this.tID.ReadOnly = true;
            this.tID.Size = new System.Drawing.Size(84, 25);
            this.tID.TabIndex = 62;
            this.tID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "ID";
            // 
            // bBorrarUsuario
            // 
            this.bBorrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBorrarUsuario.FlatAppearance.BorderSize = 0;
            this.bBorrarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bBorrarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bBorrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBorrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrarUsuario.Location = new System.Drawing.Point(38, 66);
            this.bBorrarUsuario.Name = "bBorrarUsuario";
            this.bBorrarUsuario.Size = new System.Drawing.Size(107, 32);
            this.bBorrarUsuario.TabIndex = 1;
            this.bBorrarUsuario.Text = "Eliminar";
            this.bBorrarUsuario.UseVisualStyleBackColor = true;
            this.bBorrarUsuario.Click += new System.EventHandler(this.bBorrarUsuario_Click);
            // 
            // bSeleccionCliente
            // 
            this.bSeleccionCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSeleccionCliente.FlatAppearance.BorderSize = 0;
            this.bSeleccionCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bSeleccionCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bSeleccionCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSeleccionCliente.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeleccionCliente.Image = global::CapaPresentacionn.Properties.Resources.buscar1;
            this.bSeleccionCliente.Location = new System.Drawing.Point(156, 12);
            this.bSeleccionCliente.Name = "bSeleccionCliente";
            this.bSeleccionCliente.Size = new System.Drawing.Size(41, 43);
            this.bSeleccionCliente.TabIndex = 0;
            this.bSeleccionCliente.UseVisualStyleBackColor = true;
            this.bSeleccionCliente.Click += new System.EventHandler(this.bSeleccionCliente_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EliminarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 110);
            this.Controls.Add(this.bSeleccionCliente);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bBorrarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(229, 153);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(229, 153);
            this.Name = "EliminarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tID;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button bBorrarUsuario;
        private System.Windows.Forms.Button bSeleccionCliente;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}