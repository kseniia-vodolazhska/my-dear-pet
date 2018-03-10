namespace MyDearPet.Data.EF.Models
{
    public enum MediaType
    {
        Image,
        Video
    }

    public class Media : BaseEntity<int>
    {
        public MediaType Type { get; set; }

        public string Url { get; set; }
    }
}
