namespace Lab5
{
    partial class MtxChanging
    {
        private static int[,] _mtx;
        public static int[,] Mtx
        {
            get { return _mtx; }
            set { _mtx = value; }
        }

        private static int _height;
        public static int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private static int _len;
        public static int Len
        {
            get { return _len; }
            set { _len = value; }
        }
    }
}
