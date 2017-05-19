using EnterpriseObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormsConceptsDemo
{
    public static class Utilities
    {
        public static void CreateBusinessAreaColumnHeadings(ListView lv)
        {
            //  You can either set up the column headings in the form designer
            //  Or set it in code.  Hard-coded values for column names, heading
            //  text and width/alignment are shown for demonstration purposes.
            //  A better practice might be to storethese values in the app.config
            //  or grab them from a database.
            lv.Columns.Clear();
            lv.Columns.Add(
                new ColumnHeader()
                {
                    Name = "colName",
                    Width = 250,
                    Text = "Name"
                }
            );
            lv.Columns.Add(
                new ColumnHeader()
                {
                    Name = "colId",
                    Width = 45,
                    Text = "ID"
                }
            );
            lv.Columns.Add(
                new ColumnHeader()
                {
                    Name = "colSubCategory",
                    Width = 250,
                    Text = "Sub Catetory"
                }
            );
        }
        public static void AddBusinessAreaItems(ListView lv, List<BusinessArea> items)
        {
            lv.Items.Clear();

            //  The ListViewItem constructor takes an array of strings
            //  which will be applied to the columns that you set up.
            //  Here I am going through each item I get from my database
            //  and creating that array.
            foreach (var  item in items)
            {
                var columns = new string[]
                {
                    item.Name,
                    item.ID.ToString("N0"),
                    item.SubCategory
                };
                //  Create your new ListViewItem
                var NewItem = new ListViewItem(columns);
                NewItem.ImageIndex = 0;
                //  Add it to the collection of items
                lv.Items.Add(NewItem);
            }
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        public static void CreateInventoryColumnHeadings(ListView lv)
        {
            lv.Columns.Clear();
            lv.Columns.Add(
                new ColumnHeader()
                {
                    Name = "colName",
                    Width = 150,
                    Text = "Name"
                });
            lv.Columns.Add(
                new ColumnHeader()
                {
                    Name = "colId",
                    Width = 45,
                    Text = "ID"
                });
            lv.Columns.Add(
                new ColumnHeader()
                {
                    Name = "colDesc",
                    Width = 175,
                    Text = "Description"
                });
            lv.Columns.Add(
                new ColumnHeader()
                {
                    Name = "colPkg",
                    Width = 85,
                    Text = "Packaging"
                });
            lv.Columns.Add(
                new ColumnHeader()
                {
                    Name = "colWeight",
                    Width = 50,
                    Text = "Weight",
                    TextAlign = HorizontalAlignment.Right
                });
            lv.Columns.Add(
                new ColumnHeader()
                {
                    Name = "colCost",
                    Width = 50,
                    Text = "Cost",
                    TextAlign = HorizontalAlignment.Right
                });
            lv.Columns.Add(
                new ColumnHeader()
                {
                    Name = "colInternal",
                    Width = 70,
                    Text = "Internal Use"
                });
       
        }
        public static void AddInventoryItems(ListView lv, List<InventoryItem> items)
        {
            lv.Items.Clear();

            foreach (var IvItem in items)
            {
                var columns = new string[]
                {
                    IvItem.Name,
                    IvItem.ID.ToString("N0"),
                    IvItem.Description,
                    IvItem.Packaging,
                    IvItem.Weight.HasValue ? IvItem.Weight.Value.ToString("N0") : "",
                    IvItem.Cost.ToString("N2"),
                    IvItem.IsInternalUseOnly.ToString()
                };
                var item = new ListViewItem(columns);
                item.ImageIndex = 0;
                lv.Items.Add(item);
            }
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public static void SetBusinessAreaColumnVisibility(DataGridView dv)
        {
            dv.Columns["InventoryItems"].Visible = false;
        }
        public static void SetInventoryItemColumnVisibility(DataGridView dv)
        {
            dv.Columns["IsInternalUseOnly"].Visible = false;
            dv.Columns["Area"].Visible = false;
        }

    }
}
