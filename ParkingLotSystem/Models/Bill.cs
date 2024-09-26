namespace ParkingLotSystem.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public Payment PaymentInfo { get; set; }

        public Vehicle VehicleInfo { get; set; }

        public DateTime ExitTime { get; set; }

    }
}
