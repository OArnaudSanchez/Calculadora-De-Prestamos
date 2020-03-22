namespace CapaPresentacionn
{
    partial class ModificarPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarPrestamo));
            this.bBuscarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bModificar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tTiempo = new System.Windows.Forms.TextBox();
            this.tInteres = new System.Windows.Forms.TextBox();
            this.tMonto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tUsuario = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cEstaddo = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePrestamo = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bBuscarPrestamo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bLimpiarPrestamo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bBuscarCliente
            // 
            this.bBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBuscarCliente.Location = new System.Drawing.Point(481, 42);
            this.bBuscarCliente.Name = "bBuscarCliente";
            this.bBuscarCliente.Size = new System.Drawing.Size(93, 35);
            this.bBuscarCliente.TabIndex = 90;
            this.bBuscarCliente.Text = "Buscar Cliente";
            this.bBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Años";
            // 
            // bModificar
            // 
            this.bModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bModificar.FlatAppearance.BorderSize = 0;
            this.bModificar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bModificar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Location = new System.Drawing.Point(144, 257);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(115, 35);
            this.bModificar.TabIndex = 5;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tNombre
            // 
            this.tNombre.Cursor = System.Windows.Forms.Cursors.No;
            this.tNombre.Location = new System.Drawing.Point(86, 50);
            this.tNombre.Multiline = true;
            this.tNombre.Name = "tNombre";
            this.tNombre.ReadOnly = true;
            this.tNombre.Size = new System.Drawing.Size(132, 25);
            this.tNombre.TabIndex = 112;
            // 
            // tTiempo
            // 
            this.tTiempo.Location = new System.Drawing.Point(86, 176);
            this.tTiempo.Multiline = true;
            this.tTiempo.Name = "tTiempo";
            this.tTiempo.Size = new System.Drawing.Size(132, 25);
            this.tTiempo.TabIndex = 2;
            // 
            // tInteres
            // 
            this.tInteres.Location = new System.Drawing.Point(86, 136);
            this.tInteres.Multiline = true;
            this.tInteres.Name = "tInteres";
            this.tInteres.Size = new System.Drawing.Size(132, 25);
            this.tInteres.TabIndex = 1;
            // 
            // tMonto
            // 
            this.tMonto.Location = new System.Drawing.Point(86, 89);
            this.tMonto.Multiline = true;
            this.tMonto.Name = "tMonto";
            this.tMonto.Size = new System.Drawing.Size(132, 25);
            this.tMonto.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 105;
            this.label15.Text = "Monto";
            // 
            // tUsuario
            // 
            this.tUsuario.Cursor = System.Windows.Forms.Cursors.No;
            this.tUsuario.Location = new System.Drawing.Point(322, 5);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.ReadOnly = true;
            this.tUsuario.Size = new System.Drawing.Size(93, 20);
            this.tUsuario.TabIndex = 103;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(276, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 20);
            this.label14.TabIndex = 102;
            this.label14.Text = "Estado";
            // 
            // cEstaddo
            // 
            this.cEstaddo.AutoSize = true;
            this.cEstaddo.Checked = true;
            this.cEstaddo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cEstaddo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cEstaddo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEstaddo.Location = new System.Drawing.Point(348, 224);
            this.cEstaddo.Name = "cEstaddo";
            this.cEstaddo.Size = new System.Drawing.Size(71, 23);
            this.cEstaddo.TabIndex = 101;
            this.cEstaddo.Text = "Activo";
            this.cEstaddo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(250, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 16);
            this.label13.TabIndex = 100;
            this.label13.Text = "Usuario:";
            // 
            // dateTimePrestamo
            // 
            this.dateTimePrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePrestamo.Location = new System.Drawing.Point(159, 225);
            this.dateTimePrestamo.MaximumSize = new System.Drawing.Size(500, 500);
            this.dateTimePrestamo.Name = "dateTimePrestamo";
            this.dateTimePrestamo.Size = new System.Drawing.Size(100, 20);
            this.dateTimePrestamo.TabIndex = 3;
            this.dateTimePrestamo.Value = new System.DateTime(2020, 3, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 98;
            this.label9.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 97;
            this.label7.Text = "Tiempo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 96;
            this.label6.Text = "Interes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 95;
            this.label4.Text = "Fecha Prestamo";
            // 
            // tId
            // 
            this.tId.Cursor = System.Windows.Forms.Cursors.No;
            this.tId.Location = new System.Drawing.Point(130, 11);
            this.tId.Multiline = true;
            this.tId.Name = "tId";
            this.tId.ReadOnly = true;
            this.tId.Size = new System.Drawing.Size(73, 25);
            this.tId.TabIndex = 114;
            this.tId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 113;
            this.label1.Text = "ID Prestamo";
            // 
            // bBuscarPrestamo
            // 
            this.bBuscarPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBuscarPrestamo.FlatAppearance.BorderSize = 0;
            this.bBuscarPrestamo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bBuscarPrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bBuscarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBuscarPrestamo.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarPrestamo.Image = global::CapaPresentacionn.Properties.Resources.buscar1;
            this.bBuscarPrestamo.Location = new System.Drawing.Point(236, 36);
            this.bBuscarPrestamo.Name = "bBuscarPrestamo";
            this.bBuscarPrestamo.Size = new System.Drawing.Size(41, 43);
            this.bBuscarPrestamo.TabIndex = 4;
            this.bBuscarPrestamo.UseVisualStyleBackColor = true;
            this.bBuscarPrestamo.Click += new System.EventHandler(this.bBuscarPrestamo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 116;
            this.label2.Text = "Buscar Cliente";
            // 
            // bLimpiarPrestamo
            // 
            this.bLimpiarPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLimpiarPrestamo.FlatAppearance.BorderSize = 0;
            this.bLimpiarPrestamo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bLimpiarPrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bLimpiarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLimpiarPrestamo.Image = global::CapaPresentacionn.Properties.Resources.clean;
            this.bLimpiarPrestamo.Location = new System.Drawing.Point(280, 254);
            this.bLimpiarPrestamo.Name = "bLimpiarPrestamo";
            this.bLimpiarPrestamo.Size = new System.Drawing.Size(41, 43);
            this.bLimpiarPrestamo.TabIndex = 117;
            this.bLimpiarPrestamo.UseVisualStyleBackColor = true;
            this.bLimpiarPrestamo.Click += new System.EventHandler(this.bLimpiarPrestamo_Click);
            // 
            // ModificarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 304);
            this.Controls.Add(this.bLimpiarPrestamo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bBuscarPrestamo);
            this.Controls.Add(this.tId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.tTiempo);
            this.Controls.Add(this.tInteres);
            this.Controls.Add(this.tMonto);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cEstaddo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimePrestamo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bBuscarCliente);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(439, 347);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(439, 347);
            this.Name = "ModificarPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Prestamo";
            this.Load += new System.EventHandler(this.ModificarPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bBuscarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tTiempo;
        private System.Windows.Forms.TextBox tInteres;
        private System.Windows.Forms.TextBox tMonto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox tUsuario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cEstaddo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePrestamo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bBuscarPrestamo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bLimpiarPrestamo;
    }
}