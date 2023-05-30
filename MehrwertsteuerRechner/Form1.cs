using System.Windows.Forms;
namespace MehrwertsteuerRechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //InitializeMovingBackground();
        }
        private void btnRechner_Click1(object sender, EventArgs e)
        {
            try
            {
                if (tbxEingabe.Text.Length > 0)
                {
                    Rechner(sender, e);
                    Extrarechner(sender, e);
                }
            }
            catch
            {
                tbxEingabe.Text = "";
                MessageBox.Show("Falscher Wert eingegeben!");
            }
        }
        private void Rechner(object sender, EventArgs e)
        {
            try
            {
                double mwst = Convert.ToDouble(tbxSteuern.Text);
                double eingabe = Convert.ToDouble(tbxEingabe.Text);
                double brutto;
                double steuer;
                double netto;
                if (rbtBrutto.Checked)
                {
                    brutto = eingabe;
                    netto = brutto / (1 + (mwst / 100));
                    steuer = brutto - netto;
                    double bruttoges = Convert.ToDouble(tbxBruttoGes.Text);
                    double nettoges = Convert.ToDouble(tbxNettoGes.Text);
                    double steuerges = Convert.ToDouble(tbxSteuernGes.Text);
                    bruttoges = brutto + bruttoges;
                    nettoges = netto + nettoges;
                    steuerges = steuer + steuerges;
                    tbxNetto.Text = netto.ToString("0.00");
                    tbxSteuern2.Text = steuer.ToString("0.00");
                    tbxBrutto.Text = brutto.ToString("0.00");
                }
                else
                {
                    netto = eingabe;
                    brutto = netto * (1 + (mwst / 100));
                    steuer = brutto - netto;
                    double bruttoges = Convert.ToDouble(tbxBruttoGes.Text);
                    double nettoges = Convert.ToDouble(tbxNettoGes.Text);
                    double steuerges = Convert.ToDouble(tbxSteuernGes.Text);
                    bruttoges = brutto + bruttoges;
                    nettoges = netto + nettoges;
                    steuerges = steuer + steuerges;
                    tbxNetto.Text = netto.ToString("0.00");
                    tbxSteuern2.Text = steuer.ToString("0.00");
                    tbxBrutto.Text = brutto.ToString("0.00");
                }
            }
            catch { }
        }
        private void Extrarechner(object sender, EventArgs e)
        {
            double mwst = Convert.ToDouble(tbxSteuern.Text);
            double brutto = Convert.ToDouble(tbxEingabe.Text);
            double steuer;
            double netto;
            double eingabe = Convert.ToDouble(tbxEingabe.Text);
            if (rbtBrutto.Checked)
            {
                brutto = eingabe;
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
            else
            {
                netto = eingabe;
                brutto = netto * (1 + (mwst / 100));
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
        }
        private void tbxEingabe_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnRechner_Click1(sender, e);
                    Extrarechner(sender, e);
                }
            }
            catch
            {
                tbxEingabe.Text = "";
                MessageBox.Show("Falscher Wert eingegeben!");
            }
        }
        private void tbxEingabe_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Rechner(sender, e);
            }
            catch
            {
                tbxEingabe.Text = "";
                MessageBox.Show("Falscher Wert eingegeben!");
            }
        }
        private void Resetbutton_Click(object sender, EventArgs e)
        {
            tbxBruttoGes.Text = "0";
            tbxNettoGes.Text = "0";
            tbxSteuernGes.Text = "0";
            tbxNetto.Text = "";
            tbxEingabe.Text = "";
            tbxSteuern2.Text = "";
            tbxBrutto.Text = "";
            tbxEingabe.Focus();
        }
    }
}