using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        List<Shape> shapes = new List<Shape>();

        Square MySquare = new Square("Red", 3);
        shapes.Add(MySquare);

        Circle Mycircle = new Circle("Pink", 44);
        shapes.Add(Mycircle);

        Rectangle MyRectangle = new Rectangle("Blue", 34, 55);
        shapes.Add(MyRectangle);

        foreach (Shape m in shapes)
        {
            string color = m.Getcolor();

            double area= m.GetArea();
            Console.WriteLine($"the color is:{color} and it has an area of :{area}");

        }
     
    }

}