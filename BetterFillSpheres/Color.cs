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

        public string Name
        {
            get
            {
                return (Red,Blue,Green) switch
                {
                    {Red:255,Blue:0,Green:0} => "Red 100%",
                    {Red:0,Blue:255,Green:0} => "Blue 100%",
                    {Red:0,Blue:0,Green:255} => "Green 100%",
                    _ => "Mixed"
                };
            }
        }
    }
}