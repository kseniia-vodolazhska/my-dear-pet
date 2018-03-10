using System.Collections.Generic;

namespace MyDearPet.Data.EF.Models
{
    public class Shelter : BaseEntity<int>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int OwnerId { get; set; }

        public User Owner { get; set; }

        public virtual Location Location { get; set; }

        public virtual ICollection<Media> Media { get; set; }
    }
}
