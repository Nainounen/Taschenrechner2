using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.SymbolStore;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        int Zahl1;
        int Zahl2;
        char Operation;
        int Ergebnis;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cmd0_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
            LblZahl1.Text = $"{Zahl1}";
            LblZahl2.Text = $"{Zahl2}";
        }

        private void Cmd1_Click(object sender, EventArgs e)
        {

            label1.Text += "1";
            LblZahl1.Text = $"{Zahl1}";
            LblZahl2.Text = $"{Zahl2}";
        }

        private void Cmd2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
            LblZahl1.Text = $"{Zahl1}";
            LblZahl2.Text = $"{Zahl2}";
        }

        private void Cmd3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
            LblZahl1.Text = $"{Zahl1}";
            LblZahl2.Text = $"{Zahl2}";
        }

        private void Cmd4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
            LblZahl1.Text = $"{Zahl1}";
            LblZahl2.Text = $"{Zahl2}";
        }

        private void Cmd5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
            LblZahl1.Text = $"{Zahl1}";
            LblZahl2.Text = $"{Zahl2}";
        }

        private void Cmd6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
            LblZahl1.Text = $"{Zahl1}";
            LblZahl2.Text = $"{Zahl2}";
        }

        private void Cmd7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
            LblZahl1.Text = $"{Zahl1}";
            LblZahl2.Text = $"{Zahl2}";
        }

        private void Cmd8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
            LblZahl1.Text = $"{Zahl1}";
            LblZahl2.Text = $"{Zahl2}";
        }

        private void Cmd9_Click(object sender, EventArgs e)
        {
            LblZahl1.Text += "9";
            LblZahl1.Text = $"{Zahl1}";
            LblZahl2.Text = $"{Zahl2}";
        }


        private void CmdPlus_Click(object sender, EventArgs e)
        {
            Zahl1 = Convert.ToInt32(label1.Text);
            label1.Text = "";
            Operation = '+';
            LblOperation.Text = $"{Operation}";
        }

        private void CmdMinus_Click(object sender, EventArgs e)
        {
            Zahl1 = Convert.ToInt32(label1.Text);
            label1.Text = "";
            Operation = '-';
            LblOperation.Text = $"{Operation}";

        }

        private void CmdMultiplikation_Click(object sender, EventArgs e)
        {
            Zahl1 = Convert.ToInt32(label1.Text);
            label1.Text = "";
            Operation = '*';
            LblOperation.Text = $"{Operation}";

        }

        private void CmdDivision_Click(object sender, EventArgs e)
        {
            Zahl1 = Convert.ToInt32(label1.Text);
            label1.Text = "";
            Operation = '/';
            LblOperation.Text = $"{Operation}";

        }

        private void CmdWurzel_Click(object sender, EventArgs e)
        {
            Zahl1 = Convert.ToInt32(label1.Text);
            LblZahl2.Text  = $"{Zahl1}";
            double Wurzel = Math.Sqrt(Zahl1);
            LblOperation.Text = "√";
            label1.Text = $"{Wurzel}";
        }

        private void CmdGleich_Click(object sender, EventArgs e)
        {
            Zahl2 = Convert.ToInt32(label1.Text);
            LblZahl1.Text = $"{Zahl1}";
            LblZahl2.Text = $"{Zahl2}";
            switch (Operation)
            {
                case '+':
                    Ergebnis = Zahl1 + Zahl2;
                    break;
                case '-':
                    Ergebnis = Zahl1 - Zahl2;
                    break;
                case '*':
                    Ergebnis = Zahl1 * Zahl2;
                    break;
                case '/':
                    Ergebnis = Zahl1 / Zahl2;
                    break;

            }

            label1.Text = $"{Ergebnis}";


        }



        private void CmdDelete_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            LblZahl1.Text = "";
            LblZahl2.Text = "";
            Zahl1 = 0;
            Zahl2 = 0;
            Ergebnis = 0;
            LblOperation.Text = string.Empty;


        }

        private void zahl1_Click(object sender, EventArgs e)
        {

        }

        private void zahl2_Click(object sender, EventArgs e)
        {

        }

        private void LblOperation_Click(object sender, EventArgs e)
        {

        }
    }
}