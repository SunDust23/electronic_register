using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace electronic_register
{
    public class DbContext
    {
        MySqlConnection conn = DBUtils.GetDBConnection();

        public DbContext()
        {
            PlacementViews = new List<PlacementView>(16);
            conn.Open();
            var query = "Select * From placementsview";
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);
            conn.Close();
            Blocks = new List<Block>();
            Floors = new List<Floor>();
            Rooms = new List<Room>();

            foreach (DataRow row in table.Rows)
            {
                var place = new PlacementView
                {
                    BlockId = int.Parse(row["blockId"].ToString()),
                    BlockNum = int.Parse(row["blockNum"].ToString()),
                    FloorId = int.Parse(row["floorId"].ToString()),
                    FloorNum = int.Parse(row["floorNum"].ToString()),
                    RoomId = int.Parse(row["roomId"].ToString()),
                    RoomNum = int.Parse(row["roomNum"].ToString()),
                };
                PlacementViews.Add(place);

                var block = Blocks.FirstOrDefault(x => x.Id == place.BlockId);
                if (block == null)
                {
                    Blocks.Add(new Block
                    {
                        Id = place.BlockId,
                        Num = place.BlockNum
                    });
                }

                var floor = Floors.FirstOrDefault(x => x.Id == place.FloorId);
                if (floor == null)
                {
                    Floors.Add(new Floor
                    {
                        BlockId = place.BlockId,
                        Id = place.FloorId,
                        Num = place.FloorNum
                    });
                }

                var room = Rooms.FirstOrDefault(x => x.Id == place.RoomId);
                if (room == null)
                {
                    Rooms.Add(new Room
                    {
                        FloorId = place.FloorId,
                        Id = place.RoomId,
                        Num = place.RoomNum
                    });
                }
            }

            foreach (var floor in Floors)
            {
                floor.Rooms = Rooms.Where(room => room.FloorId == floor.Id).ToList();
            }

            foreach (var block in Blocks)
            {
                block.Floors = Floors.Where(floor => floor.BlockId == block.Id).ToList();
            }
        }


        public List<PlacementView> PlacementViews { get; set; }
        public List<Block> Blocks { get; set; }
        public List<Floor> Floors { get; set; }
        public List<Room> Rooms { get; set; }
    }

    public class PlacementView
    {
        public int BlockId { get; set; }
        public int BlockNum { get; set; }
        public int FloorId { get; set; }
        public int FloorNum { get; set; }
        public int RoomId { get; set; }
        public int RoomNum { get; set; }

    }

    public class Block
    {
        public int Id { get; set; }
        public int Num { get; set; }

        public List<Floor> Floors { get; set; }
    }

    public class Floor
    {
        public int Id { get; set; }
        public int Num { get; set; }
        public int BlockId { get; set; }

        public List<Room> Rooms { get; set; }  
    }

    public class Room
    {
        public int Id { get; set; }
        public int Num { get; set; }

        public int FloorId { get; set; }
    }
}
