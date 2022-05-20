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
    public partial class AddRef : Form
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        string query;

        public AddRef(System.Windows.Forms.TabPage selectedTab, string actionName)
        { 
            InitializeComponent();
            conn.Open();
            
            labelAction.Text = actionName;
            groupBox1.Text = Convert.ToString(selectedTab.Text);
            chooseQuery(selectedTab, actionName);
        }

        private void chooseQuery(System.Windows.Forms.TabPage selectedTab, string actionName)
        { 
            switch (selectedTab.Text)
            {
                case "Тип помещения":
                    if (actionName == "Добавление")
                    {
                        query = Scripts.Insert.InsertPlacementType;
                    }
                    if (actionName == "Редактирование")
                    {
                        query = Scripts.Update.UpdatePlacementType;
                        //command.Parameters.AddWithValue("@id", id);
                    }
                    break;

                case "Тип действия приказа":
                    if (actionName == "Добавление")
                    {
                        query = Scripts.Insert.InsertActionType;
                    }
                    if (actionName == "Редактирование")
                    {
                        query = Scripts.Update.UpdateActionType;
                    }
                    break;
            }  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            MySqlCommand command = new MySqlCommand(query, conn);

            command.Parameters.AddWithValue("@name", name);

            command.ExecuteNonQuery();

            this.Close();
            conn.Close();
        }
    }
}
