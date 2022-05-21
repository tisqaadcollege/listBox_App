namespace ListBox_App
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstMyListBox.Items.Add(txtColor.Text);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            lstMyListBox.Items.Insert(2, txtColor.Text);
        }
    }
}