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
    public partial class Placements : Form
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        public AddPlacement PlacementAdd;
        FillForms fillForms = new FillForms();
        ChangeTables changeTables = new ChangeTables();

        public int updatedId;

        public Placements()
        {
            InitializeComponent();
            updateTables();
            dataGridView1.Columns[0].Visible = false;
        }

        public void updateTables()
        {
            fillForms.FillTable(Scripts.Select.SelectPlacement, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlacementAdd = new AddPlacement()
            {
                Tag = this
            };
            PlacementAdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            updatedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PlacementAdd = new AddPlacement(updatedId)
            {
                Tag = this
            };
            PlacementAdd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeTables.deleteFromTable(
                Scripts.Delete.DeletePlacement,
                Scripts.Select.SelectPlacement,
                dataGridView1);
            updateTables();
        }
    }
}
