namespace Kalkulator
{
    public partial class Form1 : Form
    {
        private double pierwszaLiczba;
        private double drugaLiczba;
        private string operacja;
        private bool czyNowaLiczba = true;

        public System.Windows.Forms.TextBox textBox1; 
        public Form1()
        {
            InitializeComponent();
        }

        private void WprowadŸCyfrê(string cyfra)
        {
            if (czyNowaLiczba)
            {
                textBox1.Text = cyfra;
                czyNowaLiczba = false;
            }
            else
            {
                textBox1.Text += cyfra;
            }
        }

        private void WykonajOperacjê(string wybranaOperacja)
        {
            if (double.TryParse(textBox1.Text.Replace(".", ","), out pierwszaLiczba))
            {
                operacja = wybranaOperacja;
                czyNowaLiczba = true;
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            WprowadŸCyfrê("1");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WprowadŸCyfrê("2");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            WprowadŸCyfrê("3");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            WprowadŸCyfrê("4");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            WprowadŸCyfrê("5");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            WprowadŸCyfrê("6");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            WprowadŸCyfrê("7");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            WprowadŸCyfrê("8");
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            WprowadŸCyfrê("9");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            pierwszaLiczba = 0;
            drugaLiczba = 0;
            operacja = "";
            czyNowaLiczba = true;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            WprowadŸCyfrê("0");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text.Replace(".", ","), out drugaLiczba))
            {
                double wynik = 0;

                switch (operacja)
                {
                    case "+":
                        wynik = pierwszaLiczba + drugaLiczba;
                        break;
                    case "-":
                        wynik = pierwszaLiczba - drugaLiczba;
                        break;
                    case "*":
                        wynik = pierwszaLiczba * drugaLiczba;
                        break;
                    case "/":
                        if (drugaLiczba != 0)
                        {
                            wynik = pierwszaLiczba / drugaLiczba;
                        }
                        else
                        {
                            textBox1.Text = "Dzielenie przez zero!";
                            return;
                        }
                        break;
                }

                textBox1.Text = wynik.ToString().Replace(".", ",");
                czyNowaLiczba = true; 
                pierwszaLiczba = wynik;
                operacja = "";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WykonajOperacjê("+");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            WykonajOperacjê("-");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            WykonajOperacjê("*");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            WykonajOperacjê("/");
        }

        private void kropka_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(",")) 
            {
                if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "0")
                {
                    textBox1.Text = "0,"; 
                }
                else
                {
                    textBox1.Text += ","; 
                }
                czyNowaLiczba = false; 
            }
        
        }
    }
}
