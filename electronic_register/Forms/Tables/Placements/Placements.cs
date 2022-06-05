using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;

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
            getPlacementsByDate();

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




        private void getPlacementsByDate()
        {

            List<PlacementsByDate> placementsByDate = new List<PlacementsByDate>();
            List<PlacementsByDate> changesFromOrders = new List<PlacementsByDate>();

            DateTime selectedDate = dateTimePicker2.Value;

            conn.Open();
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(Scripts.Select.SelectFirstPlacementsDivision, conn);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);


            foreach (DataRow row in table.Rows)
            {
                PlacementsByDate pbd = new PlacementsByDate(row["Подразделение"].ToString(), row["Помещения"].ToString(), Convert.ToDouble(row["Площадь"]));
                placementsByDate.Add(pbd);
            }

            string query = "SELECT name as Подразделениe, GROUP_CONCAT( roomNum SEPARATOR ', ') as Помещения, sum(square) as Площадь,  MAX(date) FROM orders " +
                 "INNER JOIN divisions ON orders.divisionId = divisions.id " +
                 "JOIN placementsinorder ON placementsinorder.orderId = orders.id " +
                 "inner join placements on placementsinorder.placementId = placements.id " +
                 "inner join room on placements.roomId = room.id " +
                 "WHERE date < \"" + selectedDate.ToString("yyyy-MM-dd") + "\" group by name";

            MySqlDataAdapter mySql_dataAdapter2 = new MySqlDataAdapter(query, conn);
            DataTable orderTable = new DataTable();
            mySql_dataAdapter2.Fill(orderTable);

            foreach (DataRow row in orderTable.Rows)
            {
                PlacementsByDate pbd = new PlacementsByDate(row["Подразделениe"].ToString(), row["Помещения"].ToString(), Convert.ToDouble(row["Площадь"]), Convert.ToDateTime(row["MAX(date)"]));
                changesFromOrders.Add(pbd);
            }

            foreach (PlacementsByDate cfo in changesFromOrders)
            {
                //string newRoom = cfo.RoomNum.ToString();
                var newRoom = cfo.RoomNum.Split(',').Select(x => x.Trim()).ToArray();

                for (int i = 0; i < placementsByDate.Count; i++)
                {
                    string roomStr = placementsByDate[i].RoomNum.ToString();

                    //if (roomStr.Contains(newRoom))
                    //{
                    //    var roomArray = placementsByDate[i].RoomNum.Split(',').Select(x => x.Trim()).ToArray();

                    //    var str = string.Join(", ", roomArray.Where(x => x != newRoom).ToList());
                    //    placementsByDate[i].Square -= cfo.Square;

                    //    placementsByDate[i].RoomNum = str;
                    //}
                    foreach (string room in newRoom)
                    {
                        int roomSquare = 0;
                        for (int j = 0; j < dataGridView1.Rows.Count; j++)
                        {
                            if (room == dataGridView1.Rows[j].Cells["Комната"].Value.ToString())
                            {
                                roomSquare = Convert.ToInt32(dataGridView1.Rows[j].Cells["Площадь"].Value);
                            }

                        }

                        if (roomStr.Contains(room))
                        {
                            var roomArray = placementsByDate[i].RoomNum.Split(',').Select(x => x.Trim()).ToArray();

                            var str = string.Join(", ", roomArray.Where(x => x != room).ToList());


                            placementsByDate[i].Square -= roomSquare;

                            placementsByDate[i].RoomNum = str;
                        }

                        if (placementsByDate[i].Division == cfo.Division)
                        {
                            placementsByDate[i].RoomNum += ", ";
                            placementsByDate[i].RoomNum += room;
                            placementsByDate[i].Square += roomSquare;
                        }
                    }
                   
                }
            }

            dataGridView2.DataSource = placementsByDate;

            dataGridView2.Columns[2].Visible = false;

            conn.Close();
        }




        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            getPlacementsByDate();
        }
    }
}
