namespace CapaPresentacionn
{
    partial class AgregarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarClientes));
            this.tTelefono = new System.Windows.Forms.MaskedTextBox();
            this.tCelular = new System.Windows.Forms.MaskedTextBox();
            this.tCedula = new System.Windows.Forms.MaskedTextBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bLimpiarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tTelefono
            // 
            this.tTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTelefono.Location = new System.Drawing.Point(94, 211);
            this.tTelefono.Mask = "000-000-0000";
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(104, 26);
            this.tTelefono.TabIndex = 5;
            this.tTelefono.TextChanged += new System.EventHandler(this.tTelefono_TextChanged);
            // 
            // tCelular
            // 
            this.tCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCelular.Location = new System.Drawing.Point(94, 132);
            this.tCelular.Mask = "000-000-0000";
            this.tCelular.Name = "tCelular";
            this.tCelular.Size = new System.Drawing.Size(107, 26);
            this.tCelular.TabIndex = 3;
            this.tCelular.TextChanged += new System.EventHandler(this.tCelular_TextChanged);
            // 
            // tCedula
            // 
            this.tCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCedula.Location = new System.Drawing.Point(94, 15);
            this.tCedula.Mask = "000-0000000-0";
            this.tCedula.Name = "tCedula";
            this.tCedula.Size = new System.Drawing.Size(118, 26);
            this.tCedula.TabIndex = 0;
            this.tCedula.TextChanged += new System.EventHandler(this.tCedula_TextChanged);
            // 
            // bGuardar
            // 
            this.bGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGuardar.FlatAppearance.BorderSize = 0;
            this.bGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGuardar.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuardar.Location = new System.Drawing.Point(98, 326);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(103, 33);
            this.bGuardar.TabIndex = 7;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 18);
            this.label9.TabIndex = 42;
            this.label9.Text = "Nombre";
            // 
            // tNombre
            // 
            this.tNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombre.Location = new System.Drawing.Point(94, 53);
            this.tNombre.Multiline = true;
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(203, 25);
            this.tNombre.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "Direccion";
            // 
            // tDireccion
            // 
            this.tDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDireccion.Location = new System.Drawing.Point(94, 250);
            this.tDireccion.Multiline = true;
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tDireccion.Size = new System.Drawing.Size(202, 54);
            this.tDireccion.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 38;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Apellidos";
            // 
            // tApellidos
            // 
            this.tApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tApellidos.Location = new System.Drawing.Point(94, 92);
            this.tApellidos.Multiline = true;
            this.tApellidos.Name = "tApellidos";
            this.tApellidos.Size = new System.Drawing.Size(203, 25);
            this.tApellidos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Cedula";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bLimpiarCliente
            // 
            this.bLimpiarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLimpiarCliente.FlatAppearance.BorderSize = 0;
            this.bLimpiarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bLimpiarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bLimpiarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLimpiarCliente.Image = global::CapaPresentacionn.Properties.Resources.clean;
            this.bLimpiarCliente.Location = new System.Drawing.Point(225, 316);
            this.bLimpiarCliente.Name = "bLimpiarCliente";
            this.bLimpiarCliente.Size = new System.Drawing.Size(41, 43);
            this.bLimpiarCliente.TabIndex = 55;
            this.bLimpiarCliente.UseVisualStyleBackColor = true;
            this.bLimpiarCliente.Click += new System.EventHandler(this.bLimpiarCliente_Click);
            // 
            // AgregarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 371);
            this.Controls.Add(this.bLimpiarCliente);
            this.Controls.Add(this.tTelefono);
            this.Controls.Add(this.tCelular);
            this.Controls.Add(this.tCedula);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tDireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tApellidos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(332, 414);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(332, 414);
            this.Name = "AgregarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tTelefono;
        private System.Windows.Forms.MaskedTextBox tCelular;
        private System.Windows.Forms.MaskedTextBox tCedula;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button bLimpiarCliente;
    }
}