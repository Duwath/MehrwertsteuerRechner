namespace MehrwertsteuerRechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRechner_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxBrutto.Text.Length > 0 )
                {
                    //MessageBox.Show(tbxSteuern.Text, "Ich habe einen Button gedrückt!");
                    Rechner(sender, e);
                    Extrarechner( sender,  e);
                }
            }
            catch
            {
                tbxBrutto.Text = "";
                MessageBox.Show("Falscher Wert eingegeben!");

            }




        }
        private void Rechner( object sender, EventArgs e )
        {
            double mwst = Convert.ToDouble(tbxSteuern.Text);
            double brutto = Convert.ToDouble(tbxBrutto.Text);
            double steuer;
            double netto;
            netto = brutto / (1 + (mwst / 100));
            steuer = brutto - netto;
            double bruttoges = Convert.ToDouble(tbxBruttoGes.Text);
            double nettoges = Convert.ToDouble(tbxNettoGes.Text);
            double steuerges = Convert.ToDouble(tbxSteuernGes.Text);

            tbxNetto.Text = netto.ToString("0.00");
            tbxSteuern2.Text = steuer.ToString("0.00");

        }
        private void Extrarechner(object sender, EventArgs e)
        {
            double mwst = Convert.ToDouble(tbxSteuern.Text);
            double brutto = Convert.ToDouble(tbxBrutto.Text);
            double steuer;
            double netto;
            netto = brutto / (1 + (mwst / 100));
            steuer = brutto - netto;
            double bruttoges = Convert.ToDouble(tbxBruttoGes.Text);
            double nettoges = Convert.ToDouble(tbxNettoGes.Text);
            double steuerges = Convert.ToDouble(tbxSteuernGes.Text);

            bruttoges = brutto + bruttoges;
            nettoges = netto + nettoges;
            steuerges = steuer + steuerges;

            tbxBruttoGes.Text = bruttoges.ToString("0.00");
            tbxNettoGes.Text = nettoges.ToString("0.00");
            tbxSteuernGes.Text = steuerges.ToString("0.00");

        }


        private void tbxBrutto_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Rechner(sender, e);
                    Extrarechner(sender, e);


                }
            }
            catch
            {
                tbxBrutto.Text = "";
                MessageBox.Show("Falscher Wert eingegeben!");

            }
        }

        private void tbxBrutto_KeyUp(object sender, KeyEventArgs e)
        {
            try {

                Rechner(sender, e);
            }
            catch
            {
                tbxBrutto.Text = "";
                MessageBox.Show("Falscher Wert eingegeben!");

            }
        }
    }
}