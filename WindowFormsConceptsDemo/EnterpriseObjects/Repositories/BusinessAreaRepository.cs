using EnterpriseObjects.Entities;
using EnterpriseObjects.Interfacess;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseObjects.Repositories
{
    public class BusinessAreaRepository : IRepository<BusinessArea>
    {
        private static BusinessAreaRepository _Instance;

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public static BusinessAreaRepository Current
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BusinessAreaRepository();
                }
                return _Instance;
            }
        }

        private BusinessAreaRepository()
        {
        }
        public bool Delete(int id)
        {
            using (var ctx = new InventoryCtx())
            {
                var ItemToDelete = ctx.BusinessAreas.Find(id);

                if (ItemToDelete != null)
                {
                    ctx.BusinessAreas.Remove(ItemToDelete);
                    try
                    {
                        ctx.SaveChanges();
                        RaiseCollectionChanged(NotifyCollectionChangedAction.Remove);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
        public bool Delete(BusinessArea item)
        {
            return Delete(item.ID);
        }
        public BusinessArea Find(int id)
        {
            using (var ctx = new InventoryCtx())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                return ctx.BusinessAreas.Find(id);
            }
        }
        public List<BusinessArea> GetAll()
        {
            using (var ctx = new InventoryCtx())
            {
                return ctx.BusinessAreas.ToList();
            }
            throw new NotImplementedException();
        }
        public bool Insert(BusinessArea item)
        {
            using (var ctx = new InventoryCtx())
            {
                ctx.BusinessAreas.Add(item);
                try
                {
                    ctx.SaveChanges();
                    RaiseCollectionChanged(NotifyCollectionChangedAction.Add);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool Update(BusinessArea item)
        {
            using (var ctx = new InventoryCtx())
            {
                var ItemToUpdate = ctx.BusinessAreas.Find(item.ID);
                if (ItemToUpdate != null)
                {
                    ctx.Entry(ItemToUpdate).CurrentValues.SetValues(item);
                    try
                    {
                        ctx.SaveChanges();
                        RaiseCollectionChanged(NotifyCollectionChangedAction.Replace);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                else
                    return false;
            }
        }
        private void RaiseCollectionChanged(NotifyCollectionChangedAction action)
            => CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(action));
    }
}
