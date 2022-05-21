using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_App
{
    public partial class frmListboxandCombobox : Form
    {
        public frmListboxandCombobox()
        {
            InitializeComponent();
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            // Add Country 
            lstCountry.Items.Add(txtCountry.Text);
        }

        private void btnDelCountry_Click(object sender, EventArgs e)
        {
            // Delete items from listbox
            int x;
            x = lstCountry.SelectedIndex;
            lstCountry.Items.RemoveAt(x);
        }

        private void btnAddHoppies_Click(object sender, EventArgs e)
        {
            // Add Hoppies 
            cmbHoppies.Items.Add(txtHoppies.Text);
        }

        private void btnDelHoppies_Click(object sender, EventArgs e)
        {
            // Delete items from combobox 
            int x;
            x = cmbHoppies.SelectedIndex;
            cmbHoppies.Items.RemoveAt(x);
        }
    }
}
