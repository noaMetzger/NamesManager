using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NamesManager.Forms
{
    public partial class FiltersForm : Form
    {
        public string SelectedName { get; private set; }

        public FiltersForm(List<string> filters)
        {
            InitializeComponent();
            filterNames.Items.AddRange(filters.ToArray());
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (filterNames.SelectedItem != null)
            {
                SelectedName = filterNames.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("בחר שם מהרשימה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}



