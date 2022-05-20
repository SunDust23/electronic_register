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
        public Divisions()
        {
            InitializeComponent();

            fillForms.FillTable(Scripts.Select.SelectDivision, dataGridView1);
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

            int parentId = 1;
          //  CreateTreeView(treeView, 0, dtTree);

            foreach (DataRow dr in dtTree.Rows)
            {
                //TreeNode childNode = new TreeNode(dr["name"].ToString());

                //treeView.SelectedNode.Nodes.Add(childNode);
                if (Convert.ToInt32(dr["divisionId"]) == parentId)
                {
                String key = dr["id"].ToString();
                String text = dr["name"].ToString();

                treeView.Nodes.Add(key, text);

                    parentId = Convert.ToInt32(dr["id"]);
                //if (Convert.ToInt32(dr["divisionId"]) == Convert.ToInt32(dr["id"]))
                //   // CreateTreeView(treeView, Convert.ToInt32(dr["id"]), dtTree);
                }
            }
            treeView.Nodes[0].Expand();
            treeView.Select();
            treeView.EndUpdate();

            conn.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            DivisionsAdd = new AddDivision
            {
                Tag = this
            };
            DivisionsAdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DivisionsAdd = new AddDivision
            {
                Tag = this
            };
            DivisionsAdd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
