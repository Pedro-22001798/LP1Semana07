namespace BetterFillSpheres
{
    class Sphere
    {
        private readonly Color color;
        private float radius;
        private int numThrow;

        public Sphere(Color newColor, float newRadius)
        {
            this.color = newColor;
            this.radius = newRadius;
            this.numThrow = 0;
        }

        public void Pop()
        {
            if(radius > 0)
            {
                radius = 0f;
                Console.WriteLine("Boom!");
            }
            else
            {
                Console.WriteLine("How do you want to pop a popped sphere?");
            }
        }

        public void Throw()
        {
            if(radius > 0)
            {
                numThrow++;
                Console.WriteLine("Ball thrown");
            }
            else
            {
                Console.WriteLine("That ball is popped");
            }
        }

        public int GetTimesThrown() => numThrow;
    }
}