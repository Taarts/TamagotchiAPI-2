using System;
using System.Collections.Generic;

namespace TamagotchiAPI.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday /*{ get; set; } = DateTime.Now;*/
        {
            get
            {
                return this.dateCreated ?? DateTime.UtcNow;
            }
            set { this.dateCreated = value; }
        }
        private DateTime? dateCreated = null;

        public int HungerLevel { get; set; } = 0;
        public int HappinessLevel { get; set; } = 0;

        public List<Playtime> Playtimes { get; set; }
        public List<Scolding> Scoldings { get; set; }
        public List<Feeding> Feedings { get; set; }
    }
}