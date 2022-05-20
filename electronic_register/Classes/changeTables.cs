using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace electronic_register
{
    internal class ChangeTables
    {
        readonly MySqlConnection conn = DBUtils.GetDBConnection();
        FillForms fillForms = new FillForms();


        public void InsertIntoTable(string InsertQuery, string SelectQuery, System.Windows.Forms.DataGridView dataGridView)
        {
        }

        public void UpdateTable(string UpdateQuery, string SelectQuery, System.Windows.Forms.DataGridView dataGridView)
        {
        }

        public void deleteFromTable(string DeleteQuery, string SelectQuery, System.Windows.Forms.DataGridView dataGridView)
        {
            int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);

            conn.Open();
            MySqlCommand command = new MySqlCommand(DeleteQuery, conn);
            command.Parameters.AddWithValue("@id", id);

            // выполняем запрос
            command.ExecuteNonQuery();
            // закрываем подключение к БД
            fillForms.FillTable(SelectQuery, dataGridView);
            conn.Close();
        }
    }
}
