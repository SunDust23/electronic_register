namespace electronic_register
{
    partial class AddDivision
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_division = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_dativeCase = new System.Windows.Forms.TextBox();
            this.textBox_genetiveCase = new System.Windows.Forms.TextBox();
            this.textBox_shortName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(166, 47);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(162, 22);
            this.textBox_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox_division);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_dativeCase);
            this.groupBox1.Controls.Add(this.textBox_genetiveCase);
            this.groupBox1.Controls.Add(this.textBox_shortName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 309);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подразделение";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Подразделение";
            // 
            // comboBox_division
            // 
            this.comboBox_division.FormattingEnabled = true;
            this.comboBox_division.Location = new System.Drawing.Point(166, 202);
            this.comboBox_division.Name = "comboBox_division";
            this.comboBox_division.Size = new System.Drawing.Size(162, 24);
            this.comboBox_division.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дательный падеж";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Родительный падеж";
            // 
            // textBox_dativeCase
            // 
            this.textBox_dativeCase.Location = new System.Drawing.Point(166, 163);
            this.textBox_dativeCase.Name = "textBox_dativeCase";
            this.textBox_dativeCase.Size = new System.Drawing.Size(162, 22);
            this.textBox_dativeCase.TabIndex = 5;
            // 
            // textBox_genetiveCase
            // 
            this.textBox_genetiveCase.Location = new System.Drawing.Point(166, 125);
            this.textBox_genetiveCase.Name = "textBox_genetiveCase";
            this.textBox_genetiveCase.Size = new System.Drawing.Size(162, 22);
            this.textBox_genetiveCase.TabIndex = 4;
            // 
            // textBox_shortName
            // 
            this.textBox_shortName.Location = new System.Drawing.Point(166, 85);
            this.textBox_shortName.Name = "textBox_shortName";
            this.textBox_shortName.Size = new System.Drawing.Size(162, 22);
            this.textBox_shortName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Краткое название";
            // 
            // AddDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 349);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddDivision";
            this.Text = "Добавить подразделение";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_division;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_dativeCase;
        private System.Windows.Forms.TextBox textBox_genetiveCase;
        private System.Windows.Forms.TextBox textBox_shortName;
        private System.Windows.Forms.Label label2;
    }
}