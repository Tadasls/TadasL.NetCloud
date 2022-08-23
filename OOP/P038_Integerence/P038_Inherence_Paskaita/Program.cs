namespace P038_Inheritance
{

    //Base class (Parrent class)
    public class Polygon
    {
        public Polygon()
        {
            NumberOfAngles = 0;
        }

        public Polygon(int numberOfAngles)
        {
            NumberOfAngles = numberOfAngles;
        }

        public int NumberOfAngles { get; set; }

        public virtual double GetPerimeter() //virtual pasako kad paveldetoje klaseje galima metoda perrašyti
        {
            return 0;
        }

    }

    //Derived Classes
    public class Square : Polygon
    {
        public Square()
        {
            NumberOfAngles = 4;
        }

        public Square(double size)
        {
            Size = size;
            NumberOfAngles = 4;
        }

        public double Size { get; set; }

        public override double GetPerimeter()
        {
            return NumberOfAngles * 4;
        }
    }

    //Derived Classes
    public class Triangle : Polygon
    {
        public Triangle() : base(3) { }

        public override double GetPerimeter()
        {
            return NumberOfAngles + 10;
        }
    }






    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Inheritance");
            Square square = new Square();
            Console.WriteLine("NumberOfAngles in Square =" + square.NumberOfAngles);
            Console.WriteLine("Size in square =" + square.Size);
            Triangle triangle = new Triangle();
            Console.WriteLine("NumberOfAngles in Triangle = " + triangle.NumberOfAngles);


            Square square1 = new Square(555);
            Console.WriteLine("NumberOfAngles in square1 =" + square1.NumberOfAngles);
            Console.WriteLine("Size in square1 =" + square1.Size);
            Console.WriteLine("Perimeter in square1 =" + square1.GetPerimeter());


            Polygon square2 = new Square(444);
            if (square2 is Square)
            {
                Console.WriteLine("Size in square2 =" + ((Square)square2).Size);
                Console.WriteLine("Size in square2 =" + (square2 as Square).Size);
            }
            Polygon polygon1 = new Triangle();
            if (polygon1 is Square)
            {
                Console.WriteLine("Size in polygon1 =" + ((Square)polygon1).Size);
            }


            List<Polygon> polygons = new List<Polygon>();
            polygons.Add(square);
            polygons.Add(triangle);
            polygons.Add(square2);
            foreach (var item in polygons)
            {
                Console.WriteLine(item.NumberOfAngles);
                if (item is Square)
                {
                    Console.WriteLine("Size" + ((Square)item).Size);
                }
            }



        }
    }
}