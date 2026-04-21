using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Products
{
    public partial class Form1 : Form
    {
        string ID;
        string name;
        double price;

        public Form1()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] arrListItems = new string[listBox1.Items.Count];

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                arrListItems[i] = listBox1.Items[i].ToString();
            }

            listBox1.Items.Add($"ID: {txtProductID.Text}, Name: {txtProductName.Text}, Price: R{numProductPrice.Value:F2}");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string selected = listBox1.SelectedItems.ToString();

            int index = listBox1.SelectedIndex;

            if (index != -1)
            {
                listBox1.Items[index] = $"ID: {txtProductID.Text}, Name: {txtProductName.Text}, Price: R{numProductPrice.Value:F2}";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selected = listBox1.SelectedItem.ToString();

            listBox1.Items.Remove(selected);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string selected = listBox1.SelectedItem.ToString();

            MessageBox.Show(selected);
        }
    }
}
