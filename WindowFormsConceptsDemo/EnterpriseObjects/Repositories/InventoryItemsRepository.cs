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
    public class InventoryItemsRepository : IRepository<InventoryItem>
    {
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public bool Delete(int id)
        {
            using (var ctx = new InventoryCtx())
            {
                var ItemToDelete = ctx.InventoryItems.Find(id);
                if (ItemToDelete != null)
                {
                    ctx.InventoryItems.Remove(ItemToDelete);
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
                    return false;
            }
        }
        public bool Delete(InventoryItem item)
        {
            return Delete(item.ID);
        }
        public InventoryItem Find(int id)
        {
            using (var ctx = new InventoryCtx())
            {
                return ctx.InventoryItems.Find(id);
            }
        }
        public List<InventoryItem> GetAll()
        {
            using (var ctx = new InventoryCtx())
            {
                return ctx.InventoryItems.ToList();
            }
        }
        public bool Insert(InventoryItem item)
        {
            using (var ctx = new InventoryCtx())
            {
                ctx.InventoryItems.Add(item);
                try
                {
                    ctx.InventoryItems.Add(item);
                    RaiseCollectionChanged(NotifyCollectionChangedAction.Add);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool Update(InventoryItem item)
        {
            using (var ctx = new InventoryCtx())
            {
                var ItemToUpdate = ctx.InventoryItems.Find(item.ID);

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

        public void RaiseCollectionChanged(NotifyCollectionChangedAction action)
            => CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(action));
    }
}
