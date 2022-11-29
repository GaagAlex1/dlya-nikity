using System;

namespace Lab5
{
    partial class Form1
    {
        private void вручнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label1.Text = "Размер массива";
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            richTextBox2.Visible = true;
            textBox3.Visible = false;
            richTextBox1.ReadOnly = false;
            menuItemNumber = 1;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

        private void генераторСлучайныхЧиселToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Размер массива";
            label2.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = false;
            richTextBox2.Visible = true;
            textBox3.Visible = false;
            richTextBox1.ReadOnly = true;
            menuItemNumber = 2;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

        private void вручнуюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            richTextBox2.Visible = false;
            textBox3.Visible = false;
            richTextBox1.ReadOnly = false;
            menuItemNumber = 3;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

        private void генераторСлучайныхЧиселToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            richTextBox2.Visible = false;
            textBox3.Visible = false;
            label1.Text = "Количество строк";
            richTextBox1.ReadOnly = true;
            menuItemNumber = 4;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

        private void вручнуюToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            richTextBox2.Visible = true;
            textBox3.Visible = true;
            richTextBox1.ReadOnly = false;
            menuItemNumber = 5;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

        private void генераторСлучайныхЧиселToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            richTextBox2.Visible = true;
            textBox3.Visible = true;
            richTextBox1.ReadOnly = true;
            menuItemNumber = 6;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }
    }
}
