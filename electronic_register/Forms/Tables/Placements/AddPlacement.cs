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
    public partial class AddPlacement : Form
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        FillForms fillForms = new FillForms();
        public AddPlacement()
        {
            InitializeComponent();
            fillForms.FillComboBox(Scripts.Select.SelectDivisions, "name", "id", comboBox_division);
            fillForms.FillComboBox(Scripts.Select.SelectPlacementType, "name", "id", comboBox_type);
            fillForms.FillComboBox(Scripts.Select.SelectBlock, "blockNum", "id", comboBox_block);
            fillForms.FillComboBox(Scripts.Select.SelectFloor, "floorNum", "id", comboBox_floor);
            fillForms.FillComboBox(Scripts.Select.SelectRoom, "roomNum", "id", comboBox_room);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int divisionId = Convert.ToInt32(comboBox_division.SelectedValue);
            int typeId = Convert.ToInt32(comboBox_type.SelectedValue);
            int roomId = Convert.ToInt32(comboBox_room.SelectedValue);
            double square = Convert.ToDouble(textBox_square.Text);

            MySqlCommand command = new MySqlCommand(Scripts.Insert.InsertPlacement, conn);

            command.Parameters.AddWithValue("@square", square);
            command.Parameters.AddWithValue("@roomId", roomId);
            command.Parameters.AddWithValue("@divisionId", divisionId);
            command.Parameters.AddWithValue("@typeId", typeId);

            // выполняем запрос
            command.ExecuteNonQuery();

            this.Close();
            conn.Close();
        }
    }
}
