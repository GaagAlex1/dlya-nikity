using System;
using System.Windows.Forms;

namespace Lab5
{
    partial class Form1
    {
        private bool IsNumbers(KeyPressEventArgs e, string input)
        {
            char symbol = e.KeyChar;
            if (input == "") return Char.IsDigit(symbol) || symbol == 8 || symbol == 45;
            else if (input[input.Length - 1] == '0') return symbol == 8 || symbol == 32;
            else if (input[input.Length - 1] == '-') return symbol == 8 || Char.IsDigit(symbol);
            return Char.IsDigit(symbol) || (symbol == 32 && input[input.Length - 1] != 32 && input[input.Length - 1] != 45)
                                || symbol == 8 || (symbol == 45 && !Char.IsDigit(input[input.Length - 1]));
        }

        private bool IsSingleNumber(KeyPressEventArgs e, string input)
        {
            char symbol = e.KeyChar;
            if (input == "0") return symbol == 8;
            return Char.IsDigit(symbol) || symbol == 8;
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsNumbers(e, richTextBox1.Text))
            {
                e.Handled = true;
            }
        }

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsNumbers(e, richTextBox2.Text))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsSingleNumber(e,textBox1.Text))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsSingleNumber(e,textBox2.Text))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsSingleNumber(e,textBox3.Text))
            {
                e.Handled = true;
            }
        }
    }
}
