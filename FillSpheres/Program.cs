namespace FillSpheres
{
    class Program 
    {         
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
        }
    }

    class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        public Color(byte newRed, byte newGreen, byte newBlue, byte newAlpha)
        {
            this.red = newRed;
            this.green = newGreen;
            this.blue = newBlue;
            this.alpha = newAlpha;
        }

        public Color(byte newRed, byte newGreen, byte newBlue)
        {
            this.red = newRed;
            this.green = newGreen;
            this.blue = newBlue;
            this.alpha = 255;
        }

        public byte GetRed() => red;
        public byte GetGreen() => green;
        public byte GetBlue() => blue;
        public byte GetAlpha() => alpha;

        public void SetRed(byte newRed)
        {
            red = newRed;
        }

        public void SetGreen(byte newGreen)
        {
            green = newGreen;
        }

        public void SetBlue(byte newBlue)
        {
            blue = newBlue;
        }

        public void SetAlpha(byte newAlpha)
        {
            alpha = newAlpha;
        }

        public byte GetGrey()
        {
            int grey = (red + green + blue) / 3;
            return (byte)grey;
        }
    }
}