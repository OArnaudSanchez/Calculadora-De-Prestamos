namespace CapaPresentacionn
{
    partial class ModificarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarUsuario));
            this.Usuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bModificar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rActivo = new System.Windows.Forms.RadioButton();
            this.rInactivo = new System.Windows.Forms.RadioButton();
            this.cAcceso = new System.Windows.Forms.ComboBox();
            this.tID = new System.Windows.Forms.TextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.tCorreo = new System.Windows.Forms.TextBox();
            this.tClave = new System.Windows.Forms.TextBox();
            this.bLImpiarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(22, 250);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(67, 18);
            this.Usuario.TabIndex = 38;
            this.Usuario.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre";
            // 
            // bModificar
            // 
            this.bModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bModificar.FlatAppearance.BorderSize = 0;
            this.bModificar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bModificar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Location = new System.Drawing.Point(112, 291);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(108, 32);
            this.bModificar.TabIndex = 8;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 47;
            this.label7.Text = "Acceso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 53;
            this.label4.Text = "Estado";
            // 
            // rActivo
            // 
            this.rActivo.AutoSize = true;
            this.rActivo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rActivo.Location = new System.Drawing.Point(112, 167);
            this.rActivo.Name = "rActivo";
            this.rActivo.Size = new System.Drawing.Size(70, 23);
            this.rActivo.TabIndex = 4;
            this.rActivo.TabStop = true;
            this.rActivo.Text = "Activo";
            this.rActivo.UseVisualStyleBackColor = true;
            // 
            // rInactivo
            // 
            this.rInactivo.AutoSize = true;
            this.rInactivo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rInactivo.Location = new System.Drawing.Point(209, 167);
            this.rInactivo.Name = "rInactivo";
            this.rInactivo.Size = new System.Drawing.Size(82, 23);
            this.rInactivo.TabIndex = 5;
            this.rInactivo.TabStop = true;
            this.rInactivo.Text = "Inactivo";
            this.rInactivo.UseVisualStyleBackColor = true;
            // 
            // cAcceso
            // 
            this.cAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAcceso.FormattingEnabled = true;
            this.cAcceso.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cAcceso.Location = new System.Drawing.Point(90, 204);
            this.cAcceso.Name = "cAcceso";
            this.cAcceso.Size = new System.Drawing.Size(130, 24);
            this.cAcceso.TabIndex = 6;
            this.cAcceso.Text = "Tipo de Acceso";
            // 
            // tID
            // 
            this.tID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tID.Location = new System.Drawing.Point(90, 14);
            this.tID.Multiline = true;
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(65, 25);
            this.tID.TabIndex = 0;
            this.tID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tNombre
            // 
            this.tNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombre.Location = new System.Drawing.Point(90, 47);
            this.tNombre.Multiline = true;
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(187, 25);
            this.tNombre.TabIndex = 1;
            // 
            // tUsuario
            // 
            this.tUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUsuario.Location = new System.Drawing.Point(90, 248);
            this.tUsuario.Multiline = true;
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(187, 25);
            this.tUsuario.TabIndex = 7;
            // 
            // tCorreo
            // 
            this.tCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCorreo.Location = new System.Drawing.Point(90, 90);
            this.tCorreo.Multiline = true;
            this.tCorreo.Name = "tCorreo";
            this.tCorreo.Size = new System.Drawing.Size(187, 25);
            this.tCorreo.TabIndex = 2;
            // 
            // tClave
            // 
            this.tClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tClave.Location = new System.Drawing.Point(90, 128);
            this.tClave.Multiline = true;
            this.tClave.Name = "tClave";
            this.tClave.Size = new System.Drawing.Size(187, 25);
            this.tClave.TabIndex = 3;
            // 
            // bLImpiarUsuario
            // 
            this.bLImpiarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLImpiarUsuario.FlatAppearance.BorderSize = 0;
            this.bLImpiarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bLImpiarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bLImpiarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLImpiarUsuario.Image = global::CapaPresentacionn.Properties.Resources.clean;
            this.bLImpiarUsuario.Location = new System.Drawing.Point(236, 287);
            this.bLImpiarUsuario.Name = "bLImpiarUsuario";
            this.bLImpiarUsuario.Size = new System.Drawing.Size(41, 43);
            this.bLImpiarUsuario.TabIndex = 54;
            this.bLImpiarUsuario.UseVisualStyleBackColor = true;
            this.bLImpiarUsuario.Click += new System.EventHandler(this.bLImpiarUsuario_Click);
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 335);
            this.Controls.Add(this.bLImpiarUsuario);
            this.Controls.Add(this.tClave);
            this.Controls.Add(this.tCorreo);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.cAcceso);
            this.Controls.Add(this.rInactivo);
            this.Controls.Add(this.rActivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(353, 378);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(353, 378);
            this.Name = "ModificarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label Usuario;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button bModificar;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rActivo;
        private System.Windows.Forms.RadioButton rInactivo;
        private System.Windows.Forms.ComboBox cAcceso;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.TextBox tCorreo;
        private System.Windows.Forms.TextBox tClave;
        private System.Windows.Forms.Button bLImpiarUsuario;
    }
}