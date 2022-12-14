using System;

namespace TamagotchiAPI.Models
{
    public class Feeding
    {
        public int Id { get; set; }
        public DateTime When /* { get; set; } */
        {
            get
            {
                return this.dateCreated ?? DateTime.UtcNow;
            }
            set { this.dateCreated = value; }
        }
        public DateTime? dateCreated = null;
        public int PetId { get; set; }
        public Pet Pet { get; set; }
    }
}