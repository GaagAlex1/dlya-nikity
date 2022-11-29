using System;

namespace Lab5
{
    public partial class ArrayChanging
    {
        private static Random random = new Random();

        public static void FillRandom()
        {
            for (int i = 0; i < Len; i++)
            {
                _arr[i] = random.Next(-10, 10);
            }
        }

        public static void FillManual(string reference)
        {
            string[] input = reference.Split(' ');

            Len = input.Length;
            Arr = new int[Len];

            for (int i = 0; i < Len; ++i)
            {
                _arr[i] = Convert.ToInt32(input[i]);
            }
        }

        private static void Resize(int k)
        {
            int[] arrCopy = _arr;
            _arr = new int[2 * k + _arr.Length];
            for (int i = k; i < k + arrCopy.Length; i++)
            {
                _arr[i] = arrCopy[i-k];
            }
        }

        public static void AddItems(string input)
        {
            string[] items = input.Split(' ');
            int k = items.Length;
            int lenCopy = _arr.Length;
            Resize(k);
            for (int i = 0; i < k; ++i)
            {
                _arr[i] = Convert.ToInt32(items[i]);
            }
            for (int i = k + lenCopy; i < _arr.Length; ++i)
            {
                _arr[i] = Convert.ToInt32(items[i-(k+lenCopy)]);
            }
        }
    }
}
