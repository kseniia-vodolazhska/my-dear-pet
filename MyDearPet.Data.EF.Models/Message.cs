using System;

namespace MyDearPet.Data.EF.Models
{
    public class Message : BaseEntity<int>
    {
        public int SenderId { get; set; }

        public int RecepientId { get; set; }

        public string Text { get; set; }

        public DateTime MessageDate { get; set; }

        public User Sender { get; set; }

        public User Recepient { get; set; }
    }
}
