using System;
using System.Collections.Generic;
using MyDearPet.Data.EF.Models.Enums;

namespace MyDearPet.Data.EF.Models
{
    public class Pet: BaseEntity<int>
    {
        public Pet()
        {
            Gender = Gender.Female;
        }

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int ShelterId { get; set; }

        public int CuratorId { get; set; }

        public virtual Shelter Shelter { get; set; }

        public virtual User Curator { get; set; }

        public virtual ICollection<Media> Media { get; set; } 
    }
}
