using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System;

namespace EnterpriseObjects.Entities
{
    internal class DbInit : CreateDatabaseIfNotExists<InventoryCtx>
    {
        protected override void Seed(InventoryCtx context)
        {
            context.BusinessAreas.AddRange(new List<BusinessArea>() {
                new BusinessArea() { Name = "Automatic Doors & Storefronts", SubCategory = "Sales" },
                new BusinessArea() { Name = "Automatic Doors & Storefronts", SubCategory = "Service" },
                new BusinessArea() { Name = "Automatic Doors & Storefronts", SubCategory = "Installation" },
                new BusinessArea() { Name = "Automatic Doors & Storefronts", SubCategory = "Maintenance/Supplies" },
                new BusinessArea() { Name = "Dock Equipment", SubCategory = "Sales" },
                new BusinessArea() { Name = "Dock Equipment", SubCategory = "Service" },
                new BusinessArea() { Name = "Dock Equipment", SubCategory = "Installation" },
                new BusinessArea() { Name = "Dock Equipment", SubCategory = "Maintenance/Supplies" },
                new BusinessArea() { Name = "Manual Doors, Frames & Hardware", SubCategory = "Sales" },
                new BusinessArea() { Name = "Sectional, RIS, HSD & Specialty Doors", SubCategory = "Sales" },
                new BusinessArea() { Name = "Sectional, RIS, HSD & Specialty Doors", SubCategory = "Service" },
                new BusinessArea() { Name = "Sectional, RIS, HSD & Specialty Doors", SubCategory = "Installation" },
                new BusinessArea() { Name = "Sectional, RIS, HSD & Specialty Doors", SubCategory = "Maintenance/Supplies" },
            });
            context.SaveChanges();

            var rangeHigh = context.BusinessAreas.Count();
            for (int i = 0; i < 400; i++)
            {
                var newItem = new InventoryItem()
                {
                    Cost = RandomGenerator.GetDecimal(),
                    Name = "Inventory Item #" + i.ToString("#"),
                    Description = "Description for Item #" + i.ToString("#"),
                    IsInternalUseOnly = RandomGenerator.GetInt(0, 1) == 0 ? true : false,
                    Weight = RandomGenerator.GetInt(0, 150),
                    Packaging = string.Empty
                };

                context.BusinessAreas.ToList()[RandomGenerator.GetInt(0, rangeHigh)].InventoryItems.Add(newItem);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}