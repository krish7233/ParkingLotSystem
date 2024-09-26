namespace ParkingLotSystem.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime EntryTime { get; set; }
        public Vehicle VehicleInfo { get; set; }

    }
}
