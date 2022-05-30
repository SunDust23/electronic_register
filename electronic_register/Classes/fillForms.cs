using System.Data;
using MySql.Data.MySqlClient;

namespace electronic_register
{
    internal class FillForms
    {
        readonly MySqlConnection conn = DBUtils.GetDBConnection();
        public void FillTable(string script, System.Windows.Forms.DataGridView dataGridView)
        {
            conn.Open();
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, conn);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);
            dataGridView.DataSource = table;
            conn.Close();
        }

        public void FillComboBox(string script, string display, string value, System.Windows.Forms.ComboBox comboBox)
        {
            conn.Open();
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, conn);
            DataTable table = new DataTable();

            mySql_dataAdapter.Fill(table);

            comboBox.DataSource = table;
            comboBox.DisplayMember = display;
            comboBox.ValueMember = value;
            conn.Close();
        }

        public void FillListView(string script, System.Windows.Forms.ListView listView)
        {
            conn.Open();
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, conn);
            DataTable table = new DataTable();

            mySql_dataAdapter.Fill(table);

            string orderNum, orderBody;

            foreach (DataRow row in table.Rows)
            {

                orderNum = "Приказ №" + row[1].ToString() + ": ";
                if (row[4].ToString() == "Закрепить")
                {
                    orderBody = orderNum + row[4].ToString()
                        + " за " + row[6].ToString() + " помещения: "
                        + row[8].ToString();
                }
                else
                {
                    orderBody = orderNum + row[4].ToString()
                        + " " + row[7].ToString() + " помещения: "
                        + row[8].ToString();
                }


                listView.Items.Add(orderBody);

            }

            conn.Close();
        }

        public void FillListBox(string script, System.Windows.Forms.ListBox listBox)
        {
            conn.Open();
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, conn);
            DataTable table = new DataTable();

            mySql_dataAdapter.Fill(table);

            string order;


            foreach (DataRow row in table.Rows)
            {
                string date = row[2].ToString();
                date = System.DateTime.Parse(date).ToShortDateString();
                string validation = row[3].ToString();
                validation = System.DateTime.Parse(date).ToShortDateString();

                order = "Приказ №" + row[1].ToString() + ": от " + date
                    + ", срок действия: " + validation;
                //+ " " + row[4].ToString() 
                //+ " " + row[5].ToString() + " следующие помещения: " 
                //+ row[6].ToString();
                listBox.Items.Add(order);
            }

            conn.Close();
        }

    }
}
