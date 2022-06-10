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

        private int _editId;
        private bool _isEdit = false;

        DbContext _context;
        public AddPlacement()
        {
            InitializeComponent();
            _context = new DbContext();
            fillForms.FillComboBox(Scripts.Select.SelectDivisions, "name", "id", comboBox_division);
            fillForms.FillComboBox(Scripts.Select.SelectPlacementType, "Название", "Код", comboBox_type);
            conn.Open();
            InitCombo();
        }

        public AddPlacement(int id)
        {
            InitializeComponent();

            _isEdit = true;
            _editId = id;

            var query = $"Select * From Divisions Where id != {_editId}";
            _context = new DbContext();
            fillForms.FillComboBox(Scripts.Select.SelectDivisions, "name", "id", comboBox_division);
            fillForms.FillComboBox(Scripts.Select.SelectPlacementType, "Название", "Код", comboBox_type);
            conn.Open();
            InitCombo();
            InitEditInfo();
        }

        public void InitCombo()
        {
            comboBox_block.DataSource = _context.Blocks;
            comboBox_block.DisplayMember = "Num";
            comboBox_block.ValueMember = "Id";
            comboBox_block.SelectedValue = _context.Blocks[0].Id;

            comboBox_floor.DataSource = _context.Blocks[0].Floors;
            comboBox_floor.DisplayMember = "Num";
            comboBox_floor.ValueMember = "Id";
            comboBox_floor.SelectedValue = _context.Blocks[0].Floors[0].Id;

            comboBox_room.DataSource = _context.Blocks[0].Floors[0].Rooms;
            comboBox_room.DisplayMember = "Num";
            comboBox_room.ValueMember = "Id";
        }

        private void InitEditInfo()
        {
            string query = $"Select * From Placements Where id = {_editId}";

            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);

            if (table.Rows.Count < 1) MessageBox.Show("Ошибка, запись не найдена", "Ошибка");

            var data = table.Rows[0];
            comboBox_division.SelectedValue = int.Parse(data["divisionId"].ToString());
            comboBox_type.SelectedValue = int.Parse(data["typeId"].ToString());
            textBox_square.Text = data["square"].ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int divisionId = int.Parse(comboBox_division.SelectedValue.ToString());
            int typeId = int.Parse(comboBox_type.SelectedValue.ToString());
            int roomId = int.Parse(comboBox_room.SelectedValue.ToString());
            double square = Convert.ToDouble(textBox_square.Text);

            int id = ((Placements)this.Tag).updatedId;

            string query;
            if (_isEdit)
            {
                query = Scripts.Update.UpdatePlacement;
            }
            else
            {
                query = Scripts.Insert.InsertPlacement;
            }

            MySqlCommand command = new MySqlCommand(query, conn);

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@square", square);
            command.Parameters.AddWithValue("@roomId", roomId);
            command.Parameters.AddWithValue("@divisionId", divisionId);
            command.Parameters.AddWithValue("@typeId", typeId);

            // выполняем запрос
            command.ExecuteNonQuery();

            ((Placements)this.Tag).updateTables();

            this.Close();
            conn.Close();
        }

        private void comboBox_block_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_block.SelectedIndex < 1) return;
            var blockId = int.Parse(comboBox_block.SelectedValue.ToString());

            var floors = _context.Blocks.First(x => x.Id == blockId).Floors;
            comboBox_floor.DataSource = floors;
            comboBox_floor.DisplayMember = "Num";
            comboBox_floor.ValueMember = "Id";
            comboBox_floor.SelectedValue = floors[0].Id;

            comboBox_room.DataSource = floors[0].Rooms;
            comboBox_room.DisplayMember = "Num";
            comboBox_room.ValueMember = "Id";
        }

        private void comboBox_floor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_floor.SelectedIndex < 1) return;
            var floorId = int.Parse(comboBox_floor.SelectedValue.ToString());

            var floor = _context.Floors.First(x => x.Id == floorId);

            comboBox_room.DataSource = floor.Rooms;
            comboBox_room.DisplayMember = "Num";
            comboBox_room.ValueMember = "Id";
        }

        private void comboBox_room_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }

}
