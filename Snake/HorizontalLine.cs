using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{ //горизонтальная линия является частным случаем Figure
    class HorizontalLine : Figure
    {

        public HorizontalLine(int x0, int Length, int y, char sym)
        {
            newList = new List<Point>();
            for(int x= x0; x<Length; x++)
            {
                Point p = new Point(x, y, sym);
                newList.Add(p);
            }
        }
     
    }
}
