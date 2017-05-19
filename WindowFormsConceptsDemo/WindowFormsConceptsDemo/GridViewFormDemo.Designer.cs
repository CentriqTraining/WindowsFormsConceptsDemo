namespace WindowFormsConceptsDemo
{
    partial class GridViewFormDemo
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
            this.gvData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optInventoryItemsAsList = new System.Windows.Forms.RadioButton();
            this.optBusinessAreasAsList = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvData
            // 
            this.gvData.AllowUserToAddRows = false;
            this.gvData.AllowUserToDeleteRows = false;
            this.gvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvData.Location = new System.Drawing.Point(12, 12);
            this.gvData.Name = "gvData";
            this.gvData.ReadOnly = true;
            this.gvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvData.Size = new System.Drawing.Size(708, 324);
            this.gvData.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optInventoryItemsAsList);
            this.groupBox1.Controls.Add(this.optBusinessAreasAsList);
            this.groupBox1.Location = new System.Drawing.Point(13, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Formats";
            // 
            // optInventoryItemsAsList
            // 
            this.optInventoryItemsAsList.AutoSize = true;
            this.optInventoryItemsAsList.Location = new System.Drawing.Point(316, 18);
            this.optInventoryItemsAsList.Name = "optInventoryItemsAsList";
            this.optInventoryItemsAsList.Size = new System.Drawing.Size(199, 17);
            this.optInventoryItemsAsList.TabIndex = 2;
            this.optInventoryItemsAsList.TabStop = true;
            this.optInventoryItemsAsList.Text = "Use Inventory Item data as a List<T>";
            this.optInventoryItemsAsList.UseVisualStyleBackColor = true;
            this.optInventoryItemsAsList.CheckedChanged += new System.EventHandler(this.optInventoryItemsAsList_CheckedChanged);
            // 
            // optBusinessAreasAsList
            // 
            this.optBusinessAreasAsList.AutoSize = true;
            this.optBusinessAreasAsList.Checked = true;
            this.optBusinessAreasAsList.Location = new System.Drawing.Point(6, 18);
            this.optBusinessAreasAsList.Name = "optBusinessAreasAsList";
            this.optBusinessAreasAsList.Size = new System.Drawing.Size(201, 17);
            this.optBusinessAreasAsList.TabIndex = 3;
            this.optBusinessAreasAsList.TabStop = true;
            this.optBusinessAreasAsList.Text = "Use Business Area Data as a List<T>";
            this.optBusinessAreasAsList.UseVisualStyleBackColor = true;
            this.optBusinessAreasAsList.CheckedChanged += new System.EventHandler(this.optBusinessAreasAsList_CheckedChanged);
            // 
            // GridViewFormDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvData);
            this.Name = "GridViewFormDemo";
            this.Text = "GridView Demo";
            this.Load += new System.EventHandler(this.GridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optInventoryItemsAsList;
        private System.Windows.Forms.RadioButton optBusinessAreasAsList;
    }
}