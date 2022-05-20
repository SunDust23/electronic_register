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

    }
}
