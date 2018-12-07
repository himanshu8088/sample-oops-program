namespace BookStore.Models
{
    public class Address
    {
        public string City { get; set; }
        public string State { get; set; }
        public int Pincode{ get; set; }
        public string Country { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
    }

    public class Reciept
    {
        public Reciept(int number)
        {
            Number = number;
        }
        public int Number { get; }
        public int ItemQuantity { get; set; }
        public decimal TotalBill { get; set; }
    }
}
