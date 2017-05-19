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
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }
        private void cmdGridView_Click(object sender, EventArgs e)
        {
            Form runForm = new GridViewFormDemo();
            runForm.Show();
        }
        private void cmdListView_Click(object sender, EventArgs e)
        {
            Form runForm = new ListViewFormDemo();
            runForm.Show();
        }
        private void cmdMisc_Click(object sender, EventArgs e)
        {
            Form runForm = new MiscControlsFormDemo();
            runForm.Show();
        }
    }
}
