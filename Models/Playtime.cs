using System;
using System.Collections.Generic;

namespace TamagotchiAPI.Models
{
    public class Playtime
    {
        public int Id { get; set; }
        public DateTime When /*{ get; set; }*/
        {
            get
            {
                return this.dateCreated ?? DateTime.UtcNow;
            }
            set { this.dateCreated = value; }
        }
        private DateTime? dateCreated = null;
        public int PetId { get; set; }
        public Pet Pet { get; set; }

        // public List<Pet> Pets { get; set; }
    }
}