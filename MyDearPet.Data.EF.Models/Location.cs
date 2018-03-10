namespace MyDearPet.Data.EF.Models
{
    public class Location : BaseEntity<int>
    {
        public string Name { get; set; }

        public string CountryCode { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string PostalCode { get; set; }

        public string PhoneNumber { get; set; }
    }
}
