using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{//вертикальная линия является частным случаем фигуры
    class VerticalLine : Figure
    {
       

        public VerticalLine(int x, int y0, int Length, char sym)
        {
            newList = new List<Point>();
            for(int y = y0; y<Length; y++)
            {
                Point p = new Point(x, y, sym);
                newList.Add(p);
            }
        }
   
    }
}
