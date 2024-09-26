using ParkingLotSystem.Enums;

namespace ParkingLotSystem.Models
{
    public class ParkingFloor
    {
        public int Id { get; set; }
        public List<ParkingSlot> ParkingSlots { get; set; } = new List<ParkingSlot>();
        public Status Status { get; set; }
    }
}
