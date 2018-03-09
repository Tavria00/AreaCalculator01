using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaCalculator
{
    public class CalculateFigures
    {
        public string Calculate( object figure, decimal hight, decimal width, decimal radius, decimal length)
        {
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            Triangle triangle = new Triangle();
            Square square = new Square();
            string resString = String.Empty;
            decimal result = 0;

            switch (figure)  //ComboBox.Value
            {
                case Figures.Circle:
                    circle.Radius = radius;
                    result = circle.Calculate();
                    resString = "Площадь круга = " + result.ToString() + " см.кв" + "\r\n";
                    break;
                case Figures.Rectangle:
                    rectangle.Hight = hight;
                    rectangle.Width = width;
                    result = rectangle.Calculate();
                    resString = "Площадь прямоугольника = " + result.ToString() + " см.кв" + "\r\n";
                    break;
                case Figures.Triangle:
                    triangle.Hight = hight;
                    triangle.Width = width;
                    result = triangle.Calculate();
                    resString = "Площадь прямоугольного треугольника = " + result.ToString() + " см.кв" + "\r\n";
                    break;
                case Figures.Square:
                    square.Length = length;
                    result = square.Calculate();
                    resString = "Площадь квадрата = " + result.ToString() + " см.кв" + "\r\n";
                    break;
                case Figures.None:
                    if (length > 0)
                    {
                        square.Length = length;
                        result = square.Calculate();
                        resString = "Площадь квадрата = " + result.ToString() + " см.кв" + "\r\n";
                    }
                    if (radius > 0)
                    {
                        circle.Radius = radius;
                        result = circle.Calculate();
                        resString += "Площадь круга = " + result.ToString() + " см.кв" + "\r\n";

                    }
                    if (hight > 0 & width > 0)
                    {
                        rectangle.Hight = hight;
                        rectangle.Width = width;
                        triangle.Hight = hight;
                        triangle.Width = width;
                        result = rectangle.Calculate();
                        resString += "Площадь прямоугольника = " + result.ToString() + " см.кв" + "\r\n";
                        result = triangle.Calculate();                      
                        resString += "Площадь прямоугольного треугольника = " + result.ToString() + " см.кв" + "\r\n";
                    }
                    break;
            }


            return resString;
        }

    }

    public class Triangle : Figure
    {
        public decimal Hight;
        public decimal Width;

        public override decimal Calculate()
        {
            decimal hight = Hight;
            decimal width = Width;
            decimal result = hight * width / 2;

            return result;
        }
    }

    public class Square : Figure
    {
        public decimal Length;

        public override decimal Calculate()
        {
            decimal length = Length;
            
            decimal result = length * length;

            return result;
        }
    }

    public class Circle : Figure
    {
        public decimal Radius;

        public override decimal Calculate()
        {
            decimal radius = Radius;

            decimal result = radius * radius * (decimal)Math.PI;

            return result;
        }
    }

    public class Rectangle : Figure
    {
        public decimal Hight;
        public decimal Width;

        public override decimal Calculate()
        {
            decimal hight = Hight;
            decimal width = Width;
            decimal result = hight * width;

            return result;
        }
    }
}
