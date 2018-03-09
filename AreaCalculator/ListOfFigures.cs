using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaCalculator
{
    public class ListOfFigures
    {
        public List<Figures> listOfFigures = new List<Figures>()
        {
            Figures.None,
            Figures.Circle,
            Figures.Rectangle,
            Figures.Square,
            Figures.Triangle
            
        };
    }
    public enum Figures
    {
        None,
        Rectangle,
        Triangle,
        Circle,
        Square
    }
}
