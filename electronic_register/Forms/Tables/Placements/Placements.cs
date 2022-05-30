using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace electronic_register
{
    public partial class Placements : Form
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        public AddPlacement PlacementAdd;
        FillForms fillForms = new FillForms();
        ChangeTables changeTables = new ChangeTables();

        public int updatedId;

        public Placements()
        {
            InitializeComponent();
            updateTables();
            dataGridView1.Columns[0].Visible = false;

            chart.ChartAreas[0].Axes[0].Title = "Подразделения";

            chart.ChartAreas[0].Axes[1].Title = "Площадь";
            drawChart();

        }

        public void updateTables()
        {
            fillForms.FillTable(Scripts.Select.SelectPlacement, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlacementAdd = new AddPlacement()
            {
                Tag = this
            };
            PlacementAdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            updatedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PlacementAdd = new AddPlacement(updatedId)
            {
                Tag = this
            };
            PlacementAdd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeTables.deleteFromTable(
                Scripts.Delete.DeletePlacement,
                Scripts.Select.SelectPlacement,
                dataGridView1);
            updateTables();
        }

        private void drawChart()
        {
            conn.Open();
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(Scripts.Select.SelectDivisionsSquare, conn);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);
            int ChartId = 0;
            foreach (DataRow row in table.Rows)
            {
                chart.Series.Add(row["name"].ToString());
                //chart.Series[ChartId].XValueType = ChartValueType.Date;
                //chart.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy";
                ////chart.ChartAreas[0].AxisX.Interval = 0.1;
                //chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Years;
                ////chart.ChartAreas[0].AxisX.IntervalOffset = 1;

                //// dateTimePicker1.Value.ToShortDateString()
                chart.Series[ChartId].Points.Add(Convert.ToInt32(row["squareSum"]));
                ChartId++;
            }

            conn.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            chart.Series.Clear();
            drawChart();
        }
    }
}
