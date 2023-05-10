using System.Text.RegularExpressions;

namespace Calulator
{
    public partial class Form1 : Form
    {
        private int neededToCloseBrackets = 0;
        private bool isLastClickedIsOperator = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button button = ((Button)sender);
            textBox1.Text = textBox1.Text == "0" ? button.Text : textBox1.Text + button.Text;
            isLastClickedIsOperator = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            if (!isLastClickedIsOperator)
            {
                textBox1.Text += button.Text;
                isLastClickedIsOperator = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char numberOrOperationOrBracket = e.KeyChar;
            HashSet<char> Numbers = new HashSet<char>() { '0', '1', '2', '3', '4', '5', '(', ')', '\b' };
            HashSet<char> Others = new HashSet<char>() { ',', '+', '-', '/', '=', '*' };
            if (!Numbers.Contains(e.KeyChar) && !Others.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '=')
                {
                    while (neededToCloseBrackets > 0)
                    {
                        textBox1.Text += ')';
                        neededToCloseBrackets--;
                    }
                    Calculate();
                    e.Handled = true;
                }
                else if (e.KeyChar == '(')
                {
                    neededToCloseBrackets++;
                    e.Handled = false;
                }
                else if (e.KeyChar == ')' && neededToCloseBrackets > 0)
                {
                    neededToCloseBrackets--;
                    e.Handled = true;
                }
                else if (Others.Contains(e.KeyChar) && isLastClickedIsOperator)
                {
                    e.Handled = true;
                }
                else if (Others.Contains(e.KeyChar))
                {
                    e.Handled = false;
                    isLastClickedIsOperator = true;
                }
                else if (Numbers.Contains(e.KeyChar))
                {
                    e.Handled = false;
                    isLastClickedIsOperator = false;
                }
            }
        }

        private void Calculate()
        {
            if (textBox1.Text == "") { textBox1.Text = "0"; }
            if (textBox1.Text[0] == ',' || textBox1.Text[0] == '-') { textBox1.Text = "0" + textBox1.Text; }
            textBox1.Text = Math.Round(Calculation.Calculate(textBox1.Text), 5).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            while (neededToCloseBrackets > 0)
            {
                textBox1.Text += ")";
                neededToCloseBrackets--;
            }
            Calculate();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.textBox1.Text += button.Text;
            neededToCloseBrackets++;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (neededToCloseBrackets > 0)
            {
                textBox1.Text += ")";
                neededToCloseBrackets--;
            }
        }
    }
}