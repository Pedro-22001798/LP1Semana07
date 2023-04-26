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
    }
}