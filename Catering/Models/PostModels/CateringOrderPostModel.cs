using System;

namespace Catering.Models.PostModels
{
    public class CateringOrderPostModel
    {
        public int UserId { get; set; }
        public int ChefId { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfPeople { get; set; }
        public bool Outdoors { get; set; }
        public string Address { get; set; }
        public UserPostModel User { get; set; }
        public ChefPostModel Chef { get; set; }
    }
}
