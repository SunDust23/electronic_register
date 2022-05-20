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
    public partial class AddDivision : Form
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        FillForms fillForms = new FillForms();

        public AddDivision()
        {
            InitializeComponent();

            fillForms.FillComboBox(Scripts.Select.SelectDivisions, "name", "id", comboBox_division);
            conn.Open();
            comboBox_division.SelectedItem = null;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string shortName = textBox_shortName.Text;
            string genetiveCase = textBox_genetiveCase.Text;
            string dativeCase = textBox_dativeCase.Text;
            int divisionId = Convert.ToInt32(comboBox_division.SelectedValue);
            int companyId = 1;

            MySqlCommand command;
            if (comboBox_division.SelectedItem == null)
            {
                 command = new MySqlCommand(Scripts.Insert.InsertMainDivision, conn);
            }
            else
            {
                 command = new MySqlCommand(Scripts.Insert.InsertDivision, conn);
                 command.Parameters.AddWithValue("@divisionId", divisionId);
            }
           
            


            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@shortName", shortName);
            command.Parameters.AddWithValue("@genetiveCase", genetiveCase);
            command.Parameters.AddWithValue("@dativeCase", dativeCase);
            
            command.Parameters.AddWithValue("@companyId", companyId);

            // выполняем запрос
            command.ExecuteNonQuery();

            ((Divisions)this.Tag).updateTables();

            this.Close();
            conn.Close();
        }
    }
}
