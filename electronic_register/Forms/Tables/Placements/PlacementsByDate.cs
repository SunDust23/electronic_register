using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electronic_register
{
    internal class PlacementsByDate
    {

        private string division;
        private string roomNum;
        private DateTime date;
        private double square;

        public string Division { get => division; set => division = value; }
        public string RoomNum { get => roomNum; set => roomNum = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Square { get => square; set => square = value; }

        public PlacementsByDate(string division, string roomNum, double square, DateTime date)
        {
            this.roomNum = roomNum;
            this.division = division;
            this.date = date;
            this.square = square;
        }

        public PlacementsByDate(string division, string roomNum, double square)
        {
            this.division = division;
            this.roomNum = roomNum;
            this.square = square;
        }
    }
}
