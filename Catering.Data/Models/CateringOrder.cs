﻿using System;

namespace Catering.Data.Models
{
    public class CateringOrder
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ChefId { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfPeople { get; set; }
        public bool Outdoors { get; set; }
        public string Address { get; set; }
        public virtual User User { get; set; }
        public virtual Chef Chef { get; set; }
    }
}
