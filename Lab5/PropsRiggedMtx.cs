namespace Lab5
{
    partial class RiggedMtxChanging
    {
        private static int[][] _rigged;

        public static int[][] Rigged
        {
            get { return _rigged; }
            set { _rigged = value; }
        }

        private static int _height;

        public static int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private static int _current_len;

        public static int CurrentLen
        {
            get { return _current_len; }
            set { _current_len = value; }
        }
    }
}
