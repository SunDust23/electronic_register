using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace electronic_register
{
    public partial class StaticReferences : Form
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        public AddRef AddRef;
        FillForms fillForms = new FillForms();
        ChangeTables changeTables = new ChangeTables();
        public int updatedId;
        public string updatedName = "";
        public StaticReferences()
        {
            InitializeComponent();
            updateTables();
        }

        public void updateTables()
        {
            fillForms.FillTable(Scripts.Select.SelectPlacementType, dataGridView1);
            fillForms.FillTable(Scripts.Select.SelectActionType, dataGridView2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRef = new AddRef(tabControl1.SelectedTab, "Добавление", updatedName)
            {
                Tag = this
            };
            AddRef.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            switch (tabControl1.SelectedTab.Text)
            {
                case "Тип помещения":
                    updatedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    updatedName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    break;

                case "Тип действия приказа":
                    updatedId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                    updatedName = Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value);
                    break;
            }

            AddRef = new AddRef(tabControl1.SelectedTab, "Редактирование", updatedName)
            {
                Tag = this
            };
            AddRef.Show();

            updatedName = "";

        }
        private void button3_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "Тип помещения":
                    changeTables.deleteFromTable(
                        Scripts.Delete.DeletePlacementType,
                        Scripts.Select.SelectPlacementType,
                        dataGridView1);
                    break;
                case "Тип действия приказа":
                    changeTables.deleteFromTable(
                        Scripts.Delete.DeleteActionType,
                        Scripts.Select.SelectActionType,
                        dataGridView2);
                    break;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_selectedRow.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_selectedRow.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value);
        }
    }
}
