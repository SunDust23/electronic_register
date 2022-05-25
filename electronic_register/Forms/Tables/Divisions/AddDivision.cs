using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace electronic_register
{
    public partial class AddDivision : Form
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        FillForms fillForms = new FillForms();

        private int _editId;
        private bool _isEdit = false;

        /// <summary>
        /// Добавление
        /// </summary>
        public AddDivision()
        {
            InitializeComponent();

            fillForms.FillComboBox(Scripts.Select.SelectDivisions, "name", "id", comboBox_division);
            conn.Open();
            comboBox_division.SelectedItem = null;
            //fillWinFormsList(row);
        }

        /// <summary>
        /// Редактирование
        /// </summary>
        /// <param name="id">Ид редактируемого</param>
        public AddDivision(int id) 
        {
            InitializeComponent();

            _isEdit = true;
            _editId = id;

            var query = $"Select * From Divisions Where id != {_editId}";
            fillForms.FillComboBox(query, "name", "id", comboBox_division);
            
            conn.Open();

            comboBox_division.SelectedItem = null;
            InitEditInfo();
        }

        /// <summary>
        /// Забить данными поля при редачестве
        /// </summary>
        private void InitEditInfo()
        {
            string query = $"Select * From Divisions Where id = {_editId}";

            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);

            if (table.Rows.Count < 1) MessageBox.Show("Ошибка, запись не найдена", "Ошибка");

            var divisionData = table.Rows[0];
            textBox_name.Text = divisionData["name"].ToString();
            textBox_shortName.Text = divisionData["shortName"].ToString();
            textBox_genetiveCase.Text = divisionData["genetiveCase"].ToString();
            textBox_dativeCase.Text = divisionData["dativeCase"].ToString();

            var divisionId = divisionData["divisionId"].ToString();
            if (!String.IsNullOrEmpty(divisionId))
                comboBox_division.SelectedValue = int.Parse(divisionId);

            comboBox_division.Items.Remove(int.Parse(divisionData["id"].ToString()));
        }


        //private void Save()
        //{
        //    if (!_isEdit)
        //    {

        //    }
        //    else
        //    {

        //    }
        //}

        private string ChooseQuery()
        {
            if (comboBox_division.SelectedItem == null)
            {
                if (_isEdit)
                {
                    return Scripts.Update.UpdateMainDivision; 
                }
                else 
                {
                    return Scripts.Insert.InsertMainDivision;
                }
            }
            else
            {
                if (_isEdit)
                {
                    return Scripts.Update.UpdateDivision;
                }
                else
                {
                    return Scripts.Insert.InsertDivision;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string shortName = textBox_shortName.Text;
            string genetiveCase = textBox_genetiveCase.Text;
            string dativeCase = textBox_dativeCase.Text;
            int divisionId = Convert.ToInt32(comboBox_division.SelectedValue);
            int companyId = 1;

            string query = ChooseQuery();

            MySqlCommand command = new MySqlCommand(query, conn);
            if (comboBox_division.SelectedItem != null)
            {
                command.Parameters.AddWithValue("@divisionId", divisionId);
            }

            int id = ((Divisions)this.Tag).updatedId; 

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@shortName", shortName);
            command.Parameters.AddWithValue("@genetiveCase", genetiveCase);
            command.Parameters.AddWithValue("@dativeCase", dativeCase);

            command.Parameters.AddWithValue("@companyId", companyId);

            command.ExecuteNonQuery();

            ((Divisions)this.Tag).updateTables();

            this.Close();
            conn.Close();
        }
    }
}
