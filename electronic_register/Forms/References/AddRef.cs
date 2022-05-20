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

        public AddRef(System.Windows.Forms.TabPage selectedTab, string actionName, string updatedName)
        { 
            InitializeComponent();
            conn.Open();
            
            labelAction.Text = actionName;
            groupBox1.Text = Convert.ToString(selectedTab.Text);

            textBox_name.Text = updatedName; 

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

            int id = ((StaticReferences)this.Tag).updatedId;

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);

            command.ExecuteNonQuery();

            ((StaticReferences)this.Tag).updateTables();
            conn.Close();
            

            this.Close();
        }
    }
}
