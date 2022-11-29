using System;

namespace Lab5
{
    partial class Form1
    {
        private void OutputRandomArray()
        {
            if (textBox1.Text != "")
            {
                ArrayChanging.Len = Convert.ToInt32(textBox1.Text);
                ArrayChanging.Arr = new int[ArrayChanging.Len];
                ArrayChanging.FillRandom();
                Write(ArrayChanging.Arr);
                textBox1.Text = "";
            }
        }

        private void OutputManualArray()
        {
            ArrayChanging.FillManual(richTextBox1.Text);
            Write(ArrayChanging.Arr);
        }

        private void OutputRandomMatrix()
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                MtxChanging.Len = Convert.ToInt32(textBox2.Text);
                MtxChanging.Height = Convert.ToInt32(textBox1.Text);
                MtxChanging.Mtx = new int[MtxChanging.Height, MtxChanging.Len];
                MtxChanging.FillRandom();
                Write(MtxChanging.Mtx);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void OutputManualMatrix()
        {
            if (richTextBox1.Text != "")
            {
                MtxChanging.FillManual(richTextBox1.Text);
                Write(MtxChanging.Mtx);
            }
        }

        private void OutputRandomRiggedMartix()
        {
            RiggedMtxChanging.FillRandom();
            Write(RiggedMtxChanging.Rigged);
        }

        private void OutputManualRiggedMartix()
        {
            RiggedMtxChanging.FillManual(richTextBox1.Text);
            Write(RiggedMtxChanging.Rigged);
        }
    }
}
