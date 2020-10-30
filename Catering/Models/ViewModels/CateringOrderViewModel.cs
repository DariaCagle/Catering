using System;

namespace Catering.Models.ViewModels
{
    public class CateringOrderViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ChefId { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfPeople { get; set; }
        public bool Outdoors { get; set; }
        public string Address { get; set; }
        public UserViewModel User { get; set; }
        public ChefViewModel Chef { get; set; }
    }
}
