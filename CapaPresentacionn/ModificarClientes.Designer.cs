namespace CapaPresentacionn
{
    partial class ModificarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarClientes));
            this.tTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tCelular = new System.Windows.Forms.MaskedTextBox();
            this.tCedula = new System.Windows.Forms.MaskedTextBox();
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
            this.bModificar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bSeleccionCliente = new System.Windows.Forms.Button();
            this.tIDCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bLimpiarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tTelefono
            // 
            this.tTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTelefono.Location = new System.Drawing.Point(94, 242);
            this.tTelefono.Mask = "000-000-0000";
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(111, 22);
            this.tTelefono.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 18);
            this.label11.TabIndex = 69;
            this.label11.Text = "ID";
            // 
            // tCelular
            // 
            this.tCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCelular.Location = new System.Drawing.Point(94, 284);
            this.tCelular.Mask = "000-000-0000";
            this.tCelular.Name = "tCelular";
            this.tCelular.Size = new System.Drawing.Size(111, 22);
            this.tCelular.TabIndex = 5;
            // 
            // tCedula
            // 
            this.tCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCedula.Location = new System.Drawing.Point(94, 67);
            this.tCedula.Mask = "000-0000000-0";
            this.tCedula.Name = "tCedula";
            this.tCedula.Size = new System.Drawing.Size(118, 26);
            this.tCedula.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 200);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 18);
            this.label9.TabIndex = 62;
            this.label9.Text = "Nombre";
            // 
            // tNombre
            // 
            this.tNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombre.Location = new System.Drawing.Point(94, 105);
            this.tNombre.Multiline = true;
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(203, 25);
            this.tNombre.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 59;
            this.label7.Text = "Direccion";
            // 
            // tDireccion
            // 
            this.tDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDireccion.Location = new System.Drawing.Point(95, 320);
            this.tDireccion.Multiline = true;
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tDireccion.Size = new System.Drawing.Size(243, 54);
            this.tDireccion.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 58;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 57;
            this.label5.Text = "Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Fecha nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "Apellidos";
            // 
            // tApellidos
            // 
            this.tApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tApellidos.Location = new System.Drawing.Point(94, 150);
            this.tApellidos.Multiline = true;
            this.tApellidos.Name = "tApellidos";
            this.tApellidos.Size = new System.Drawing.Size(203, 25);
            this.tApellidos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Cedula";
            // 
            // bModificar
            // 
            this.bModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bModificar.FlatAppearance.BorderSize = 0;
            this.bModificar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bModificar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Location = new System.Drawing.Point(117, 391);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(115, 35);
            this.bModificar.TabIndex = 72;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bSeleccionCliente
            // 
            this.bSeleccionCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSeleccionCliente.FlatAppearance.BorderSize = 0;
            this.bSeleccionCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bSeleccionCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bSeleccionCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSeleccionCliente.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeleccionCliente.Image = global::CapaPresentacionn.Properties.Resources.buscar1;
            this.bSeleccionCliente.Location = new System.Drawing.Point(221, 8);
            this.bSeleccionCliente.Name = "bSeleccionCliente";
            this.bSeleccionCliente.Size = new System.Drawing.Size(41, 43);
            this.bSeleccionCliente.TabIndex = 73;
            this.bSeleccionCliente.UseVisualStyleBackColor = true;
            this.bSeleccionCliente.Click += new System.EventHandler(this.bSeleccionCliente_Click);
            // 
            // tIDCliente
            // 
            this.tIDCliente.Cursor = System.Windows.Forms.Cursors.No;
            this.tIDCliente.Location = new System.Drawing.Point(93, 19);
            this.tIDCliente.Multiline = true;
            this.tIDCliente.Name = "tIDCliente";
            this.tIDCliente.ReadOnly = true;
            this.tIDCliente.Size = new System.Drawing.Size(112, 25);
            this.tIDCliente.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 82;
            this.label2.Text = "Buscar Cliente";
            // 
            // bLimpiarCliente
            // 
            this.bLimpiarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLimpiarCliente.FlatAppearance.BorderSize = 0;
            this.bLimpiarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bLimpiarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bLimpiarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLimpiarCliente.Image = global::CapaPresentacionn.Properties.Resources.clean;
            this.bLimpiarCliente.Location = new System.Drawing.Point(240, 383);
            this.bLimpiarCliente.Name = "bLimpiarCliente";
            this.bLimpiarCliente.Size = new System.Drawing.Size(41, 43);
            this.bLimpiarCliente.TabIndex = 83;
            this.bLimpiarCliente.UseVisualStyleBackColor = true;
            this.bLimpiarCliente.Click += new System.EventHandler(this.bLimpiarCliente_Click);
            // 
            // ModificarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 430);
            this.Controls.Add(this.bLimpiarCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tIDCliente);
            this.Controls.Add(this.bSeleccionCliente);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.tTelefono);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tCelular);
            this.Controls.Add(this.tCedula);
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
            this.MaximumSize = new System.Drawing.Size(378, 473);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(378, 473);
            this.Name = "ModificarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tTelefono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox tCelular;
        private System.Windows.Forms.MaskedTextBox tCedula;
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
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button bSeleccionCliente;
        private System.Windows.Forms.TextBox tIDCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bLimpiarCliente;
    }
}