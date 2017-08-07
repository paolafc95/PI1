namespace Festival_Petronio
{
    partial class FormIdentificacion
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
            this.nombrefestlabel = new System.Windows.Forms.Label();
            this.codigolabel = new System.Windows.Forms.Label();
            this.nombrefestextB = new System.Windows.Forms.TextBox();
            this.codigotextB = new System.Windows.Forms.TextBox();
            this.accederbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombrefestlabel
            // 
            this.nombrefestlabel.AutoSize = true;
            this.nombrefestlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrefestlabel.Location = new System.Drawing.Point(12, 55);
            this.nombrefestlabel.Name = "nombrefestlabel";
            this.nombrefestlabel.Size = new System.Drawing.Size(147, 20);
            this.nombrefestlabel.TabIndex = 0;
            this.nombrefestlabel.Text = "Nombre del festival:";
            // 
            // codigolabel
            // 
            this.codigolabel.AutoSize = true;
            this.codigolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigolabel.Location = new System.Drawing.Point(12, 104);
            this.codigolabel.Name = "codigolabel";
            this.codigolabel.Size = new System.Drawing.Size(141, 20);
            this.codigolabel.TabIndex = 1;
            this.codigolabel.Text = "Código del festival:";
            // 
            // nombrefestextB
            // 
            this.nombrefestextB.Location = new System.Drawing.Point(165, 55);
            this.nombrefestextB.Name = "nombrefestextB";
            this.nombrefestextB.Size = new System.Drawing.Size(184, 20);
            this.nombrefestextB.TabIndex = 2;
            // 
            // codigotextB
            // 
            this.codigotextB.Location = new System.Drawing.Point(165, 104);
            this.codigotextB.Name = "codigotextB";
            this.codigotextB.Size = new System.Drawing.Size(133, 20);
            this.codigotextB.TabIndex = 3;
            // 
            // accederbtn
            // 
            this.accederbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accederbtn.Location = new System.Drawing.Point(165, 189);
            this.accederbtn.Name = "accederbtn";
            this.accederbtn.Size = new System.Drawing.Size(81, 27);
            this.accederbtn.TabIndex = 4;
            this.accederbtn.Text = "Acceder";
            this.accederbtn.UseVisualStyleBackColor = true;
            this.accederbtn.Click += new System.EventHandler(this.ingresarbtn_Click);
            // 
            // FormIdentificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 267);
            this.Controls.Add(this.accederbtn);
            this.Controls.Add(this.codigotextB);
            this.Controls.Add(this.nombrefestextB);
            this.Controls.Add(this.codigolabel);
            this.Controls.Add(this.nombrefestlabel);
            this.MaximizeBox = false;
            this.Name = "FormIdentificacion";
            this.Text = "Identificación de festival";
            this.Load += new System.EventHandler(this.FormIdentificacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombrefestlabel;
        private System.Windows.Forms.Label codigolabel;
        private System.Windows.Forms.TextBox nombrefestextB;
        private System.Windows.Forms.TextBox codigotextB;
        private System.Windows.Forms.Button accederbtn;
    }
}