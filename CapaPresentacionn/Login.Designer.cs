namespace CapaPresentacionn
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bIniciar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bCerrar = new System.Windows.Forms.Button();
            this.bMinimizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tContra = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tUsuario
            // 
            this.tUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.tUsuario.Location = new System.Drawing.Point(334, 89);
            this.tUsuario.Multiline = true;
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(271, 30);
            this.tUsuario.TabIndex = 122;
            this.tUsuario.Text = "USUARIO";
            this.tUsuario.Enter += new System.EventHandler(this.tCorreo_Enter);
            this.tUsuario.Leave += new System.EventHandler(this.tCorreo_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(394, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Iniciar Seccion";
            // 
            // bIniciar
            // 
            this.bIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bIniciar.FlatAppearance.BorderSize = 0;
            this.bIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIniciar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bIniciar.Location = new System.Drawing.Point(334, 222);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(271, 35);
            this.bIniciar.TabIndex = 0;
            this.bIniciar.Text = "Iniciar";
            this.bIniciar.UseVisualStyleBackColor = false;
            this.bIniciar.Click += new System.EventHandler(this.bIniciar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 303);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacionn.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 225);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacionn.Properties.Resources.Icono_Usuairo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bCerrar
            // 
            this.bCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCerrar.Image = global::CapaPresentacionn.Properties.Resources.closewindowapplication_cerca_ventan_2874;
            this.bCerrar.Location = new System.Drawing.Point(607, 0);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(35, 23);
            this.bCerrar.TabIndex = 2334;
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bMinimizar
            // 
            this.bMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMinimizar.Image = global::CapaPresentacionn.Properties.Resources.minimize_thewindow_theapplication_2872;
            this.bMinimizar.Location = new System.Drawing.Point(573, 0);
            this.bMinimizar.Name = "bMinimizar";
            this.bMinimizar.Size = new System.Drawing.Size(30, 23);
            this.bMinimizar.TabIndex = 2333;
            this.bMinimizar.UseVisualStyleBackColor = true;
            this.bMinimizar.Click += new System.EventHandler(this.bMinimizar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(334, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 1);
            this.button1.TabIndex = 2335;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(331, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 1);
            this.button2.TabIndex = 2336;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tContra
            // 
            this.tContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tContra.ForeColor = System.Drawing.Color.DarkGray;
            this.tContra.Location = new System.Drawing.Point(334, 152);
            this.tContra.Multiline = true;
            this.tContra.Name = "tContra";
            this.tContra.PasswordChar = '*';
            this.tContra.Size = new System.Drawing.Size(271, 28);
            this.tContra.TabIndex = 2332;
            this.tContra.Text = "PASSWORD";
            this.tContra.Enter += new System.EventHandler(this.tContra_Enter);
            this.tContra.Leave += new System.EventHandler(this.tContra_Leave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(644, 303);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bMinimizar);
            this.Controls.Add(this.bIniciar);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tContra);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bMinimizar;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tContra;
    }
}

