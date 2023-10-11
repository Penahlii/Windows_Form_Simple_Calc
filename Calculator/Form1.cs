using System.Reflection;

namespace Calculator
{
    public partial class Form1 : Form
    {
        decimal num1 = 0;
        int Index = 0, ext, num2;
        char lastSymbol = ' ';
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
                richTextBox1.Text = "00";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "00") richTextBox1.Text = "1";
            else if (num1.ToString() != richTextBox1.Text)
                richTextBox1.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "00") richTextBox1.Text = "2";
            else if (num1.ToString() != richTextBox1.Text)
                richTextBox1.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "00") richTextBox1.Text = "3";
            else if (num1.ToString() != richTextBox1.Text)
                richTextBox1.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "00") richTextBox1.Text = "4";
            else if (num1.ToString() != richTextBox1.Text)
                richTextBox1.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "00") richTextBox1.Text = "5";
            else if (num1.ToString() != richTextBox1.Text)
                richTextBox1.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "00") richTextBox1.Text = "6";
            else if (num1.ToString() != richTextBox1.Text)
                richTextBox1.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "00") richTextBox1.Text = "7";
            else if (num1.ToString() != richTextBox1.Text)
                richTextBox1.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "00") richTextBox1.Text = "8";
            else if (num1.ToString() != richTextBox1.Text)
                richTextBox1.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "00") richTextBox1.Text = "9";
            else if (num1.ToString() != richTextBox1.Text)
                richTextBox1.Text += "9";
        }

        private void zero_btn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "00") richTextBox1.Text = "0";
            else if (num1.ToString() != richTextBox1.Text)
                richTextBox1.Text += "0";
        }

        private void point_btn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "00") richTextBox1.Text = "0.";
            else if (num1.ToString() != richTextBox1.Text)
                richTextBox1.Text += ".";
        }

        private void C_btn_1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "00";
            richTextBox2.Clear();
            Index = 0;
            num1 = 0;
            lastSymbol = ' ';
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            Start_Operation();
            lastSymbol = '+';
            richTextBox1.Text += "+";
        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            Start_Operation();
            lastSymbol = '-';
            richTextBox1.Text += "-";
        }

        private void multiply_btn_Click(object sender, EventArgs e)
        {
            Start_Operation();
            lastSymbol = '*';
            richTextBox1.Text += "x";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Start_Operation();
            lastSymbol = '/';
            richTextBox1.Text += "/";
        }

        private void divide_btn_Click(object sender, EventArgs e)
        {
            Start_Operation();
            lastSymbol = '/';
            richTextBox1.Text += "/";
        }

        private void b_btn_Click(object sender, EventArgs e)
        {
            Start_Operation();
            lastSymbol = '=';
            richTextBox2.Text = num1.ToString();
        }

        private void Start_Operation()
        {
            if (lastSymbol == '+' || lastSymbol == ' ')
            {
                num1 += decimal.Parse(richTextBox1.Text.Substring(Index));
            }
            else if (lastSymbol == '-')
            {
                num1 -= decimal.Parse(richTextBox1.Text.Substring(Index));
            }
            else if (lastSymbol == '*')
            {
                num1 *= decimal.Parse(richTextBox1.Text.Substring(Index));
            }
            else if (lastSymbol == '/')
            {
                num1 /= decimal.Parse(richTextBox1.Text.Substring(Index));
            }
            else if (lastSymbol == '%')
            {
                if (Int32.TryParse(num1.ToString(), out ext) && Int32.TryParse(richTextBox1.Text.Substring(Index), out num2))
                {
                    ext %= num2;
                }
                num1 %= decimal.Parse(richTextBox1.Text.Substring(Index));
            }
            Index = richTextBox1.Text.Length + 1;
        }

        private void percentage_btn_Click(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
        }
    }
}