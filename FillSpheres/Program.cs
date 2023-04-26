namespace FillSpheres
{
    class Program 
    {         
        static void Main(string[] args)
        {
            Color red = new Color(255,0,0,255);
            Sphere sphere1 = new Sphere(red,5f);

            Color blue = new Color(0,0,255,255);
            Sphere sphere2 = new Sphere(blue,3f);

            Color green = new Color(0,255,0,255);
            Sphere sphere3 = new Sphere(green,10f);

            sphere1.Pop();
            sphere2.Throw();
            sphere3.Throw();
            sphere3.Throw();

            Console.WriteLine($"Sphere2 was thrown {sphere2.GetTimesThrown()} times and Sphere3 was thrown {sphere3.GetTimesThrown()} times");
            
        }
    }
}