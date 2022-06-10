using System;
using System.Data;
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

        public Auth Auth;



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
            getChanges();
        }

        public void getChanges()
        {
            countDivisions();
            countPlacements();
            countSquare();
        }

        private void countPlacements() 
        {
            string query = "SELECT count(id) FROM Placements";

            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();

            mySql_dataAdapter.Fill(table);
            mySql_dataAdapter.Dispose();

            foreach (DataRow row in table.Rows)
            {
                PlacementsCount.Text = Convert.ToString(row["count(id)"]);
            }
        }
        private void countDivisions()
        {
            string query = "SELECT count(id) FROM Divisions";

            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();

            mySql_dataAdapter.Fill(table);
            mySql_dataAdapter.Dispose();

            foreach (DataRow row in table.Rows)
            {
                DivisionsCount.Text = Convert.ToString(row["count(id)"]);
            }
        }
        private void countSquare()
        {
            string query = "SELECT sum(square) FROM Placements";

            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();

            mySql_dataAdapter.Fill(table);
            mySql_dataAdapter.Dispose();

            foreach (DataRow row in table.Rows)
            {
                SquareCount.Text = Convert.ToString(row["sum(square)"]) + " м^2"; 
            }
        }

        private void changeCompany() //string query) System.Windows.Forms.DataGrid form
        {
            string query = "SELECT * FROM Company WHERE id = 1 ";

            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();

            mySql_dataAdapter.Fill(table);
            mySql_dataAdapter.Dispose();

            foreach (DataRow row in table.Rows)
            {
                groupBox1.Text = Convert.ToString(row["Name"]);
            }

        }


        private void иерархияПодразделенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Divisions = new Divisions
            {
                Tag = this
            };
            Divisions.Show();
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
