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
    public partial class Divisions : Form
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        public AddDivision DivisionsAdd;
        FillForms fillForms = new FillForms();
        ChangeTables changeTables = new ChangeTables();

        public int updatedId;
        public string actionName;
        //public DataGridViewRow row;

        public Divisions()
        {
            InitializeComponent();

            updateTables();
            dataGridView1.Columns[0].Visible = false;
        }

        public void updateTables()
        {
            fillForms.FillTable(Scripts.Select.SelectDivision, dataGridView1);
            fillForms.FillTable(Scripts.Select.SelectDivisionHierarchy, dataGridView_levels);
            fillHierarchy(Scripts.Select.SelectDivisions, treeView1);
        }

        private void fillHierarchy(string script, System.Windows.Forms.TreeView treeView)
        {
            conn.Open();
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, conn);
            DataTable dtTree = new DataTable();

            mySql_dataAdapter.Fill(dtTree);

            mySql_dataAdapter.Dispose();
            treeView.BeginUpdate();
            treeView.Nodes.Clear();

            foreach (DataRow dr in dtTree.Rows)
            {
                if (dr["divisionId"].ToString() == "")
                {
                    TreeNode newNode = new TreeNode(dr["name"].ToString());
                    int parentId = Convert.ToInt32(dr["id"]);
                    createTreeNode(newNode, dtTree, parentId);
                    treeView.Nodes.Add(newNode);
                }
                
            }
            treeView.Nodes[0].Expand();
            treeView.Select();
            treeView.EndUpdate();

            conn.Close();
        }

        private void createTreeNode(TreeNode treeNode, DataTable dtTree, int parentId)
        {
            foreach (DataRow dr in dtTree.Rows)
            {
                if(dr["divisionId"].ToString() == parentId.ToString())
                {
                    TreeNode newNode = new TreeNode(dr["name"].ToString());
                    parentId = Convert.ToInt32(dr["id"]);
                    treeNode.Nodes.Add(newNode);
                    createTreeNode(newNode, dtTree, parentId);
                   
                }
                
            }

        }





        private void button1_Click(object sender, EventArgs e)
        {
            DivisionsAdd = new AddDivision()
            {
                Tag = this
            };
            DivisionsAdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updatedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DivisionsAdd = new AddDivision(updatedId)
            {
                Tag = this
            };
            DivisionsAdd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeTables.deleteFromTable(
                Scripts.Delete.DeleteDivision,
                Scripts.Select.SelectDivision,
                dataGridView1);
            updateTables();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_selectedId.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
        }

        //protected void CreateTreeView(TreeNode treeNode, int parentID, DataTable mytab)
        //{

        //    foreach (DataRow data in mytab.Rows)
        //    {
        //        try
        //        {
        //            if (Convert.ToInt32(data["divisionId"]) == parentID)
        //            {
        //                String key = data["id"].ToString();
        //                String text = data["name"].ToString();

        //                treeNode.Nodes.Add(key, text);
        //                CreateTreeView(treeNode, Convert.ToInt32(data["id"]), mytab);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }

        //}

    }
}
