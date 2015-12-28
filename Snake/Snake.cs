using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Direction direction;
        public Snake(Point tail, int length, Direction _direction)  
        {
            newList = new List<Point>();
            direction = _direction;
            for(int i = 0; i< length; i++)
            {
                Point p = new Point(tail);
                p.MovePoint(i, direction);
                newList.Add(p);
            }
        }

        public void MoveSnake() //метод, "двигающий" змейку на поле
        {
           Point tail = newList.First();
           newList.Remove(tail);
           Point head = GetNextPoint();
           newList.Add(head);

           tail.Clear();//затирание ненужной точки
           head.Draw();
           
        }

        public Point GetNextPoint()
        {
            Point head = newList.Last();
            Point nextPoint = new Point(head);
            nextPoint.MovePoint(1, direction);

            return nextPoint;
        }

        public void ManualControl(ConsoleKeyInfo key)
        {
            
            if (key.Key == ConsoleKey.LeftArrow)
            { direction = Direction.LEFT; }
            else if (key.Key == ConsoleKey.RightArrow)
            { direction = Direction.RIGHT; }
            else if (key.Key == ConsoleKey.UpArrow)
            { direction = Direction.UP; }
            else if (key.Key == ConsoleKey.DownArrow)
            { direction = Direction.DOWN; }
        }

        public bool Eat(Point food) //добавление съеденой точки в новую точку змейки
        {
            Point head = GetNextPoint();
            if(head.isHit(food))
            {
                food.sym = head.sym;
                newList.Add(food);
                return true;
            }
            
            return false;
        }
    }
}
