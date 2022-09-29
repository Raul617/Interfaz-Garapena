namespace KaixoMundua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkaixo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaixo Mundua");
        }

        private void btnitxi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}