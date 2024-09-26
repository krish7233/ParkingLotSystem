using ParkingLotSystem.Enums;

namespace ParkingLotSystem.Models
{
    public class Gate
    {
        public int Id { get; set; }
        public Operator Operator { get; set; }
        public GateType GateType { get; set; }
    }
}
