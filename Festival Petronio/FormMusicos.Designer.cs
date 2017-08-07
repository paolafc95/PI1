namespace Festival_Petronio
{
    partial class FormMusicos
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
            this.nombremuslabel = new System.Windows.Forms.Label();
            this.edadlabel = new System.Windows.Forms.Label();
            this.generolabel = new System.Windows.Forms.Label();
            this.tipoinslabel = new System.Windows.Forms.Label();
            this.indatoslabel = new System.Windows.Forms.Label();
            this.nombremusitextB = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.femradioB = new System.Windows.Forms.RadioButton();
            this.masradioB = new System.Windows.Forms.RadioButton();
            this.tipoinscomboB = new System.Windows.Forms.ComboBox();
            this.ingresarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombremuslabel
            // 
            this.nombremuslabel.AutoSize = true;
            this.nombremuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombremuslabel.Location = new System.Drawing.Point(12, 44);
            this.nombremuslabel.Name = "nombremuslabel";
            this.nombremuslabel.Size = new System.Drawing.Size(69, 20);
            this.nombremuslabel.TabIndex = 0;
            this.nombremuslabel.Text = "Nombre:";
            // 
            // edadlabel
            // 
            this.edadlabel.AutoSize = true;
            this.edadlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edadlabel.Location = new System.Drawing.Point(12, 76);
            this.edadlabel.Name = "edadlabel";
            this.edadlabel.Size = new System.Drawing.Size(51, 20);
            this.edadlabel.TabIndex = 1;
            this.edadlabel.Text = "Edad:";
            // 
            // generolabel
            // 
            this.generolabel.AutoSize = true;
            this.generolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generolabel.Location = new System.Drawing.Point(12, 109);
            this.generolabel.Name = "generolabel";
            this.generolabel.Size = new System.Drawing.Size(67, 20);
            this.generolabel.TabIndex = 2;
            this.generolabel.Text = "Género:";
            // 
            // tipoinslabel
            // 
            this.tipoinslabel.AutoSize = true;
            this.tipoinslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoinslabel.Location = new System.Drawing.Point(12, 144);
            this.tipoinslabel.Name = "tipoinslabel";
            this.tipoinslabel.Size = new System.Drawing.Size(153, 20);
            this.tipoinslabel.TabIndex = 3;
            this.tipoinslabel.Text = "Tipo de instrumento:";
            // 
            // indatoslabel
            // 
            this.indatoslabel.AutoSize = true;
            this.indatoslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indatoslabel.Location = new System.Drawing.Point(77, 9);
            this.indatoslabel.Name = "indatoslabel";
            this.indatoslabel.Size = new System.Drawing.Size(277, 24);
            this.indatoslabel.TabIndex = 4;
            this.indatoslabel.Text = "Ingrese los datos del músico";
            this.indatoslabel.Click += new System.EventHandler(this.indatoslabel_Click);
            // 
            // nombremusitextB
            // 
            this.nombremusitextB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombremusitextB.Location = new System.Drawing.Point(87, 44);
            this.nombremusitextB.Name = "nombremusitextB";
            this.nombremusitextB.Size = new System.Drawing.Size(246, 24);
            this.nombremusitextB.TabIndex = 5;
            this.nombremusitextB.TextChanged += new System.EventHandler(this.nombremusitextB_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(87, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 24);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // femradioB
            // 
            this.femradioB.AutoSize = true;
            this.femradioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femradioB.Location = new System.Drawing.Point(85, 107);
            this.femradioB.Name = "femradioB";
            this.femradioB.Size = new System.Drawing.Size(92, 22);
            this.femradioB.TabIndex = 7;
            this.femradioB.TabStop = true;
            this.femradioB.Text = "Femenino";
            this.femradioB.UseVisualStyleBackColor = true;
            // 
            // masradioB
            // 
            this.masradioB.AutoSize = true;
            this.masradioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masradioB.Location = new System.Drawing.Point(183, 109);
            this.masradioB.Name = "masradioB";
            this.masradioB.Size = new System.Drawing.Size(94, 22);
            this.masradioB.TabIndex = 8;
            this.masradioB.TabStop = true;
            this.masradioB.Text = "Masculino";
            this.masradioB.UseVisualStyleBackColor = true;
            // 
            // tipoinscomboB
            // 
            this.tipoinscomboB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoinscomboB.FormattingEnabled = true;
            this.tipoinscomboB.Items.AddRange(new object[] {
            "Cuerda",
            "Viento",
            "Percusión"});
            this.tipoinscomboB.Location = new System.Drawing.Point(171, 142);
            this.tipoinscomboB.Name = "tipoinscomboB";
            this.tipoinscomboB.Size = new System.Drawing.Size(129, 26);
            this.tipoinscomboB.TabIndex = 9;
            // 
            // ingresarbtn
            // 
            this.ingresarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarbtn.Location = new System.Drawing.Point(171, 203);
            this.ingresarbtn.Name = "ingresarbtn";
            this.ingresarbtn.Size = new System.Drawing.Size(77, 27);
            this.ingresarbtn.TabIndex = 10;
            this.ingresarbtn.Text = "Ingresar";
            this.ingresarbtn.UseVisualStyleBackColor = true;
            // 
            // FormMusicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 267);
            this.Controls.Add(this.ingresarbtn);
            this.Controls.Add(this.tipoinscomboB);
            this.Controls.Add(this.masradioB);
            this.Controls.Add(this.femradioB);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nombremusitextB);
            this.Controls.Add(this.indatoslabel);
            this.Controls.Add(this.tipoinslabel);
            this.Controls.Add(this.generolabel);
            this.Controls.Add(this.edadlabel);
            this.Controls.Add(this.nombremuslabel);
            this.MaximizeBox = false;
            this.Name = "FormMusicos";
            this.Text = "Festival Petronio Álvarez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombremuslabel;
        private System.Windows.Forms.Label edadlabel;
        private System.Windows.Forms.Label generolabel;
        private System.Windows.Forms.Label tipoinslabel;
        private System.Windows.Forms.Label indatoslabel;
        private System.Windows.Forms.TextBox nombremusitextB;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton femradioB;
        private System.Windows.Forms.RadioButton masradioB;
        private System.Windows.Forms.ComboBox tipoinscomboB;
        private System.Windows.Forms.Button ingresarbtn;
    }
}