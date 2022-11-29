namespace Lab5
{
    partial class Form1
    {
        private void Write(int[] arr)
        {
            if (arr != null) richTextBox1.Text = "[" + string.Join(" ", arr) + "]";
        }

        private void Write(int[,] matrix)
        {
            if (matrix != null)
            {
                string line = "";
                for (int i = 0; i < matrix.GetLength(0); ++i)
                {
                    for (int j = 0; j < matrix.GetLength(1); ++j)
                    {
                        if (j != matrix.GetLength(1) - 1) line += matrix[i, j].ToString() + " ";
                        else line += matrix[i, j].ToString();
                    }
                    if (i != matrix.GetLength(0) - 1) line += "\n";
                }
                richTextBox1.Text = "[" + line + "]";
            }
        }

        private void Write(int[][] rigged)
        {
            if (rigged != null)
            {
                string line = "";
                for (int i = 0; i < rigged.Length; ++i)
                {
                    for (int j = 0; j < rigged[i].Length; ++j)
                    {
                        if (j != rigged[i].Length - 1) line += rigged[i][j].ToString() + " ";
                        else line += rigged[i][j].ToString();
                    }
                    if (i != rigged.Length - 1) line += "\n";
                }
                richTextBox1.Text = "[" + line + "]";
            }
        }
    }
}
