namespace Festival_Petronio
{
    partial class FormGrupo
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
            this.registrolabel = new System.Windows.Forms.Label();
            this.nombreGlabel = new System.Windows.Forms.Label();
            this.munilabel = new System.Windows.Forms.Label();
            this.modalilabel = new System.Windows.Forms.Label();
            this.nombreGtextB = new System.Windows.Forms.TextBox();
            this.munitextB = new System.Windows.Forms.TextBox();
            this.modalicomboB = new System.Windows.Forms.ComboBox();
            this.ingresarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registrolabel
            // 
            this.registrolabel.AutoSize = true;
            this.registrolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrolabel.Location = new System.Drawing.Point(12, 9);
            this.registrolabel.Name = "registrolabel";
            this.registrolabel.Size = new System.Drawing.Size(406, 25);
            this.registrolabel.TabIndex = 0;
            this.registrolabel.Text = "REGISTRO DE GRUPOS MUSICALES";
            // 
            // nombreGlabel
            // 
            this.nombreGlabel.AutoSize = true;
            this.nombreGlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreGlabel.Location = new System.Drawing.Point(13, 70);
            this.nombreGlabel.Name = "nombreGlabel";
            this.nombreGlabel.Size = new System.Drawing.Size(139, 20);
            this.nombreGlabel.TabIndex = 1;
            this.nombreGlabel.Text = "Nombre del grupo:";
            // 
            // munilabel
            // 
            this.munilabel.AutoSize = true;
            this.munilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munilabel.Location = new System.Drawing.Point(13, 111);
            this.munilabel.Name = "munilabel";
            this.munilabel.Size = new System.Drawing.Size(79, 20);
            this.munilabel.TabIndex = 2;
            this.munilabel.Text = "Municipio:";
            // 
            // modalilabel
            // 
            this.modalilabel.AutoSize = true;
            this.modalilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modalilabel.Location = new System.Drawing.Point(13, 158);
            this.modalilabel.Name = "modalilabel";
            this.modalilabel.Size = new System.Drawing.Size(86, 20);
            this.modalilabel.TabIndex = 3;
            this.modalilabel.Text = "Modalidad:";
            // 
            // nombreGtextB
            // 
            this.nombreGtextB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreGtextB.Location = new System.Drawing.Point(158, 70);
            this.nombreGtextB.Name = "nombreGtextB";
            this.nombreGtextB.Size = new System.Drawing.Size(173, 24);
            this.nombreGtextB.TabIndex = 4;
            this.nombreGtextB.TextChanged += new System.EventHandler(this.nombreGtextB_TextChanged);
            // 
            // munitextB
            // 
            this.munitextB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munitextB.Location = new System.Drawing.Point(105, 111);
            this.munitextB.Name = "munitextB";
            this.munitextB.Size = new System.Drawing.Size(168, 24);
            this.munitextB.TabIndex = 5;
            // 
            // modalicomboB
            // 
            this.modalicomboB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modalicomboB.FormattingEnabled = true;
            this.modalicomboB.Items.AddRange(new object[] {
            "Chirimia",
            "Marimba",
            "Violines",
            "Libre"});
            this.modalicomboB.Location = new System.Drawing.Point(105, 152);
            this.modalicomboB.Name = "modalicomboB";
            this.modalicomboB.Size = new System.Drawing.Size(143, 26);
            this.modalicomboB.TabIndex = 7;
            // 
            // ingresarbtn
            // 
            this.ingresarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarbtn.Location = new System.Drawing.Point(134, 204);
            this.ingresarbtn.Name = "ingresarbtn";
            this.ingresarbtn.Size = new System.Drawing.Size(160, 27);
            this.ingresarbtn.TabIndex = 8;
            this.ingresarbtn.Text = "Ingresar músicos";
            this.ingresarbtn.UseVisualStyleBackColor = true;
            this.ingresarbtn.Click += new System.EventHandler(this.ingresarbtn_Click);
            // 
            // FormGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 267);
            this.Controls.Add(this.ingresarbtn);
            this.Controls.Add(this.modalicomboB);
            this.Controls.Add(this.munitextB);
            this.Controls.Add(this.nombreGtextB);
            this.Controls.Add(this.modalilabel);
            this.Controls.Add(this.munilabel);
            this.Controls.Add(this.nombreGlabel);
            this.Controls.Add(this.registrolabel);
            this.MaximizeBox = false;
            this.Name = "FormGrupo";
            this.Text = "Festival Petronio Álvarez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registrolabel;
        private System.Windows.Forms.Label nombreGlabel;
        private System.Windows.Forms.Label munilabel;
        private System.Windows.Forms.Label modalilabel;
        private System.Windows.Forms.TextBox nombreGtextB;
        private System.Windows.Forms.TextBox munitextB;
        private System.Windows.Forms.ComboBox modalicomboB;
        private System.Windows.Forms.Button ingresarbtn;
    }
}

