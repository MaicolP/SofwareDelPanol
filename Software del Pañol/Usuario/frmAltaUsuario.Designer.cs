namespace Software_del_Pañol
{
    partial class frmAltaUsuario
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblCi = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.rbAlumno = new System.Windows.Forms.RadioButton();
            this.rbDocente = new System.Windows.Forms.RadioButton();
            this.rbAsisTec = new System.Windows.Forms.RadioButton();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1082, 60);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1082, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar Usuario";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.LightGray;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombre.Location = new System.Drawing.Point(185, 163);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(306, 32);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCi
            // 
            this.txtCi.BackColor = System.Drawing.Color.LightGray;
            this.txtCi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCi.Location = new System.Drawing.Point(185, 114);
            this.txtCi.Margin = new System.Windows.Forms.Padding(4);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(306, 32);
            this.txtCi.TabIndex = 5;
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.LightGray;
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtClave.Location = new System.Drawing.Point(185, 262);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(306, 32);
            this.txtClave.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.LightGray;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtApellido.Location = new System.Drawing.Point(185, 212);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(306, 32);
            this.txtApellido.TabIndex = 7;
            // 
            // lblCi
            // 
            this.lblCi.AutoSize = true;
            this.lblCi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCi.ForeColor = System.Drawing.Color.Black;
            this.lblCi.Location = new System.Drawing.Point(137, 117);
            this.lblCi.Name = "lblCi";
            this.lblCi.Size = new System.Drawing.Size(38, 29);
            this.lblCi.TabIndex = 1;
            this.lblCi.Text = "CI:";
            this.lblCi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.Black;
            this.lblNom.Location = new System.Drawing.Point(75, 166);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(100, 29);
            this.lblNom.TabIndex = 9;
            this.lblNom.Text = "Nombre:";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.Black;
            this.lblApellido.Location = new System.Drawing.Point(73, 215);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(102, 29);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.Black;
            this.lblClave.Location = new System.Drawing.Point(102, 265);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(73, 29);
            this.lblClave.TabIndex = 11;
            this.lblClave.Text = "Clave:";
            this.lblClave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(234)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(204, 457);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(252, 56);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(596, 114);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(425, 399);
            this.dgvUsuarios.TabIndex = 14;
            // 
            // rbAlumno
            // 
            this.rbAlumno.AutoSize = true;
            this.rbAlumno.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbAlumno.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAlumno.Location = new System.Drawing.Point(108, 318);
            this.rbAlumno.Name = "rbAlumno";
            this.rbAlumno.Size = new System.Drawing.Size(88, 27);
            this.rbAlumno.TabIndex = 16;
            this.rbAlumno.TabStop = true;
            this.rbAlumno.Text = "Alumno";
            this.rbAlumno.UseVisualStyleBackColor = true;
            // 
            // rbDocente
            // 
            this.rbDocente.AutoSize = true;
            this.rbDocente.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbDocente.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDocente.Location = new System.Drawing.Point(104, 351);
            this.rbDocente.Name = "rbDocente";
            this.rbDocente.Size = new System.Drawing.Size(92, 27);
            this.rbDocente.TabIndex = 17;
            this.rbDocente.TabStop = true;
            this.rbDocente.Text = "Docente";
            this.rbDocente.UseVisualStyleBackColor = true;
            // 
            // rbAsisTec
            // 
            this.rbAsisTec.AutoSize = true;
            this.rbAsisTec.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbAsisTec.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAsisTec.Location = new System.Drawing.Point(37, 384);
            this.rbAsisTec.Name = "rbAsisTec";
            this.rbAsisTec.Size = new System.Drawing.Size(159, 27);
            this.rbAsisTec.TabIndex = 18;
            this.rbAsisTec.TabStop = true;
            this.rbAsisTec.Text = "Asistente Técnico";
            this.rbAsisTec.UseVisualStyleBackColor = true;
            // 
            // frmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 575);
            this.Controls.Add(this.rbAsisTec);
            this.Controls.Add(this.rbDocente);
            this.Controls.Add(this.rbAlumno);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblCi);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCi);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "frmAltaUsuario";
            this.Text = "frmAltaUsuario";
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblCi;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.RadioButton rbAlumno;
        private System.Windows.Forms.RadioButton rbDocente;
        private System.Windows.Forms.RadioButton rbAsisTec;
    }
}