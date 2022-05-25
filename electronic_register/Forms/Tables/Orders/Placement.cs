using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electronic_register
{
    internal class Placement
    {
        private int id;
        private int roomNum;

        public int Id { get => id; set => id = value; }
        public int RoomNum { get => roomNum; set => roomNum = value; }

        public Placement(int id, int roomNum)
        {
            this.id = id;
            this.roomNum = roomNum;
        }
    }
}
