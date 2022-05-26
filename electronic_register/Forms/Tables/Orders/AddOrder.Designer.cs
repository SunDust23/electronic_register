namespace electronic_register
{
    partial class AddOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_action = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_validity = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_division = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_orderNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_addPlacement = new System.Windows.Forms.ListBox();
            this.listBox_AllPlacements = new System.Windows.Forms.ListBox();
            this.addPlacementbutton = new System.Windows.Forms.Button();
            this.delPlacementButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_action);
            this.groupBox1.Controls.Add(this.dateTimePicker_validity);
            this.groupBox1.Controls.Add(this.dateTimePicker_date);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox_division);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_orderNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 309);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Приказ";
            // 
            // comboBox_action
            // 
            this.comboBox_action.FormattingEnabled = true;
            this.comboBox_action.Location = new System.Drawing.Point(166, 83);
            this.comboBox_action.Name = "comboBox_action";
            this.comboBox_action.Size = new System.Drawing.Size(162, 24);
            this.comboBox_action.TabIndex = 13;
            // 
            // dateTimePicker_validity
            // 
            this.dateTimePicker_validity.Location = new System.Drawing.Point(166, 161);
            this.dateTimePicker_validity.Name = "dateTimePicker_validity";
            this.dateTimePicker_validity.Size = new System.Drawing.Size(162, 22);
            this.dateTimePicker_validity.TabIndex = 12;
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(166, 123);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(162, 22);
            this.dateTimePicker_date.TabIndex = 11;
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
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Срок действия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата подписания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер приказа";
            // 
            // textBox_orderNum
            // 
            this.textBox_orderNum.Location = new System.Drawing.Point(166, 47);
            this.textBox_orderNum.Name = "textBox_orderNum";
            this.textBox_orderNum.Size = new System.Drawing.Size(162, 22);
            this.textBox_orderNum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Действие";
            // 
            // listBox_addPlacement
            // 
            this.listBox_addPlacement.FormattingEnabled = true;
            this.listBox_addPlacement.ItemHeight = 16;
            this.listBox_addPlacement.Location = new System.Drawing.Point(17, 53);
            this.listBox_addPlacement.Name = "listBox_addPlacement";
            this.listBox_addPlacement.Size = new System.Drawing.Size(135, 212);
            this.listBox_addPlacement.TabIndex = 4;
            // 
            // listBox_AllPlacements
            // 
            this.listBox_AllPlacements.FormattingEnabled = true;
            this.listBox_AllPlacements.ItemHeight = 16;
            this.listBox_AllPlacements.Location = new System.Drawing.Point(166, 53);
            this.listBox_AllPlacements.Name = "listBox_AllPlacements";
            this.listBox_AllPlacements.Size = new System.Drawing.Size(135, 212);
            this.listBox_AllPlacements.TabIndex = 5;
            // 
            // addPlacementbutton
            // 
            this.addPlacementbutton.Location = new System.Drawing.Point(125, 276);
            this.addPlacementbutton.Name = "addPlacementbutton";
            this.addPlacementbutton.Size = new System.Drawing.Size(27, 23);
            this.addPlacementbutton.TabIndex = 6;
            this.addPlacementbutton.Text = "+";
            this.addPlacementbutton.UseVisualStyleBackColor = true;
            this.addPlacementbutton.Click += new System.EventHandler(this.addPlacementbutton_Click);
            // 
            // delPlacementButton
            // 
            this.delPlacementButton.Location = new System.Drawing.Point(166, 276);
            this.delPlacementButton.Name = "delPlacementButton";
            this.delPlacementButton.Size = new System.Drawing.Size(27, 23);
            this.delPlacementButton.TabIndex = 7;
            this.delPlacementButton.Text = "-";
            this.delPlacementButton.UseVisualStyleBackColor = true;
            this.delPlacementButton.Click += new System.EventHandler(this.delPlacementButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.listBox_addPlacement);
            this.groupBox2.Controls.Add(this.delPlacementButton);
            this.groupBox2.Controls.Add(this.addPlacementbutton);
            this.groupBox2.Controls.Add(this.listBox_AllPlacements);
            this.groupBox2.Location = new System.Drawing.Point(373, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 309);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Помещения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Выбранные ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Все помещения";
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 359);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddOrder";
            this.Text = "Добавить приказ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_validity;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_division;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_orderNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_addPlacement;
        private System.Windows.Forms.ListBox listBox_AllPlacements;
        private System.Windows.Forms.Button addPlacementbutton;
        private System.Windows.Forms.Button delPlacementButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_action;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}