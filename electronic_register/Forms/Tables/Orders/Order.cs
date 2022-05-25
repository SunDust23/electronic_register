using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace electronic_register
{
    public partial class Order : Form
    {
        MySqlConnection conn = DBUtils.GetDBConnection();

        AddOrder AddOrder = new AddOrder();
        
        FillForms fillForms = new FillForms();
        ChangeTables changeTables = new ChangeTables();

        public int updatedId;

        public Order()
        {
            InitializeComponent();
            updateTable();
            dataGridView1.Columns[0].Visible = false;
        }

        public void updateTable()
        {
            fillForms.FillTable(Scripts.Select.SelectOrders, dataGridView1);
            fillForms.FillListBox(Scripts.Select.SelectOrders, checkedListBox1);
            fillForms.FillListView(Scripts.Select.SelectOrders, listView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOrder = new AddOrder()
            {
                Tag = this
            };
            AddOrder.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updatedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            AddOrder = new AddOrder()
            {
                Tag = this
            };
            AddOrder.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeTables.deleteFromTable(
               Scripts.Delete.DeleteOrder,
               Scripts.Select.SelectOrders,
               dataGridView1);
            updateTable();
        }
    }
}
