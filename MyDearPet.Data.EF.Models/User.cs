using MyDearPet.Data.EF.Models.Enums;

namespace MyDearPet.Data.EF.Models
{
    public class User : BaseEntity<int>
    {
        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public int RoleId { get; set; }

        public string ProfilePictureUrl { get; set; }
    }
}
