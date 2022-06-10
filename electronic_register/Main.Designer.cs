namespace electronic_register
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьСправочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подразделенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иерархияПодразделенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помещенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПомещенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПриказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DivisionsCount = new System.Windows.Forms.Label();
            this.PlacementsCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SquareCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.подразделенияToolStripMenuItem,
            this.помещенияToolStripMenuItem,
            this.приказыToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьСправочникиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // открытьСправочникиToolStripMenuItem
            // 
            this.открытьСправочникиToolStripMenuItem.Name = "открытьСправочникиToolStripMenuItem";
            this.открытьСправочникиToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.открытьСправочникиToolStripMenuItem.Text = "Открыть справочники";
            this.открытьСправочникиToolStripMenuItem.Click += new System.EventHandler(this.открытьСправочникиToolStripMenuItem_Click);
            // 
            // подразделенияToolStripMenuItem
            // 
            this.подразделенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.иерархияПодразделенийToolStripMenuItem});
            this.подразделенияToolStripMenuItem.Name = "подразделенияToolStripMenuItem";
            this.подразделенияToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.подразделенияToolStripMenuItem.Text = "Подразделения";
            // 
            // иерархияПодразделенийToolStripMenuItem
            // 
            this.иерархияПодразделенийToolStripMenuItem.Name = "иерархияПодразделенийToolStripMenuItem";
            this.иерархияПодразделенийToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.иерархияПодразделенийToolStripMenuItem.Text = "Иерархия подразделений";
            this.иерархияПодразделенийToolStripMenuItem.Click += new System.EventHandler(this.иерархияПодразделенийToolStripMenuItem_Click);
            // 
            // помещенияToolStripMenuItem
            // 
            this.помещенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокПомещенийToolStripMenuItem});
            this.помещенияToolStripMenuItem.Name = "помещенияToolStripMenuItem";
            this.помещенияToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.помещенияToolStripMenuItem.Text = "Помещения";
            // 
            // списокПомещенийToolStripMenuItem
            // 
            this.списокПомещенийToolStripMenuItem.Name = "списокПомещенийToolStripMenuItem";
            this.списокПомещенийToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.списокПомещенийToolStripMenuItem.Text = "Список помещений";
            this.списокПомещенийToolStripMenuItem.Click += new System.EventHandler(this.списокПомещенийToolStripMenuItem_Click);
            // 
            // приказыToolStripMenuItem
            // 
            this.приказыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокПриказовToolStripMenuItem});
            this.приказыToolStripMenuItem.Name = "приказыToolStripMenuItem";
            this.приказыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.приказыToolStripMenuItem.Text = "Приказы";
            // 
            // списокПриказовToolStripMenuItem
            // 
            this.списокПриказовToolStripMenuItem.Name = "списокПриказовToolStripMenuItem";
            this.списокПриказовToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.списокПриказовToolStripMenuItem.Text = "Список приказов";
            this.списокПриказовToolStripMenuItem.Click += new System.EventHandler(this.списокПриказовToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DivisionsCount);
            this.groupBox1.Controls.Add(this.PlacementsCount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SquareCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 368);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Предприятие";
            // 
            // DivisionsCount
            // 
            this.DivisionsCount.AutoSize = true;
            this.DivisionsCount.Location = new System.Drawing.Point(216, 285);
            this.DivisionsCount.Name = "DivisionsCount";
            this.DivisionsCount.Size = new System.Drawing.Size(60, 16);
            this.DivisionsCount.TabIndex = 10;
            this.DivisionsCount.Text = "*кол-во*";
            // 
            // PlacementsCount
            // 
            this.PlacementsCount.AutoSize = true;
            this.PlacementsCount.Location = new System.Drawing.Point(216, 312);
            this.PlacementsCount.Name = "PlacementsCount";
            this.PlacementsCount.Size = new System.Drawing.Size(60, 16);
            this.PlacementsCount.TabIndex = 9;
            this.PlacementsCount.Text = "*кол-во*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Занимаемая площадь:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Помещений:";
            // 
            // SquareCount
            // 
            this.SquareCount.AutoSize = true;
            this.SquareCount.Location = new System.Drawing.Point(216, 339);
            this.SquareCount.Name = "SquareCount";
            this.SquareCount.Size = new System.Drawing.Size(60, 16);
            this.SquareCount.TabIndex = 6;
            this.SquareCount.Text = "*кол-во*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Подразделений:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "*Назначение*";
            this.label1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::electronic_register.Properties.Resources._1639261993_47_papik_pro_p_zavod_klipart_49;
            this.pictureBox1.Location = new System.Drawing.Point(367, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 368);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный реестр помещений";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem подразделенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помещенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приказыToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SquareCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DivisionsCount;
        private System.Windows.Forms.Label PlacementsCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem иерархияПодразделенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПомещенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПриказовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьСправочникиToolStripMenuItem;
    }
}

