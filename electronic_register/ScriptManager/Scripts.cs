using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electronic_register
{
    internal class Scripts
    {
        public static class Insert
        {
            public static string InsertCompany =
                "INSERT INTO Company (name, shortName) VALUES (@name, @shortName)";
            public static string InsertDivision =
                "INSERT INTO Divisions (name, shortName, genetiveCase, dativeCase, divisionId, companyId) VALUES (@name, @shortName, @genetiveCase, @dativeCase, @divisionId, @companyId)";
            public static string InsertMainDivision =
               "INSERT INTO Divisions (name, shortName, genetiveCase, dativeCase, companyId) VALUES (@name, @shortName, @genetiveCase, @dativeCase, @companyId)";

            public static string InsertPlacement =
                "INSERT INTO Placements (divisionId, typeId, roomID, square) VALUES (@divisionId, @typeId, @roomID, @square)";
            public static string InsertOrder =
                "INSERT INTO Order (orderNum, typeId, date, validity, divisionId) VALUES (@orderNum, @typeId, @date, @validity, @divisionId)";
            public static string InsertActionType =
                "INSERT INTO ActionType (name) VALUES (@name)";
            public static string InsertPlacementType =
                "INSERT INTO PlacementType (name) VALUES (@name)";
            public static string InsertPlacementInOrder =
                "INSERT INTO PlacementsInOrder (orderId, placementId) VALUES (@orderId, @placementId)";
            public static string InsertBlock =
                "INSERT INTO Block (blockNum) VALUES (@blockNum)";
            public static string InsertFloor =
                "INSERT INTO Floor (floorNum, blockId) VALUES (@floorNum, @blockId)";
            public static string InsertRoom =
                "INSERT INTO Room (roomNum, floorId) VALUES (@roomNum, @floorId)";
        }
        public static class Update
        {
            public static string UpdateCompany =
                "UPDATE Company SET name = @name, shortName = @shortName WHERE id = @id";
            public static string UpdateDivision =
                "UPDATE Divisions SET name = @name, shortName = @shortName, genetiveCase = @genetiveCase, dativeCase = @dativeCase, divisionId = @divisionId, companyId = @companyId WHERE id = @id";
            public static string UpdatePlacement =
                "UPDATE Placements SET divisionId = @divisionId, typeId = @typeId, roomID = @roomID, square = @square WHERE id = @id";
            public static string UpdateOrder =
                "UPDATE Order SET orderNum = @orderNum, typeId = @typeId, date = @date, validity = @validity, divisionId = @divisionId WHERE id = @id";
            public static string UpdateActionType =
                "UPDATE ActionType SET name = @name WHERE id = @id";
            public static string UpdatePlacementType =
                "UPDATE PlacementType SET name = @name WHERE id = @id";
            public static string UpdatePlacementInOrder =
                "UPDATE PlacementsInOrder SET orderId = @orderId, placementId = @placementId WHERE id = @id";
            public static string UpdateBlock =
                "UPDATE Block SET blockNum = @blockNum WHERE id = @id";
            public static string UpdateFloor =
                "UPDATE Floor SET floorNum = @floorNum, blockId = @blockId WHERE id = @id";
            public static string UpdateRoom =
                "UPDATE Room SET roomNum = @roomNum, floorId = @floorId WHERE id = @id";
        }
        public static class Delete
        {
            public static string DeleteCompany =
                "DELETE FROM Company WHERE id = @id";
            public static string DeleteDivision =
                "DELETE FROM Divisions WHERE id = @id";
            public static string DeletePlacement =
                "DELETE FROM Placements WHERE id = @id";
            public static string DeleteOrder =
                "DELETE FROM Order WHERE id = @id";
            public static string DeleteActionType =
                "DELETE FROM ActionType WHERE id = @id";
            public static string DeletePlacementType =
                "DELETE FROM PlacementType WHERE id = @id";
            public static string DeletePlacementInOrder =
                "DELETE FROM PlacementsInOrder WHERE id = @id";
            public static string DeleteBlock =
                "DELETE FROM Block WHERE id = @id";
            public static string DeleteFloor =
                "DELETE FROM Floor  WHERE id = @id";
            public static string DeleteRoom =
                "DELETE FROM Room WHERE id = @id";
        }
        public static class Select
        {
            public static string SelectCompany =
                "SELECT * FROM Company;";

            public static string SelectDivisions =
               "SELECT * FROM Divisions;";
            public static string SelectPlacements =
               "SELECT * FROM Placements;";
            //public static string SelectOrder =
            //   "SELECT * FROM Order;";
            public static string SelectActionType =
               "SELECT id as Код, name as Название FROM ActionType;";
            public static string SelectPlacementType =
               "SELECT id as Код, name as Название FROM PlacementType;";
            public static string SelectPlacementInOrder =
               "SELECT * FROM PlacementInOrder;";
            public static string SelectBlock =
               "SELECT * FROM Block;";
            public static string SelectFloor =
               "SELECT * FROM Floor;";
            public static string SelectRoom =
               "SELECT * FROM Room;";

            public static string SelectDivisionHierarchy =
                "SELECT t1.name AS lev1, t2.name as lev2, t3.name as lev3, t4.name as lev4 " +
                "FROM(divisions AS t1 " +
                "LEFT JOIN divisions AS t2 ON t2.divisionId = t1.id " +
                "LEFT JOIN divisions AS t3 ON t3.divisionId = t2.id " +
                "LEFT JOIN divisions AS t4 ON t4.divisionId = t3.id) " +
                "where t1.divisionId is null;";

            public const string SelectDivision =
                "SELECT t1.id as Код, t1.name as Название, t1.shortName as Краткое, " +
                "t1.genetiveCase as Родительный, t1.dativeCase as Дательный, " +
                "company.shortName AS Предприятие, t2.name AS Подразделение " +
                "FROM divisions as t1 inner join company ON t1.companyId = company.id " +
                "LEFT JOIN divisions AS t2 ON t2.divisionId = t1.id;";

            public static string SelectRoomByfloor =
                "SELECT blockNum, floorNum, roomNum FROM room " +
                "INNER JOIN floor ON room.floorId = floor.id " +
                "INNER JOIN block on floor.blockId = block.id";

            public static string SelectFloorByBlock =
                "SELECT floor.id, block.id, blockNum, floorNum FROM floor " +
                "INNER JOIN block on floor.blockId = block.id ";

            public static string SelectPlacement =
                "SELECT divisions.name as Division, placementtype.name as Type, blockNum, floorNum, roomNum, square FROM placements " +
                "inner join divisions on placements.divisionId = divisions.id " +
                "inner join placementtype on placements.typeId = placementtype.id " +
                "inner join room on placements.roomId = room.id " +
                "inner join floor on room.floorId = floor.id " +
                "inner join block on floor.blockId = block.id";

            public static string SelectOrders =
                "SELECT OrderNum, actionType.name, divisions.name, date, validity FROM orders " +
                "INNER JOIN actionType ON orders.typeId = actionType.id " +
                "INNER JOIN divisions ON orders.divisionId = divisions.id";

            public static string SelectPlacementsInOrder =
                "SELECT * FROM placementsinorder " +
                "INNER JOIN orders ON placementsinorder.orderId = orders.id " +
                "INNER JOIN placements ON placementsinorder.placementId = placements.id";
        }
    }
}
