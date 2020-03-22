namespace CapaPresentacionn
{
    partial class CrearPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearPrestamo));
            this.label15 = new System.Windows.Forms.Label();
            this.tUsuario = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cEstaddo = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bGuardar = new System.Windows.Forms.Button();
            this.dateTimePrestamo = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tMonto = new System.Windows.Forms.TextBox();
            this.tInteres = new System.Windows.Forms.TextBox();
            this.tTiempo = new System.Windows.Forms.TextBox();
            this.tCedula = new System.Windows.Forms.TextBox();
            this.tNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bBuscarCliente = new System.Windows.Forms.Button();
            this.bLimpiarPrestamo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 70;
            this.label15.Text = "Monto";
            // 
            // tUsuario
            // 
            this.tUsuario.Cursor = System.Windows.Forms.Cursors.No;
            this.tUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUsuario.Location = new System.Drawing.Point(308, 3);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.ReadOnly = true;
            this.tUsuario.Size = new System.Drawing.Size(93, 22);
            this.tUsuario.TabIndex = 66;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(263, 236);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 20);
            this.label14.TabIndex = 65;
            this.label14.Text = "Estado";
            // 
            // cEstaddo
            // 
            this.cEstaddo.AutoSize = true;
            this.cEstaddo.Checked = true;
            this.cEstaddo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cEstaddo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cEstaddo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEstaddo.Location = new System.Drawing.Point(330, 236);
            this.cEstaddo.Name = "cEstaddo";
            this.cEstaddo.Size = new System.Drawing.Size(71, 23);
            this.cEstaddo.TabIndex = 64;
            this.cEstaddo.Text = "Activo";
            this.cEstaddo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(236, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 16);
            this.label13.TabIndex = 63;
            this.label13.Text = "Usuario:";
            // 
            // bGuardar
            // 
            this.bGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGuardar.FlatAppearance.BorderSize = 0;
            this.bGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuardar.Location = new System.Drawing.Point(121, 273);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(115, 35);
            this.bGuardar.TabIndex = 5;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // dateTimePrestamo
            // 
            this.dateTimePrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePrestamo.Location = new System.Drawing.Point(157, 233);
            this.dateTimePrestamo.MaximumSize = new System.Drawing.Size(500, 500);
            this.dateTimePrestamo.Name = "dateTimePrestamo";
            this.dateTimePrestamo.Size = new System.Drawing.Size(100, 26);
            this.dateTimePrestamo.TabIndex = 3;
            this.dateTimePrestamo.Value = new System.DateTime(2020, 3, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 54;
            this.label9.Text = "Cedula";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "Tiempo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Interes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Fecha Prestamo";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tMonto
            // 
            this.tMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMonto.Location = new System.Drawing.Point(84, 103);
            this.tMonto.Multiline = true;
            this.tMonto.Name = "tMonto";
            this.tMonto.Size = new System.Drawing.Size(132, 25);
            this.tMonto.TabIndex = 0;
            // 
            // tInteres
            // 
            this.tInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tInteres.Location = new System.Drawing.Point(84, 148);
            this.tInteres.Multiline = true;
            this.tInteres.Name = "tInteres";
            this.tInteres.Size = new System.Drawing.Size(132, 25);
            this.tInteres.TabIndex = 1;
            // 
            // tTiempo
            // 
            this.tTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTiempo.Location = new System.Drawing.Point(84, 188);
            this.tTiempo.Multiline = true;
            this.tTiempo.Name = "tTiempo";
            this.tTiempo.Size = new System.Drawing.Size(132, 25);
            this.tTiempo.TabIndex = 2;
            // 
            // tCedula
            // 
            this.tCedula.Cursor = System.Windows.Forms.Cursors.No;
            this.tCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCedula.Location = new System.Drawing.Point(84, 64);
            this.tCedula.Multiline = true;
            this.tCedula.Name = "tCedula";
            this.tCedula.ReadOnly = true;
            this.tCedula.Size = new System.Drawing.Size(132, 25);
            this.tCedula.TabIndex = 78;
            this.tCedula.TextChanged += new System.EventHandler(this.tCedula_TextChanged);
            // 
            // tNombreCliente
            // 
            this.tNombreCliente.Cursor = System.Windows.Forms.Cursors.No;
            this.tNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombreCliente.Location = new System.Drawing.Point(84, 22);
            this.tNombreCliente.Multiline = true;
            this.tNombreCliente.Name = "tNombreCliente";
            this.tNombreCliente.ReadOnly = true;
            this.tNombreCliente.Size = new System.Drawing.Size(132, 25);
            this.tNombreCliente.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 79;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 81;
            this.label2.Text = "Buscar Cliente";
            // 
            // bBuscarCliente
            // 
            this.bBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBuscarCliente.FlatAppearance.BorderSize = 0;
            this.bBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBuscarCliente.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarCliente.Image = global::CapaPresentacionn.Properties.Resources.buscar1;
            this.bBuscarCliente.Location = new System.Drawing.Point(225, 27);
            this.bBuscarCliente.Name = "bBuscarCliente";
            this.bBuscarCliente.Size = new System.Drawing.Size(41, 43);
            this.bBuscarCliente.TabIndex = 4;
            this.bBuscarCliente.UseVisualStyleBackColor = true;
            this.bBuscarCliente.Click += new System.EventHandler(this.bBuscarCliente_Click);
            // 
            // bLimpiarPrestamo
            // 
            this.bLimpiarPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLimpiarPrestamo.FlatAppearance.BorderSize = 0;
            this.bLimpiarPrestamo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bLimpiarPrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bLimpiarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLimpiarPrestamo.Image = global::CapaPresentacionn.Properties.Resources.clean;
            this.bLimpiarPrestamo.Location = new System.Drawing.Point(267, 270);
            this.bLimpiarPrestamo.Name = "bLimpiarPrestamo";
            this.bLimpiarPrestamo.Size = new System.Drawing.Size(41, 43);
            this.bLimpiarPrestamo.TabIndex = 82;
            this.bLimpiarPrestamo.UseVisualStyleBackColor = true;
            this.bLimpiarPrestamo.Click += new System.EventHandler(this.bLimpiarPrestamo_Click);
            // 
            // CrearPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 318);
            this.Controls.Add(this.bLimpiarPrestamo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tNombreCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tCedula);
            this.Controls.Add(this.tTiempo);
            this.Controls.Add(this.tInteres);
            this.Controls.Add(this.tMonto);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.bBuscarCliente);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cEstaddo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.dateTimePrestamo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(424, 361);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(424, 361);
            this.Name = "CrearPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Prestamo";
            this.Load += new System.EventHandler(this.CrearPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button bBuscarCliente;
        private System.Windows.Forms.MaskedTextBox tUsuario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cEstaddo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.DateTimePicker dateTimePrestamo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tTiempo;
        private System.Windows.Forms.TextBox tInteres;
        private System.Windows.Forms.TextBox tMonto;
        private System.Windows.Forms.TextBox tCedula;
        private System.Windows.Forms.TextBox tNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bLimpiarPrestamo;
    }
}