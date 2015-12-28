using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure //Класс, от которого наследуются горизонтальные и вертикальные линии, сама змейка
    {
       protected List<Point> newList;

        public void DrawLine()
        {
            foreach (Point p in newList)
            {
                p.Draw();
            }
        }
    }
}
