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
        public StaticReferences()
        {
            InitializeComponent();
            fillForms.FillTable(Scripts.Select.SelectPlacementType, dataGridView1);
            fillForms.FillTable(Scripts.Select.SelectActionType, dataGridView2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRef = new AddRef(tabControl1.SelectedTab, "Добавление")
            {
                Tag = this
            };

            AddRef.Show();


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
                case "Тип действия приказа:":
                    changeTables.deleteFromTable(
                        Scripts.Delete.DeleteActionType,
                        Scripts.Select.SelectActionType,
                        dataGridView2);
                    break;
            }

        }
    }
}
