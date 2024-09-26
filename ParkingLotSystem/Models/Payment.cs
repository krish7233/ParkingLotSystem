using ParkingLotSystem.Enums;

namespace ParkingLotSystem.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public double Amount { get; set; }
        public string ReferenceId {  get; set; }
    }
}
