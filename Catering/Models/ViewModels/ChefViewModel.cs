using System.Collections.Generic;

namespace Catering.Models.ViewModels
{
    public class ChefViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ChefType { get; set; }
        public ICollection<CateringOrderViewModel> CateringOrders { get; set; }
    }
}
