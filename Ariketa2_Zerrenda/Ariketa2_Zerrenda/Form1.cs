using System.Drawing.Text;

namespace Ariketa2_Zerrenda
{
    public partial class Form1 : Form
    {
        List<Ariketa2> zenbakiak = new List<Ariketa2>();
        private int zenb = 1;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnHurrengoa_Click(object sender, EventArgs e)
        {
            switch (zenb)
            {
                case 1:
                    zenbakiak.Add(new Ariketa2(double.Parse(txtBoxZenb.Text)));
                    labelZenbakia.Text = "2.Zenbakia";
                    Hasieratu();
                    break;
                case 2:
                    zenbakiak.Add(new Ariketa2(double.Parse(txtBoxZenb.Text)));
                    labelZenbakia.Text = "3.Zenbakia";
                    Hasieratu();
                    break;
                case 3:
                    zenbakiak.Add(new Ariketa2(double.Parse(txtBoxZenb.Text)));
                    labelZenbakia.Text = "4.Zenbakia";
                    Hasieratu();
                    break;
                case 4:
                    zenbakiak.Add(new Ariketa2(double.Parse(txtBoxZenb.Text)));
                    txtBoxZenb.Text = "(" + zenbakiak[0].Zenbakia + " + ( 2 x " + zenbakiak[1].Zenbakia + ") + ( 3 x " + zenbakiak[2].Zenbakia + " ) + ( 4 x " + zenbakiak[3].Zenbakia + " ) ) / 4 " + " = " + Ariketa2.eragiketa(zenbakiak);
                    btnHurrengoa.Enabled = false;
                    txtBoxZenb.Enabled = false;
                    break;


            }
            zenb++;
        }
    

        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            zenbakiak.Clear();
            zenb = 1;
            Hasieratu();
            labelZenbakia.Text = "1.Zenbakia";
            btnHurrengoa.Enabled = true;
            txtBoxZenb.Enabled = true;
            txtBoxZenb.Focus();
        }
        private void Hasieratu()
        {

            txtBoxZenb.Text = "";
            txtBoxZenb.Focus(); //Para que el cursor empieze ahi una vez finalizada la operacion.
        }

        private void btnItxi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}