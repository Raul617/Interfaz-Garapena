namespace Ariketa2

{
    public partial class Form1 : Form
    {
        Zenbakiak zenbaki = new Zenbakiak();
        int zenb = 1;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHurrengoa_Click(object sender, EventArgs e)
        {
            switch (zenb)
            {
                case 1:
                    zenbaki.zenbaki1 = float.Parse(textBox1.Text);
                    txtZenbakia.Text = "2.Zenbakia";
                    Hasieratu();
                    txtZenbakia.Focus();
                    break;
                case 2:
                    zenbaki.zenbaki2 = float.Parse(textBox1.Text);
                    txtZenbakia.Text = "3.Zenbakia";
                    Hasieratu();
                    txtZenbakia.Focus();
                    break;
                case 3:
                    zenbaki.zenbaki3 = float.Parse(textBox1.Text);
                    txtZenbakia.Text = "4.Zenbakia";
                    Hasieratu();
                    txtZenbakia.Focus();
                    break;
                case 4:
                    txtZenbakia.Text = "Eragiketa";
                    zenbaki.zenbaki4 = float.Parse(textBox1.Text);
                    Hasieratu();
                    txtZenbakia.Focus();
                    textBox1.Enabled = false;
                    textBox1.Text = zenbaki.formula();
                    break;
                case 5: 
                    
                    break;

            }
            zenb++;
        }

        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            HasieratuGuztia();
        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Hasieratu()
        {
            
            textBox1.Text = "";
            textBox1.Focus(); //Para que el cursor empieze ahi una vez finalizada la operacion.
        }
        private void HasieratuGuztia()
        {
            zenb = 1;
            txtZenbakia.Text = "1.zenbakia";
            textBox1.Enabled = true;
            textBox1.Text = "";
            textBox1.Focus(); //Para que el cursor empieze ahi una vez finalizada la operacion.
        }
    }
}