namespace EscuelaUS
{
    partial class Universidad
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
            this.Calificaciones = new System.Windows.Forms.Label();
            this.FormNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.formCalificacion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dglista = new System.Windows.Forms.DataGridView();
            this.dbnombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dglista)).BeginInit();
            this.SuspendLayout();
            // 
            // Calificaciones
            // 
            this.Calificaciones.AutoSize = true;
            this.Calificaciones.Location = new System.Drawing.Point(276, 13);
            this.Calificaciones.Name = "Calificaciones";
            this.Calificaciones.Size = new System.Drawing.Size(81, 13);
            this.Calificaciones.TabIndex = 0;
            this.Calificaciones.Text = "UNIVERSIDAD";
            // 
            // FormNombre
            // 
            this.FormNombre.AutoSize = true;
            this.FormNombre.Location = new System.Drawing.Point(71, 119);
            this.FormNombre.Name = "FormNombre";
            this.FormNombre.Size = new System.Drawing.Size(44, 13);
            this.FormNombre.TabIndex = 1;
            this.FormNombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calificacion";
            // 
            // formCalificacion
            // 
            this.formCalificacion.Location = new System.Drawing.Point(167, 176);
            this.formCalificacion.Name = "formCalificacion";
            this.formCalificacion.Size = new System.Drawing.Size(100, 20);
            this.formCalificacion.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "CONSULTAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(208, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 51);
            this.button3.TabIndex = 7;
            this.button3.Text = "ACTUALIZAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(304, 304);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 51);
            this.button4.TabIndex = 8;
            this.button4.Text = "ELIMINAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dglista
            // 
            this.dglista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglista.Location = new System.Drawing.Point(304, 54);
            this.dglista.Name = "dglista";
            this.dglista.Size = new System.Drawing.Size(340, 233);
            this.dglista.TabIndex = 9;
            this.dglista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dbnombre
            // 
            this.dbnombre.Location = new System.Drawing.Point(167, 111);
            this.dbnombre.Name = "dbnombre";
            this.dbnombre.Size = new System.Drawing.Size(100, 20);
            this.dbnombre.TabIndex = 10;
            // 
            // Universidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dbnombre);
            this.Controls.Add(this.dglista);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.formCalificacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FormNombre);
            this.Controls.Add(this.Calificaciones);
            this.Name = "Universidad";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Universidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dglista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Calificaciones;
        private System.Windows.Forms.Label FormNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox formNombre;
        private System.Windows.Forms.TextBox formCalificacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dglista;
        private System.Windows.Forms.TextBox dbnombre;
    }
}

