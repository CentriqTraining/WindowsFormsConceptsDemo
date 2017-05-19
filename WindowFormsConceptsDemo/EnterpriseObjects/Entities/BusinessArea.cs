using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseObjects.Entities
{
    public class BusinessArea
    {
        public BusinessArea()
        {
            InventoryItems = new List<InventoryItem>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string SubCategory { get; set; }
        public ICollection<InventoryItem> InventoryItems { get; set; }
    }
}


