namespace Ariketa1
{
    public partial class Form1 : Form
    {
        Esaldia esaldi = new Esaldia();
        public Form1()
        {
            InitializeComponent();
            btnEsald1.Enabled = true;
            btnEsald2.Enabled = false;
            btnEsald3.Enabled = false;
            btnEsald4.Enabled = false;
            btnEsald5.Enabled = false;
            btnLotu.Enabled = false;
            btnGarbitu.Enabled = false; 

        }
        private void Hasieratu()
        {
            txtBox.Text = "";
            txtBox.Focus(); //Para que el cursor empieze ahi una vez finalizada la operacion.
        }
        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEsald1_Click(object sender, EventArgs e)
        {
            btnEsald1.Enabled = false;
            btnEsald2.Enabled = true;
            btnEsald3.Enabled = false;
            btnEsald4.Enabled = false;
            btnEsald5.Enabled = false;
            btnLotu.Enabled = false;
            btnGarbitu.Enabled = false;     
            esaldi.jasotakoEsaldia(txtBox.Text);

            Hasieratu();
        }

        private void btnEsald2_Click(object sender, EventArgs e)
        {
            btnEsald1.Enabled = false;
            btnEsald2.Enabled = false;
            btnEsald3.Enabled = true;
            btnEsald4.Enabled = false;
            btnEsald5.Enabled = false;
            btnLotu.Enabled = false;
            btnGarbitu.Enabled = false;
            esaldi.jasotakoEsaldia(txtBox.Text);
 
            Hasieratu();
        }

        private void btnEsald3_Click(object sender, EventArgs e)
        {
            btnEsald1.Enabled = false;
            btnEsald2.Enabled = false;
            btnEsald3.Enabled = false;
            btnEsald4.Enabled = true;
            btnEsald5.Enabled = false;
            btnLotu.Enabled = false;
            btnGarbitu.Enabled = false;
            esaldi.jasotakoEsaldia(txtBox.Text);

            Hasieratu();
        }

        private void btnEsald4_Click(object sender, EventArgs e)
        {
            btnEsald1.Enabled = false;
            btnEsald2.Enabled = false;
            btnEsald3.Enabled = false;
            btnEsald4.Enabled = false;
            btnEsald5.Enabled = true;
            btnLotu.Enabled = false;
            btnGarbitu.Enabled = false;
            esaldi.jasotakoEsaldia(txtBox.Text);

            Hasieratu();
        }

        private void btnEsald5_Click(object sender, EventArgs e)
        {
            btnEsald1.Enabled = false;
            btnEsald2.Enabled = false;
            btnEsald3.Enabled = false;
            btnEsald4.Enabled = false;
            btnEsald5.Enabled = false;
            btnLotu.Enabled = true;
            btnGarbitu.Enabled = false;
            esaldi.jasotakoEsaldia(txtBox.Text);
            txtBox.Enabled = false;

            Hasieratu();
        }

        private void btnLotu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(esaldi.EsaldiaBatuta);
            btnEsald1.Enabled = false;
            btnEsald2.Enabled = false;
            btnEsald3.Enabled = false;
            btnEsald4.Enabled = false;
            btnEsald5.Enabled = false;
            btnLotu.Enabled = false;
            btnGarbitu.Enabled = true;
           

        }

        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            btnEsald1.Enabled = true;
            btnEsald2.Enabled = false;
            btnEsald3.Enabled = false;
            btnEsald4.Enabled = false;
            btnEsald5.Enabled = false;
            btnLotu.Enabled = false;
            txtBox.Enabled = true;

            esaldi.EsaldiaBatuta = "";

            txtBox.Focus();
        }

        private void btnItxi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}