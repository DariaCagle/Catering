using System.Collections.Generic;

namespace Catering.Domain.Models
{
    public class ChefModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ChefType { get; set; }
        public ICollection<CateringOrderModel> CateringOrders { get; set; }
    }
}
