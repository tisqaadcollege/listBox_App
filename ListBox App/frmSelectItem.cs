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
    public partial class frmSelectItem : Form
    {
        public frmSelectItem()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // Declare varaible hold city name
            string name;

            name = lstCity.Items[lstCity.SelectedIndex].ToString();

            MessageBox.Show(name);

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lstCity.Sorted = true;
        }
    }
}
