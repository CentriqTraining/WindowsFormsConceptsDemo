using EnterpriseObjects.Entities;
using EnterpriseObjects.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormsConceptsDemo
{
    public partial class GridViewFormDemo : Form
    {
        private List<BusinessArea> _BusinessAreas;
        private List<InventoryItem> _InventoryItems;
        public GridViewFormDemo()
        {
            InitializeComponent();
        }

        private void GridView_Load(object sender, EventArgs e)
        {
            //  Gets a sample of data for demonstration purposes
            _BusinessAreas = RepositoryFactory.GetBusinessAreaRepository().GetAll();
            _InventoryItems = RepositoryFactory.GetInventoryItemsRepository().GetAll();

            //  Default to showing Business Areas
            SetBindingSource<BusinessArea>(_BusinessAreas);
        }

        private void SetDataSourceToBusinessAreas()
        {
            SetBindingSource<BusinessArea>(_BusinessAreas);
            Utilities.SetBusinessAreaColumnVisibility(gvData);
        }
        private void SetDataSourceToInventoryItems()
        {
            SetBindingSource<InventoryItem>(_InventoryItems);
            Utilities.SetInventoryItemColumnVisibility(gvData);
        }
        private void SetBindingSource<T>(List<T> source)
        {
            SuspendLayout();
            gvData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gvData.RowHeadersVisible = false;
            gvData.DataSource = source;
            gvData.Refresh();
            gvData.RowHeadersVisible = true;
            gvData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            ResumeLayout();
        }

        private void optBusinessAreasAsList_CheckedChanged(object sender, EventArgs e)
        {
            SetDataSourceToBusinessAreas();
        }
        private void optInventoryItemsAsList_CheckedChanged(object sender, EventArgs e)
        {
            SetDataSourceToInventoryItems();
        }
    }
}
