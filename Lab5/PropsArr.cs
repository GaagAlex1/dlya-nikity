namespace Lab5
{
    public partial class ArrayChanging
    {
        private static int[] _arr;
        public static int[] Arr
        {
            get { return _arr; }
            set { _arr = value; }
        }

        private static int _len;
        public static int Len
        {
            get { return _len; }
            set { _len = value; }
        }
    }
}
