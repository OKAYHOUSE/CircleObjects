using System;
namespace CircleObjects
{
    public class Circle
    {
        public double radius;

        //Constructor
        public Circle(double _radius)
        {
            radius = _radius;
        }
        //Prompts user to enter a radius; user may enter a decimal number.
        //Calculate circumference and area.
        //calculate the circumference
        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }

        //calculate the area
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        private string FormatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
        }
        public string CalculateFormattedCircumference()
        {

            return FormatNumber(CalculateCircumference());
        }

        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());

        }
    }
}

//public Circle(double radius)
//public double CalculateCircumference()
//public double CalculateArea()
//private string FormatNumber(double x)
//public string CalculateFormattedCircumference()
//public string CalculateFormattedArea()
