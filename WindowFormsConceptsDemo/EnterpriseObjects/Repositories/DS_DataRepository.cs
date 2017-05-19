using EnterpriseObjects.Interfacess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EnterpriseObjects.Entities;

namespace EnterpriseObjects.Repositories
{
    public class DS_DataRepository : IDSRepository
    {
        private static DS_DataRepository _Instance;
        private DS_DataRepository()
        {

        }
        public static DS_DataRepository Current
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DS_DataRepository();
                }
                return _Instance;
            }
        }
        public DataSet GetBusinessAreas()
        {
            var result = new DataSet();

            DataTable table = CreateBusinessAreasTable();

            BuildBusinessAreasTable(table);
            result.Tables.Add(table);
            return result;
        }
        public DataSet GetData()
        {
            var result = new DataSet();
            DataTable table1 = CreateBusinessAreasTable();
            BuildBusinessAreasTable(table1);
            DataTable table2 = CreateInventoryItemsTable();
            BuildInventoryTable(table2);
            result.Tables.Add(table1);
            result.Tables.Add(table2);
            result.Relations.Add(new DataRelation("BusinessAreaInventoryItems",
                                                    table1.Columns["ID"],
                                                    table2.Columns["BusinessAreaID"]));
            return result;
        }
        public DataSet GetInventoryItems()
        {
            var result = new DataSet();

            DataTable table = CreateInventoryItemsTable();

            BuildInventoryTable(table);
            result.Tables.Add(table);
            return result;
        }

        private static void BuildInventoryTable(DataTable table)
        {
            using (var ctx = new InventoryCtx())
            {
                var items = ctx.InventoryItems.Include("Area").ToList();
                foreach (var item in items)
                {
                    table.Rows.Add(item.ID, item.Name,
                                    item.Description, item.Packaging,
                                    item.Weight, item.Cost,
                                    item.IsInternalUseOnly, item.Area.ID);
                }
            }
        }
        private static void BuildBusinessAreasTable(DataTable table)
        {
            using (var ctx = new InventoryCtx())
            {
                var areas = ctx.BusinessAreas.ToList();
                foreach (var item in areas)
                {
                    table.Rows.Add(item.ID, item.Name, item.SubCategory);
                }
            }
        }
        private static DataTable CreateBusinessAreasTable()
        {
            var table = new DataTable();
            table.TableName = "BusinessAreas";
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("Name", typeof(string)));
            table.Columns.Add(new DataColumn("SubCategory", typeof(string)));
            return table;
        }
        private static DataTable CreateInventoryItemsTable()
        {
            var table = new DataTable();
            table.TableName = "InventoryItems";
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("Name", typeof(string)));
            table.Columns.Add(new DataColumn("Description", typeof(string)));
            table.Columns.Add(new DataColumn("Packaging", typeof(string)));
            table.Columns.Add(new DataColumn("Weight", typeof(decimal)) { AllowDBNull = true });
            table.Columns.Add(new DataColumn("Cost", typeof(decimal)));
            table.Columns.Add(new DataColumn("IsInternalUseOnly", typeof(bool)));
            table.Columns.Add(new DataColumn("BusinessAreaID", typeof(int)));
            return table;
        }
    }
}
