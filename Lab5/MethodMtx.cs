using System;
using System.Linq;

namespace Lab5
{
    partial class MtxChanging
    {
        private static Random random = new Random();
        
        public static void FillRandom()
        {
            for (int i = 0; i < Height; ++i)
            {
                for (int j = 0; j < Len; ++j)
                {
                    _mtx[i, j] = random.Next(-10, 10);
                }
            }
        }

        public static void FillManual(string reference)
        {
            string line = "";
            int row = 0;
            CountParams(ref reference);
            Mtx = new int[Height,Len];

            foreach (char c in reference)
            {
                if (c == '\n')
                {
                    AddRow(row, line);
                    row++;
                    line = "";
                } else line += c;
            }
            AddRow(row, line);
        }

        private static void AddRow(int row, string line)
        {
            string[] input = line.Split(' ');

            for (int x = 0; x < input.Length; ++x)
            {
                _mtx[row, x] = Convert.ToInt32(input[x]);
            }
        }

        private static void CountParams(ref string reference)
        {
            Height = reference.Count(f => f == '\n') + 1;
            Len = 0;
            string[] rows = reference.Split('\n');
            foreach (string row in rows)
            {
                Len = Math.Max(Len, row.Count(f => f == ' ') + 1);
            }
            FixMtx(ref reference, rows);
        }

        private static void FixMtx(ref string reference, string[] rows)
        {
            reference = "";
            for (int i = 0; i < rows.Length; ++i)
            {
                AddZeros(ref rows[i]);
                if (i != rows.Length - 1) reference += rows[i] + "\n";
                else reference += rows[i];
            }
        }

        private static void AddZeros(ref string line)
        {
            if (line.Count(f => f == ' ') + 1 < Len)
            {
                int size = line.Count(f => f == ' ') + 1;
                for (int i = 0; i < Len - size; ++i)
                {
                    line += " 0";
                }
            }
        }

        public static void DeleteColumnsWithZero()
        {
            for (int j = 0; j < Len; ++j)
            {
                for (int i = 0; i < Height; ++i)
                {
                    if (Mtx[i, j] == 0)
                    {
                        --Len;
                        DeleteColumn(j);
                        --j;
                        break;
                    }
                }
            }
        }

        private static void DeleteColumn(int columnNumber)
        {
            for (int j = columnNumber; j < Len; ++j)
            {
                for (int i = 0; i < Height; ++i)
                {
                    Mtx[i,j] = Mtx[i,j+1];
                }
            }
            Resize();
        }

        private static void Resize()
        {
            int[,] mtxCopy = Mtx;
            Mtx = new int[Height, Len];
            for (int i = 0; i < Height; ++i)
            {
                for (int j = 0; j < Len; ++j)
                {
                    Mtx[i, j] = mtxCopy[i, j];
                }
            }
        }
    }
}
