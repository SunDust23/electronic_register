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
    public partial class Main : Form
    {
        readonly MySqlConnection conn = DBUtils.GetDBConnection();

        public About About;
        public Order Order;
        public Placements Placements;
        public Divisions Divisions;
        public AddDivision DivisionsAdd;
        public AddOrder OrdersAdd;
        public AddPlacement PlacementsAdd;
        public StaticReferences StaticReferences;


        public Main()
        {
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            InitializeComponent();

            changeCompany();
        }

        private void changeCompany() //string query) System.Windows.Forms.DataGrid form
        {
            string query = "SELECT * FROM Company WHERE id = 1 ";

            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();

            mySql_dataAdapter.Fill(table);
            mySql_dataAdapter.Dispose();

           // MySqlCommand command = new MySqlCommand(query, conn);
            //command.ExecuteNonQuery();
            foreach (DataRow row in table.Rows)
            {
                groupBox1.Text = Convert.ToString(row["Name"]);
            }
            
            // выполняем запрос
            // label3.Text = 

        }
        //public void fillComboBox(string script, string dis, string val, System.Windows.Forms.ComboBox comboBox1)
        //{

        //    MySqlConnection conn = DBUtils.GetDBConnection();
        //    conn.Open();

        //    MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, conn);
        //    DataTable table = new DataTable();

        //    mySql_dataAdapter.Fill(table);

        //    comboBox1.DataSource = table;
        //    comboBox1.DisplayMember = dis;
        //    comboBox1.ValueMember = val;

        //    conn.Close();
        //}

        private void добавитьПодразделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DivisionsAdd = new AddDivision
            {
                Tag = this
            };
            DivisionsAdd.Show();
        }

        private void иерархияПодразделенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Divisions = new Divisions
            {
                Tag = this
            };
            Divisions.Show();
        }

        private void добавитьПомещениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlacementsAdd = new AddPlacement
            {
                Tag = this
            };
            PlacementsAdd.Show();
        }

        private void списокПомещенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Placements = new Placements
            {
                Tag = this
            };
            Placements.Show();
        }

        private void создатьПриказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersAdd = new AddOrder
            {
                Tag = this
            };
            OrdersAdd.Show();
        }

        private void списокПриказовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order = new Order
            {
                Tag = this
            };
            Order.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About = new About
            {
                Tag = this
            };
            About.Show();
        }

        private void открытьСправочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticReferences = new StaticReferences
            {
                Tag = this
            };
            StaticReferences.Show();
        }
    }
}
