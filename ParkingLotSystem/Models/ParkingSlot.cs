using ParkingLotSystem.Enums;

namespace ParkingLotSystem.Models
{
    public class ParkingSlot
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public Status Status { get; set; }
        public Vehicle Vehicle { get; set; } = new Vehicle();
    }
}
