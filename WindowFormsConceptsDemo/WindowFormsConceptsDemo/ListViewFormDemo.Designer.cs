namespace WindowFormsConceptsDemo
{
    partial class ListViewFormDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewFormDemo));
            this.lvItems = new System.Windows.Forms.ListView();
            this.optBusinessAreasAsList = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optInventoryItemsAsList = new System.Windows.Forms.RadioButton();
            this.cboView = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.ImageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvItems
            // 
            this.lvItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvItems.LargeImageList = this.ImageListLarge;
            this.lvItems.Location = new System.Drawing.Point(12, 43);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(633, 314);
            this.lvItems.SmallImageList = this.ImageListSmall;
            this.lvItems.TabIndex = 0;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            // 
            // optBusinessAreasAsList
            // 
            this.optBusinessAreasAsList.AutoSize = true;
            this.optBusinessAreasAsList.Checked = true;
            this.optBusinessAreasAsList.Location = new System.Drawing.Point(32, 19);
            this.optBusinessAreasAsList.Name = "optBusinessAreasAsList";
            this.optBusinessAreasAsList.Size = new System.Drawing.Size(201, 17);
            this.optBusinessAreasAsList.TabIndex = 1;
            this.optBusinessAreasAsList.TabStop = true;
            this.optBusinessAreasAsList.Text = "Use Business Area Data as a List<T>";
            this.optBusinessAreasAsList.UseVisualStyleBackColor = true;
            this.optBusinessAreasAsList.CheckedChanged += new System.EventHandler(this.optBusinessAreasAsList_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optInventoryItemsAsList);
            this.groupBox1.Controls.Add(this.optBusinessAreasAsList);
            this.groupBox1.Location = new System.Drawing.Point(12, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 44);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Formats";
            // 
            // optInventoryItemsAsList
            // 
            this.optInventoryItemsAsList.AutoSize = true;
            this.optInventoryItemsAsList.Location = new System.Drawing.Point(239, 19);
            this.optInventoryItemsAsList.Name = "optInventoryItemsAsList";
            this.optInventoryItemsAsList.Size = new System.Drawing.Size(199, 17);
            this.optInventoryItemsAsList.TabIndex = 1;
            this.optInventoryItemsAsList.TabStop = true;
            this.optInventoryItemsAsList.Text = "Use Inventory Item data as a List<T>";
            this.optInventoryItemsAsList.UseVisualStyleBackColor = true;
            this.optInventoryItemsAsList.CheckedChanged += new System.EventHandler(this.optInventoryItemsAsList_CheckedChanged);
            // 
            // cboView
            // 
            this.cboView.FormattingEnabled = true;
            this.cboView.Location = new System.Drawing.Point(524, 16);
            this.cboView.Name = "cboView";
            this.cboView.Size = new System.Drawing.Size(121, 21);
            this.cboView.TabIndex = 3;
            this.cboView.SelectedIndexChanged += new System.EventHandler(this.cboView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "View";
            // 
            // ImageListSmall
            // 
            this.ImageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListSmall.ImageStream")));
            this.ImageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListSmall.Images.SetKeyName(0, "module_file_format_128.png");
            // 
            // ImageListLarge
            // 
            this.ImageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListLarge.ImageStream")));
            this.ImageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListLarge.Images.SetKeyName(0, "module_file_format_128.png");
            // 
            // ListViewFormDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvItems);
            this.Name = "ListViewFormDemo";
            this.Text = "Setting Up a List View";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.RadioButton optBusinessAreasAsList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optInventoryItemsAsList;
        private System.Windows.Forms.ComboBox cboView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ImageListSmall;
        private System.Windows.Forms.ImageList ImageListLarge;
    }
}

