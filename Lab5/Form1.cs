using System;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        private static int menuItemNumber = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox2.Visible = false;
            ArrayChanging.Arr = new int[0];
            MtxChanging.Mtx = new int[0, 0];
            richTextBox1.ReadOnly = true;
            textBox3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (menuItemNumber)
            {
                case 1:
                    OutputManualArray();
                    break;
                case 2:
                    OutputRandomArray();
                    break;
                case 3:
                    OutputManualMatrix();
                    break;
                case 4:
                    OutputRandomMatrix();
                    break;
                case 5:
                    OutputManualRiggedMartix();
                    break;
                case 6:
                    OutputRandomRiggedMartix();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayChanging.Len = 0;
            ArrayChanging.Arr = new int[0];
            MtxChanging.Mtx = new int[0, 0];
            RiggedMtxChanging.Rigged = new int[0][];
            richTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (menuItemNumber == 1 || menuItemNumber == 2)
            {
                if (richTextBox2.Text != "" && ArrayChanging.Arr != null)
                {
                    ArrayChanging.AddItems(richTextBox2.Text);
                    Write(ArrayChanging.Arr);
                }
            } 
            else if (menuItemNumber == 3 || menuItemNumber == 4)
            {   
                if (MtxChanging.Mtx != null)
                {
                    MtxChanging.DeleteColumnsWithZero();
                    Write(MtxChanging.Mtx);
                }
            } 
            else
            {
                if (RiggedMtxChanging.Rigged != null)
                {
                    if (textBox3.Text == "" || Convert.ToInt32(textBox3.Text) < 0) textBox3.Text = "0";
                    else if (Convert.ToInt32(textBox3.Text) > RiggedMtxChanging.Height - 1) textBox3.Text = (RiggedMtxChanging.Height - 1).ToString();
                    if (richTextBox2.Text != "" && textBox3.Text != "")
                    {
                        RiggedMtxChanging.AddLineFromKeyboard(Convert.ToInt32(textBox3.Text), richTextBox2.Text);
                        Write(RiggedMtxChanging.Rigged);
                    }
                }
            }
        }
    }
}
