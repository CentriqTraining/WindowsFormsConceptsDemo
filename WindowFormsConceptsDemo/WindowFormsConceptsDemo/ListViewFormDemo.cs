using EnterpriseObjects;
using EnterpriseObjects.Entities;
using EnterpriseObjects.Factories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormsConceptsDemo
{
    public partial class ListViewFormDemo : Form
    {
        private List<BusinessArea> _BusinessAreas;
        private List<InventoryItem> _InventoryItems;
        private ImageList _GeneratedLargeImageList;
        private ImageList _GeneratedSmallImageList;
        public ListViewFormDemo()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //  Gets a sample of data for demonstration purposes
            _BusinessAreas = RepositoryFactory.GetBusinessAreaRepository().GetAll();
            _InventoryItems = RepositoryFactory.GetInventoryItemsRepository().GetAll();

            //  We'll default to showing business areas...change using radio buttons
            PopulateListViewWithBusinessAreasList();

            //  Fill a combobox with all the options from the View
            //  Large Icons, Small Icons, Details, etc
            //  We are taking the values straight from the enum so 
            //  no hard-coding..sorting it
            cboView.DataSource = Enum
                .GetNames(typeof(System.Windows.Forms.View))
                .OrderBy(d => d)
                .ToList();
            
            //  To create and set up your image lists manually
            //  And to use images contained in your resources file.
            //  Right now this is set up using the designer
            //CreateImageLists();
        }

        private void CreateImageLists()
        {
            _GeneratedLargeImageList = new ImageList();
            _GeneratedLargeImageList.ColorDepth = ColorDepth.Depth32Bit;
            _GeneratedLargeImageList.ImageSize = new Size(64, 64);
            _GeneratedLargeImageList.Images.Add(Properties.Resources.module_file_format_128); //  <-  This file is added to resources file

            _GeneratedSmallImageList = new ImageList();
            _GeneratedLargeImageList.ColorDepth = ColorDepth.Depth32Bit;
            _GeneratedLargeImageList.ImageSize = new Size(16, 16);
            _GeneratedLargeImageList.Images.Add(Properties.Resources.module_file_format_128);

            lvItems.LargeImageList = _GeneratedLargeImageList;
            lvItems.SmallImageList = _GeneratedSmallImageList;
        }

        private void PopulateListViewWithBusinessAreasList()
        {
            //  Here we are programmatically generating the column headings
            //  However, you can set your own columns through the designer
            Utilities.CreateBusinessAreaColumnHeadings(lvItems);

            //  Adds the items after first clearing what is already there.
            Utilities.AddBusinessAreaItems(lvItems, _BusinessAreas);
        }
        private void PopulateListViewWithInventoryItemsList()
        {
            //  Tell Forms to NOT draw anything until we tell it to
            //  This speeds up the adding of multiple items and prevents flickering
            SuspendLayout();

            //  Programmatically generating the column headings
            Utilities.CreateInventoryColumnHeadings(lvItems);

            //  Add the items after first clearing what is already there.
            Utilities.AddInventoryItems(lvItems, _InventoryItems);

            //  Tell the form to go ahead and draw the screen.
            ResumeLayout();
        }

        #region Event Handlers
        private void optBusinessAreasAsList_CheckedChanged(object sender, EventArgs e)
        {
            //  Best practice:
            //  Event handlers should pass control to a method that will
            //  actually do the work...5-10 lines TOPS in these
            //  If you ever need to do the same functionality that is 
            //  put here...you'll already have a method created to do so.
            var opt = sender as RadioButton;
            if (opt.Checked)
            {
                PopulateListViewWithBusinessAreasList();
            }
        }
        private void optInventoryItemsAsList_CheckedChanged(object sender, EventArgs e)
        {
            var opt = sender as RadioButton;
            if (opt.Checked)
            {
                PopulateListViewWithInventoryItemsList();
            }
        }
        private void cboView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the text of the selected value
            var selectedValue = cboView.SelectedValue as string;

            //  Enum.Parse...takes a string..and returns the INDEX that 
            //  It finds that string in the given enum (View)
            //  Then we cast that as a View...and set the form View.
            lvItems.View = (View)Enum.Parse(typeof(View), selectedValue);
        }
        #endregion
    }
}
