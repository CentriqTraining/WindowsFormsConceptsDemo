namespace WindowFormsConceptsDemo
{
    partial class Launcher
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
            this.cmdGridView = new System.Windows.Forms.Button();
            this.cmdListView = new System.Windows.Forms.Button();
            this.cmdMisc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdGridView
            // 
            this.cmdGridView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdGridView.Location = new System.Drawing.Point(25, 22);
            this.cmdGridView.Name = "cmdGridView";
            this.cmdGridView.Size = new System.Drawing.Size(92, 71);
            this.cmdGridView.TabIndex = 0;
            this.cmdGridView.Text = "GridView Example";
            this.cmdGridView.UseVisualStyleBackColor = true;
            this.cmdGridView.Click += new System.EventHandler(this.cmdGridView_Click);
            // 
            // cmdListView
            // 
            this.cmdListView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdListView.Location = new System.Drawing.Point(123, 22);
            this.cmdListView.Name = "cmdListView";
            this.cmdListView.Size = new System.Drawing.Size(92, 71);
            this.cmdListView.TabIndex = 0;
            this.cmdListView.Text = "ListView Example";
            this.cmdListView.UseVisualStyleBackColor = true;
            this.cmdListView.Click += new System.EventHandler(this.cmdListView_Click);
            // 
            // cmdMisc
            // 
            this.cmdMisc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdMisc.Location = new System.Drawing.Point(221, 22);
            this.cmdMisc.Name = "cmdMisc";
            this.cmdMisc.Size = new System.Drawing.Size(92, 71);
            this.cmdMisc.TabIndex = 0;
            this.cmdMisc.Text = "Misc Controls Example";
            this.cmdMisc.UseVisualStyleBackColor = true;
            this.cmdMisc.Click += new System.EventHandler(this.cmdMisc_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 117);
            this.Controls.Add(this.cmdMisc);
            this.Controls.Add(this.cmdListView);
            this.Controls.Add(this.cmdGridView);
            this.Name = "Launcher";
            this.Text = "Launcher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdGridView;
        private System.Windows.Forms.Button cmdListView;
        private System.Windows.Forms.Button cmdMisc;
    }
}