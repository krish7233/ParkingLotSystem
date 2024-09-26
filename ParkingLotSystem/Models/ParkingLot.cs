using ParkingLotSystem.Enums;

namespace ParkingLotSystem.Models
{
    public class ParkingLot
    {
        public int Id { get; set; }

        public List<ParkingFloor> ParkingFloors { get; set; }

        public Status Status { get; set; }

        public String Name { get; set; }



    }
}
