using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        //у класса point всегда 3 поля: координаты х у, и символ для отрисовки
        public int x;
        public int y;
        public char sym;


      
        public Point(int _x, int _y, char _sym )
        { 
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
            
        }

        public void MovePoint(int offset, Direction direction) //метод, сдвигающий точку по направлению direction
        {
            if(direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if(direction == Direction.UP)
            {
                y = y - offset;        
            }
            else if(direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public bool isHit(Point p) // простой метод, проверяющий совпадение координат 
        {
            return p.x == this.x && p.y == this.y;
        }
        public void Draw() // метод отрисовки точки
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear() //метод затирания ненужной точки
        {
            sym = ' ';
            Draw();
        }

    }
}
