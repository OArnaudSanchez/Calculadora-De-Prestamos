namespace CapaPresentacionn
{
    partial class CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearUsuario));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.cAcceso = new System.Windows.Forms.ComboBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tCorreo = new System.Windows.Forms.TextBox();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.tClave = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bLImpiarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // bGuardar
            // 
            this.bGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGuardar.FlatAppearance.BorderSize = 0;
            this.bGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuardar.Location = new System.Drawing.Point(118, 236);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(103, 33);
            this.bGuardar.TabIndex = 5;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Acceso";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(16, 105);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(67, 18);
            this.Usuario.TabIndex = 25;
            this.Usuario.Text = "Usuario";
            // 
            // cAcceso
            // 
            this.cAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAcceso.FormattingEnabled = true;
            this.cAcceso.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cAcceso.Location = new System.Drawing.Point(89, 192);
            this.cAcceso.Name = "cAcceso";
            this.cAcceso.Size = new System.Drawing.Size(187, 24);
            this.cAcceso.TabIndex = 4;
            this.cAcceso.Text = "Tipo de Acceso";
            // 
            // tNombre
            // 
            this.tNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombre.Location = new System.Drawing.Point(89, 19);
            this.tNombre.Multiline = true;
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(187, 25);
            this.tNombre.TabIndex = 0;
            // 
            // tCorreo
            // 
            this.tCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCorreo.Location = new System.Drawing.Point(89, 61);
            this.tCorreo.Multiline = true;
            this.tCorreo.Name = "tCorreo";
            this.tCorreo.Size = new System.Drawing.Size(187, 25);
            this.tCorreo.TabIndex = 1;
            // 
            // tUsuario
            // 
            this.tUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUsuario.Location = new System.Drawing.Point(89, 104);
            this.tUsuario.Multiline = true;
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(187, 25);
            this.tUsuario.TabIndex = 2;
            // 
            // tClave
            // 
            this.tClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tClave.Location = new System.Drawing.Point(89, 148);
            this.tClave.Multiline = true;
            this.tClave.Name = "tClave";
            this.tClave.Size = new System.Drawing.Size(187, 25);
            this.tClave.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bLImpiarUsuario
            // 
            this.bLImpiarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLImpiarUsuario.FlatAppearance.BorderSize = 0;
            this.bLImpiarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bLImpiarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bLImpiarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLImpiarUsuario.Image = global::CapaPresentacionn.Properties.Resources.clean;
            this.bLImpiarUsuario.Location = new System.Drawing.Point(235, 232);
            this.bLImpiarUsuario.Name = "bLImpiarUsuario";
            this.bLImpiarUsuario.Size = new System.Drawing.Size(41, 43);
            this.bLImpiarUsuario.TabIndex = 26;
            this.bLImpiarUsuario.UseVisualStyleBackColor = true;
            this.bLImpiarUsuario.Click += new System.EventHandler(this.bLImpiarUsuario_Click);
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 281);
            this.Controls.Add(this.bLImpiarUsuario);
            this.Controls.Add(this.tClave);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.tCorreo);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.cAcceso);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(348, 324);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(348, 324);
            this.Name = "CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button bGuardar;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.ComboBox cAcceso;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tCorreo;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.TextBox tClave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button bLImpiarUsuario;
    }
}