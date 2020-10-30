using System;

namespace Catering.Domain.Models
{
    public class CateringOrderModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ChefId { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfPeople { get; set; }
        public bool Outdoors { get; set; }
        public string Address { get; set; }
        public UserModel User { get; set; }
        public ChefModel Chef { get; set; }
    }
}
