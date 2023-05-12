using System.Text.RegularExpressions;

namespace Calulator
{
    public partial class Form1 : Form
    {
        private int neededToCloseBrackets = 0;
        HashSet<char> Numbers = new HashSet<char>() { '0', '1', '2', '3', '4', '5', '(', ')', '\b' };
        HashSet<char> Others = new HashSet<char>() { ',', '+', '-', '/', '=', '*' };
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
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text.Length == 0 || !Numbers.Contains(textBox1.Text[^1]) && button.Text == "," && textBox1.Text[^1] != ',')
            {
                textBox1.Text += "0,";
            }
            else if (Others.Contains(button.Text[0]) && Others.Contains(textBox1.Text[^1]))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox1.Text += button.Text;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char numberOrOperationOrBracket = e.KeyChar;
            if (!Numbers.Contains(e.KeyChar) && !Others.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '=')
                {
                    if (neededToCloseBrackets > 0)
                    {
                        textBox1.Text = "Ошибка ввода!";
                        neededToCloseBrackets = 0;
                        e.Handled = true;
                        return;
                    }
                    Calculate();
                    e.Handled = true;
                }
                else if (e.KeyChar == ',')
                {
                    if (textBox1.Text.Length ==0 || !Numbers.Contains(textBox1.Text[^1]) && 
                        (textBox1.Text[^1] != ')' && textBox1.Text[^1] != '('))
                    {
                        textBox1.Text += "0,";
                    }
                    else if(Numbers.Contains(textBox1.Text[^1]) &&
                        (textBox1.Text[^1] != ')' && textBox1.Text[^1] != '('))
                    {
                        e.Handled = false;
                        return;
                    }
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
                    e.Handled = false;
                }
                else if (textBox1.Text.Length != 0 && (Others.Contains(e.KeyChar) && !Others.Contains(textBox1.Text[^1])) ||
                    (e.KeyChar != ')' && Numbers.Contains(e.KeyChar)))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (neededToCloseBrackets > 0)
            {
                textBox1.Text = "Ошибка ввода!";
                neededToCloseBrackets = 0;
                return;
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

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void Calculate()
        {
            try
            {
                checkInput();
                if (textBox1.Text == "") { textBox1.Text = "0"; return; }
                if (textBox1.Text[0] == '-') { textBox1.Text = "0" + textBox1.Text; }
                textBox1.Text = Math.Round(Calculation.Calculate(textBox1.Text), 5).ToString();
            }
            catch(Exception e)
            {
                if (e.Message.Equals("Stack empty."))
                {
                    textBox1.Text = "Ошибка ввода!";
                }
                else if (e.Message.Equals("Negating the minimum value of a twos complement number is invalid."))
                {
                    textBox1.Text = "Деление на ноль невозможно.";
                }
                else { textBox1.Text = e.Message; }
            }
        }

        private bool checkInput()
        {
            if(neededToCloseBrackets > 0)
            {
                throw new Exception("Ошибка ввода! Неправильное количество скобок.");
            }

            bool hasComma = false;
            for(int i =0; i < textBox1.Text.Length; i++)
            {
                var c = textBox1.Text[i];
                if(!Numbers.Contains(c) && !Others.Contains(c))
                {
                    throw new Exception("Неправильный ввод!");
                }
                if(c == ',' && hasComma)
                {
                    throw new Exception("Неправильный ввод! Проверьте запятые.");
                }
                if(c == ',')
                {
                    hasComma = true;
                }
                if(Others.Contains(c) && c != ',')
                {
                    hasComma = false;
                }


            }


            return true;
        }

    }
}