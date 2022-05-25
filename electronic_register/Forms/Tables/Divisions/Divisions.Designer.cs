namespace electronic_register
{
    partial class Divisions
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tablePage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_selectedId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hierarchyPage = new System.Windows.Forms.TabPage();
            this.dataGridView_levels = new System.Windows.Forms.DataGridView();
            this.treePage = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tablePage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.hierarchyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_levels)).BeginInit();
            this.treePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tablePage);
            this.tabControl1.Controls.Add(this.hierarchyPage);
            this.tabControl1.Controls.Add(this.treePage);
            this.tabControl1.Location = new System.Drawing.Point(5, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1007, 458);
            this.tabControl1.TabIndex = 1;
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
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(775, 405);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hierarchyPage
            // 
            this.hierarchyPage.BackColor = System.Drawing.SystemColors.Control;
            this.hierarchyPage.Controls.Add(this.dataGridView_levels);
            this.hierarchyPage.Location = new System.Drawing.Point(4, 25);
            this.hierarchyPage.Name = "hierarchyPage";
            this.hierarchyPage.Padding = new System.Windows.Forms.Padding(3);
            this.hierarchyPage.Size = new System.Drawing.Size(999, 429);
            this.hierarchyPage.TabIndex = 1;
            this.hierarchyPage.Text = "Уровни";
            // 
            // dataGridView_levels
            // 
            this.dataGridView_levels.AllowUserToAddRows = false;
            this.dataGridView_levels.AllowUserToDeleteRows = false;
            this.dataGridView_levels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_levels.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_levels.Name = "dataGridView_levels";
            this.dataGridView_levels.RowHeadersWidth = 51;
            this.dataGridView_levels.RowTemplate.Height = 24;
            this.dataGridView_levels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_levels.Size = new System.Drawing.Size(775, 405);
            this.dataGridView_levels.TabIndex = 1;
            // 
            // treePage
            // 
            this.treePage.BackColor = System.Drawing.SystemColors.Control;
            this.treePage.Controls.Add(this.treeView1);
            this.treePage.Location = new System.Drawing.Point(4, 25);
            this.treePage.Name = "treePage";
            this.treePage.Padding = new System.Windows.Forms.Padding(3);
            this.treePage.Size = new System.Drawing.Size(999, 429);
            this.treePage.TabIndex = 2;
            this.treePage.Text = "Дерево";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(113, 14);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(772, 400);
            this.treeView1.TabIndex = 1;
            // 
            // Divisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 473);
            this.Controls.Add(this.tabControl1);
            this.Name = "Divisions";
            this.Text = "Подразделения";
            this.tabControl1.ResumeLayout(false);
            this.tablePage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.hierarchyPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_levels)).EndInit();
            this.treePage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tablePage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage hierarchyPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_selectedId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_levels;
        private System.Windows.Forms.TabPage treePage;
        private System.Windows.Forms.TreeView treeView1;
    }
}