namespace electronic_register
{
    partial class Placements
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tablePage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_selectedId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SquarePage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_first = new System.Windows.Forms.DateTimePicker();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listPage = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_last = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tablePage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SquarePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.listPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tablePage);
            this.tabControl1.Controls.Add(this.SquarePage);
            this.tabControl1.Controls.Add(this.listPage);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1007, 458);
            this.tabControl1.TabIndex = 2;
            // 
            // tablePage
            // 
            this.tablePage.BackColor = System.Drawing.SystemColors.Control;
            this.tablePage.Controls.Add(this.groupBox1);
            this.tablePage.Controls.Add(this.dataGridView1);
            this.tablePage.Location = new System.Drawing.Point(4, 25);
            this.tablePage.Name = "tablePage";
            this.tablePage.Padding = new System.Windows.Forms.Padding(3);
            this.tablePage.Size = new System.Drawing.Size(999, 429);
            this.tablePage.TabIndex = 0;
            this.tablePage.Text = "Таблица";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_selectedId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(800, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 405);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление таблицей";
            // 
            // textBox_selectedId
            // 
            this.textBox_selectedId.Location = new System.Drawing.Point(20, 370);
            this.textBox_selectedId.Name = "textBox_selectedId";
            this.textBox_selectedId.ReadOnly = true;
            this.textBox_selectedId.Size = new System.Drawing.Size(121, 22);
            this.textBox_selectedId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбранная срока:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(775, 405);
            this.dataGridView1.TabIndex = 0;
            // 
            // SquarePage
            // 
            this.SquarePage.BackColor = System.Drawing.SystemColors.Control;
            this.SquarePage.Controls.Add(this.label3);
            this.SquarePage.Controls.Add(this.dateTimePicker_last);
            this.SquarePage.Controls.Add(this.label2);
            this.SquarePage.Controls.Add(this.dateTimePicker_first);
            this.SquarePage.Controls.Add(this.chart);
            this.SquarePage.Location = new System.Drawing.Point(4, 25);
            this.SquarePage.Name = "SquarePage";
            this.SquarePage.Padding = new System.Windows.Forms.Padding(3);
            this.SquarePage.Size = new System.Drawing.Size(999, 429);
            this.SquarePage.TabIndex = 1;
            this.SquarePage.Text = "Площади помещений";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата начала:";
            // 
            // dateTimePicker_first
            // 
            this.dateTimePicker_first.Location = new System.Drawing.Point(743, 60);
            this.dateTimePicker_first.Name = "dateTimePicker_first";
            this.dateTimePicker_first.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_first.TabIndex = 1;
            this.dateTimePicker_first.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // chart
            // 
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(22, 21);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(702, 391);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // listPage
            // 
            this.listPage.BackColor = System.Drawing.SystemColors.Control;
            this.listPage.Controls.Add(this.label4);
            this.listPage.Controls.Add(this.dataGridView2);
            this.listPage.Controls.Add(this.dateTimePicker2);
            this.listPage.Location = new System.Drawing.Point(4, 25);
            this.listPage.Name = "listPage";
            this.listPage.Padding = new System.Windows.Forms.Padding(3);
            this.listPage.Size = new System.Drawing.Size(999, 429);
            this.listPage.TabIndex = 2;
            this.listPage.Text = "Выборка по датам";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(662, 420);
            this.dataGridView2.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(744, 50);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 0;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(740, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата конца:";
            // 
            // dateTimePicker_last
            // 
            this.dateTimePicker_last.Location = new System.Drawing.Point(743, 127);
            this.dateTimePicker_last.Name = "dateTimePicker_last";
            this.dateTimePicker_last.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_last.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(741, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дата:";
            // 
            // Placements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 464);
            this.Controls.Add(this.tabControl1);
            this.Name = "Placements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Помещения";
            this.tabControl1.ResumeLayout(false);
            this.tablePage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.SquarePage.ResumeLayout(false);
            this.SquarePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.listPage.ResumeLayout(false);
            this.listPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tablePage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_selectedId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage SquarePage;
        private System.Windows.Forms.DateTimePicker dateTimePicker_first;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage listPage;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_last;
        private System.Windows.Forms.Label label4;
    }
}