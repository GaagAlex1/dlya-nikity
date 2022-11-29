using System;
using System.Linq;

namespace Lab5
{
    partial class RiggedMtxChanging
    {
        private static Random random = new Random();

        public static void FillRandom()
        {
            Height = random.Next(2,6);
            Rigged = new int[Height][];

            for (int i = 0; i < Height; ++i)
            {
                CurrentLen = random.Next(3, 9);
                Rigged[i] = new int[CurrentLen];

                for (int j = 0; j < CurrentLen; ++j)
                {
                    Rigged[i][j] = random.Next(-10, 10);
                }
            }
        }

        public static void FillManual(string reference)
        {
            string line = "";
            int row = 0;
            CountHeight(reference);
            Rigged = new int[Height][];

            foreach (char c in reference)
            {
                if (c == '\n')
                {
                    CountLen(line);
                    Rigged[row] = new int[CurrentLen];
                    AddRow(row, line);
                    row++;
                    line = "";
                }
                else line += c;
            }

            CountLen(line);
            Rigged[row] = new int[CurrentLen];
            AddRow(row, line);
        }

        private static void CountHeight(string reference)
        {
            Height = reference.Count(f => f == '\n') + 1;
        }

        private static void CountLen(string line)
        {
            CurrentLen = line.Count(f => f == ' ') + 1;
        }

        private static void AddRow(int row, string line)
        {
            string[] items = line.Split(' ');

            for (int x = 0; x < CurrentLen; ++x)
            {
                _rigged[row][x] = Convert.ToInt32(items[x]);
            }
        }

        public static void AddLineFromKeyboard(int row, string keyboardInput)
        {
            string[] items = keyboardInput.Split(' ');
            Resize(row, items.Length);
            Rigged[row] = new int[items.Length];

            for (int j = 0; j < items.Length; ++j)
            {
                Rigged[row][j] = Convert.ToInt32(items[j]);
            }
        }

        private static void Resize(int row, int size)
        {
            int[][] riggedCopy = Rigged;
            ++Height;
            Rigged = new int[Height][];

            for (int i = 0; i < Height; ++i)
            {
                if (i != row) Rigged[i] = riggedCopy[i - Convert.ToInt32(i > row)];
                else Rigged[i] = new int[size];
            }
        }
    }
}
