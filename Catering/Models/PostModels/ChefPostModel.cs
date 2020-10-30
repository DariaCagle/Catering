using System.Collections.Generic;

namespace Catering.Models.PostModels
{
    public class ChefPostModel
    {
        public string FullName { get; set; }
        public string ChefType { get; set; }
        public ICollection<CateringOrderPostModel> CateringOrders { get; set; }
    }
}
