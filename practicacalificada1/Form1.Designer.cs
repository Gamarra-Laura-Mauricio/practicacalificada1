namespace practicacalificada1
{
    partial class Form1
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
            this.spAgregarT = new System.Windows.Forms.Button();
            this.spEliminarT = new System.Windows.Forms.Button();
            this.spListarT = new System.Windows.Forms.Button();
            this.spActualizarT = new System.Windows.Forms.Button();
            this.txtCodAlumno = new System.Windows.Forms.TextBox();
            this.txtAPaterno = new System.Windows.Forms.TextBox();
            this.txtAMaterno = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCodCarrera = new System.Windows.Forms.TextBox();
            this.dgvTAlumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // spAgregarT
            // 
            this.spAgregarT.Location = new System.Drawing.Point(708, 39);
            this.spAgregarT.Name = "spAgregarT";
            this.spAgregarT.Size = new System.Drawing.Size(128, 58);
            this.spAgregarT.TabIndex = 0;
            this.spAgregarT.Text = "Agregar";
            this.spAgregarT.UseVisualStyleBackColor = true;
            this.spAgregarT.Click += new System.EventHandler(this.spAgregarT_Click);
            // 
            // spEliminarT
            // 
            this.spEliminarT.Location = new System.Drawing.Point(897, 39);
            this.spEliminarT.Name = "spEliminarT";
            this.spEliminarT.Size = new System.Drawing.Size(128, 58);
            this.spEliminarT.TabIndex = 1;
            this.spEliminarT.Text = "Eliminar";
            this.spEliminarT.UseVisualStyleBackColor = true;
            this.spEliminarT.Click += new System.EventHandler(this.spEliminarT_Click);
            // 
            // spListarT
            // 
            this.spListarT.Location = new System.Drawing.Point(708, 115);
            this.spListarT.Name = "spListarT";
            this.spListarT.Size = new System.Drawing.Size(128, 58);
            this.spListarT.TabIndex = 2;
            this.spListarT.Text = "Listar";
            this.spListarT.UseVisualStyleBackColor = true;
            this.spListarT.Click += new System.EventHandler(this.spListarT_Click);
            // 
            // spActualizarT
            // 
            this.spActualizarT.Location = new System.Drawing.Point(897, 115);
            this.spActualizarT.Name = "spActualizarT";
            this.spActualizarT.Size = new System.Drawing.Size(128, 58);
            this.spActualizarT.TabIndex = 3;
            this.spActualizarT.Text = "Actualizar";
            this.spActualizarT.UseVisualStyleBackColor = true;
            this.spActualizarT.Click += new System.EventHandler(this.spActualizarT_Click);
            // 
            // txtCodAlumno
            // 
            this.txtCodAlumno.Location = new System.Drawing.Point(330, 24);
            this.txtCodAlumno.Name = "txtCodAlumno";
            this.txtCodAlumno.Size = new System.Drawing.Size(230, 20);
            this.txtCodAlumno.TabIndex = 4;
            // 
            // txtAPaterno
            // 
            this.txtAPaterno.Location = new System.Drawing.Point(330, 67);
            this.txtAPaterno.Name = "txtAPaterno";
            this.txtAPaterno.Size = new System.Drawing.Size(230, 20);
            this.txtAPaterno.TabIndex = 5;
            // 
            // txtAMaterno
            // 
            this.txtAMaterno.Location = new System.Drawing.Point(330, 113);
            this.txtAMaterno.Name = "txtAMaterno";
            this.txtAMaterno.Size = new System.Drawing.Size(230, 20);
            this.txtAMaterno.TabIndex = 6;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(330, 161);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(230, 20);
            this.txtNombres.TabIndex = 7;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(330, 216);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(230, 20);
            this.txtUsuario.TabIndex = 8;
            // 
            // txtCodCarrera
            // 
            this.txtCodCarrera.Location = new System.Drawing.Point(330, 266);
            this.txtCodCarrera.Name = "txtCodCarrera";
            this.txtCodCarrera.Size = new System.Drawing.Size(230, 20);
            this.txtCodCarrera.TabIndex = 9;
            // 
            // dgvTAlumnos
            // 
            this.dgvTAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTAlumnos.Location = new System.Drawing.Point(96, 312);
            this.dgvTAlumnos.Name = "dgvTAlumnos";
            this.dgvTAlumnos.Size = new System.Drawing.Size(959, 230);
            this.dgvTAlumnos.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 562);
            this.Controls.Add(this.dgvTAlumnos);
            this.Controls.Add(this.txtCodCarrera);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtAMaterno);
            this.Controls.Add(this.txtAPaterno);
            this.Controls.Add(this.txtCodAlumno);
            this.Controls.Add(this.spActualizarT);
            this.Controls.Add(this.spListarT);
            this.Controls.Add(this.spEliminarT);
            this.Controls.Add(this.spAgregarT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button spAgregarT;
        private System.Windows.Forms.Button spEliminarT;
        private System.Windows.Forms.Button spListarT;
        private System.Windows.Forms.Button spActualizarT;
        private System.Windows.Forms.TextBox txtCodAlumno;
        private System.Windows.Forms.TextBox txtAPaterno;
        private System.Windows.Forms.TextBox txtAMaterno;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCodCarrera;
        private System.Windows.Forms.DataGridView dgvTAlumnos;
    }
}

