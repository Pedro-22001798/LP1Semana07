namespace BetterFillSpheres
{
    class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        public Color(byte newRed, byte newGreen, byte newBlue, byte newAlpha)
        {
            Red = newRed;
            Green = newGreen;
            Blue = newBlue;
            Alpha = newAlpha;
        }

        public Color(byte newRed, byte newGreen, byte newBlue)
        {
            Red = newRed;
            Green = newGreen;
            Blue = newBlue;
            Alpha = 255;
        }

        public byte Red
        {
            get
            {
                return red;
            }
            set
            {
                red = value;
            }
        }

        public byte Green
        {
            get
            {
                return green;
            }
            set
            {
                green = value;
            }            
        }

        public byte Blue
        {
            get
            {
                return blue;
            }
            set
            {
                blue = value;
            }            
        }

        public byte Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                alpha = value;
            }            
        }

        public byte Grey
        {
            get
            {
                int grey = (red + green + blue) / 3;
                return (byte)grey;
            }
        }
    }
}