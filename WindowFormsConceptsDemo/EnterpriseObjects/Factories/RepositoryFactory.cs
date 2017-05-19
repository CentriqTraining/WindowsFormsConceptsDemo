using EnterpriseObjects.Entities;
using EnterpriseObjects.Interfacess;
using EnterpriseObjects.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseObjects.Factories
{
    public static class RepositoryFactory
    {
        public static IRepository<BusinessArea> GetBusinessAreaRepository()
            =>  BusinessAreaRepository.Current;

        public static IRepository<InventoryItem> GetInventoryItemsRepository()
            => new InventoryItemsRepository();
    }
}
