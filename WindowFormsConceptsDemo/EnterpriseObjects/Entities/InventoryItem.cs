using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseObjects.Entities
{
    public class InventoryItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Packaging { get; set; }
        public decimal? Weight { get; set; }
        public decimal Cost { get; set; }
        public bool IsInternalUseOnly { get; set; }
        public BusinessArea Area { get; set; }
    }
}
