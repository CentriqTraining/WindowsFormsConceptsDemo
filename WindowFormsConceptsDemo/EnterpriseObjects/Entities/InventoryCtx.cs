using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseObjects.Entities
{
   public class InventoryCtx : DbContext
    {
        public InventoryCtx()
        {
            Database.SetInitializer<InventoryCtx>(new DbInit());
        }
        public DbSet<BusinessArea> BusinessAreas { get; set; }
        public DbSet<InventoryItem>  InventoryItems { get; set; }
    }
}
