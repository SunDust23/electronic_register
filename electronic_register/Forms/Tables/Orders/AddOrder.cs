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
    public partial class AddOrder : Form
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        private List<Placement> _AllPlacements = new List<Placement>();
        private List<Placement> _AddedPlacements = new List<Placement>();
        FillForms fillForms = new FillForms();

        //private int _editId;
        //private bool _isEdit = false;

        public AddOrder()
        {
            InitializeComponent();
            FillList(Scripts.Select.SelectRoom, _AllPlacements, listBox_AllPlacements);
            fillForms.FillComboBox(Scripts.Select.SelectDivisions, "name", "id", comboBox_division);
            fillForms.FillComboBox(Scripts.Select.SelectActionType, "name", "id", comboBox_action);
            conn.Open();

          
            listBox_addPlacement.DisplayMember = "RoomNum";
            listBox_addPlacement.ValueMember = "Id";
        }

        //public AddOrder(int id)
        //{
        //    InitializeComponent();

        //    _isEdit = true;
        //    _editId = id;

        //    FillList(Scripts.Select.SelectRoom, _AllPlacements, listBox_AllPlacements);
        //    fillForms.FillComboBox(Scripts.Select.SelectDivisions, "name", "id", comboBox_division);
        //    fillForms.FillComboBox(Scripts.Select.SelectActionType, "name", "id", comboBox_action);
        //    conn.Open();

        //    InitEditInfo();
        //}
        //private void InitEditInfo()
        //{
        //    string query = $"Select * From Orders Where id = {_editId}";

        //    MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(query, conn);
        //    DataTable table = new DataTable();
        //    mySql_dataAdapter.Fill(table);

        //    if (table.Rows.Count < 1) MessageBox.Show("Ошибка, запись не найдена", "Ошибка");

        //    var data = table.Rows[0];
        //    textBox_orderNum.Text = data["orderNum"].ToString();
        //    dateTimePicker_date.Value = Convert.ToDateTime(data["date"]);
        //    dateTimePicker_validity.Value = Convert.ToDateTime(data["validity"]);


        //    var divisionId = data["divisionId"].ToString();
        //    var typeId = data["typeId"].ToString();

        //    comboBox_division.SelectedValue = int.Parse(divisionId);
        //    comboBox_action.SelectedValue = int.Parse(typeId);

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            int orderNum = Convert.ToInt32(textBox_orderNum.Text);
            int typeId = Convert.ToInt32(comboBox_action.SelectedValue);
            DateTime date = dateTimePicker_date.Value;
            DateTime validity = dateTimePicker_validity.Value;
            int divisionId = Convert.ToInt32(comboBox_division.SelectedValue);

            //string query_order = Scripts.Insert.InsertOrder;
            //string query_placements = Scripts.Insert.InsertPlacementInOrder;

            //if (_isEdit)
            //{
            //    query_order = Scripts.Update.UpdateOrder;
            //    query_placements = Scripts.Update.UpdatePlacementInOrder;
            //}
            //else
            //{
            //query_order = Scripts.Insert.InsertOrder;
            //query_placements = Scripts.Insert.InsertPlacementInOrder;
            //}

            MySqlCommand command = new MySqlCommand(Scripts.Insert.InsertOrder, conn);


            //command.Parameters.AddWithValue("@id", _editId);
            command.Parameters.AddWithValue("@orderNum", orderNum);
            command.Parameters.AddWithValue("@typeId", typeId);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@validity", validity);
            command.Parameters.AddWithValue("@divisionId", divisionId);

            command.ExecuteNonQuery();

            string query_getOrderByNum = "SELECT * FROM Orders WHERE orderNum = " + orderNum;

            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(query_getOrderByNum, conn);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);

            int orderId;
            int divId;
            foreach (DataRow row in table.Rows)
            {
                orderId = Convert.ToInt32(row[0]);
                divId = Convert.ToInt32(row[5]);

                foreach (Placement placement in _AddedPlacements)
                {
                    int pId = placement.Id;
                    MySqlCommand command2 = new MySqlCommand(Scripts.Insert.InsertPlacementInOrder, conn);
                    command2.Parameters.AddWithValue("@orderId", orderId);
                    command2.Parameters.AddWithValue("@placementId", pId);
                    command2.ExecuteNonQuery();

                    MySqlCommand command3 = new MySqlCommand(Scripts.Update.UpdatePlacementByOrder, conn);
                    command3.Parameters.AddWithValue("@divisionId", divId);
                    command3.Parameters.AddWithValue("@id", pId);
                    command3.ExecuteNonQuery();
                }
            }



            ((Order)this.Tag).updateTables();

            this.Close();
            conn.Close();
        }

        private void addPlacementbutton_Click(object sender, EventArgs e)
        {
            if (listBox_AllPlacements.SelectedItem != null)
            {
                //Placement place = new Placement(Convert.ToInt32(listBox_AllPlacements.SelectedValue), Convert.ToInt32(listBox_AllPlacements.SelectedItem));
                Placement place = (Placement)(listBox_AllPlacements.SelectedItem);

                _AddedPlacements.Add(place);
                listBox_addPlacement.Items.Add(place);
                _AllPlacements.Remove(place);
                listBox_AllPlacements.Items.Remove(listBox_AllPlacements.SelectedItem);
            }

        }

        private void delPlacementButton_Click(object sender, EventArgs e)
        {
            if (listBox_addPlacement.SelectedItem != null)
            {
                Placement place = (Placement)(listBox_addPlacement.SelectedItem);

                _AddedPlacements.Remove(place);
                _AllPlacements.Add(place);

                listBox_AllPlacements.Items.Add(place);
                listBox_addPlacement.Items.Remove(listBox_addPlacement.SelectedItem);
            }
        }


        //System.Windows.Forms.ListBox listBox
        void FillList(string script, List<Placement> list, System.Windows.Forms.ListBox listBox)
        {
            conn.Open();
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, conn);
            DataTable table = new DataTable();

            mySql_dataAdapter.Fill(table);

            Placement place;

            foreach (DataRow row in table.Rows)
            {
                place = new Placement(Convert.ToInt32(row[0]), Convert.ToInt32(row[1]));
                list.Add(place);
                listBox.Items.Add(place);
            }

            listBox.DisplayMember = "RoomNum";
            listBox.ValueMember = "Id";

            conn.Close();
        }

    }
}
