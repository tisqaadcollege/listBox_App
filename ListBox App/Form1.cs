namespace ListBox_App
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            /* Declare varaible hold city name 
            string name; 

            name = lstMyListBox.Items[lstMyListBox.SelectedIndex].ToString();

            MessageBox.Show(name);

         

            lstMyListBox.Sorted = false;

              */

            lstMyListBox.Items.Add(txtColor.Text);


        }
    }
}