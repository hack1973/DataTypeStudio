using System;

namespace DataTypeStudio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a 'radius' in miles to compute the area, circumference and diameter of a circle: ");
            string userRadius = Console.ReadLine();
            float radius = float.Parse(userRadius);

            Console.WriteLine("Please enter the 'MPG' of your car to compute the gallons of gas used to go around the circumference of a circle: ");
            string userMpg = Console.ReadLine();
            float mpg = float.Parse(userMpg);

            double area = Math.PI * Math.Pow(radius,2);
            double circumference = 2 * Math.PI * radius;
            double diameter = 2 * radius;
            double gallonsOfGas = circumference / mpg;

            Console.WriteLine("The area of a circle with a radius of " + radius + " is " + area + ".");
            Console.WriteLine("The circumference of a circle with a radius of " + radius + " is " + circumference + ".");
            Console.WriteLine("The diameter of a circle with a radius of " + radius + " is " + diameter + ".");
            Console.WriteLine("The gallons of gas used to drive around a circle with a radius of " + radius + " miles is " + gallonsOfGas + ".");
        }
    }
}
