﻿using System.Collections.Generic;

namespace Catering.Data.Models
{
    public class Chef
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ChefType { get; set; }
        public virtual ICollection<CateringOrder> CateringOrders { get; set; }
    }
}
