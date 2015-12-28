using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
     
        static void Main(string[] args)
        {

            //отрисовка рамки
            Border border = new Border(80, 25, '*');
            //отрисовка змейки
            Point p1 = new Point(15, 10, '+');
            Snake snake = new Snake(p1, 5, Direction.RIGHT);
            snake.DrawLine();

            //генерация точки с едой
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Console.ForegroundColor = ConsoleColor.Red;
            Point food = foodCreator.CreateFood();
            food.Draw();
            Console.ForegroundColor = ConsoleColor.White;

            while (true)
            {
                try
                {
                    if(snake.Eat(food))//omnomnomnom
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        food = foodCreator.CreateFood();
                        food.Draw();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        snake.MoveSnake();
                    }
                    Thread.Sleep(100);
                    if (Console.KeyAvailable)
                    {

                        ConsoleKeyInfo key = Console.ReadKey(); //получаем нажатие и обрабатываем
                        snake.ManualControl(key);
                    }
                   
                   
                }

                catch (Exception e) //вылет по столкновению
                {
                    Console.Clear();
                    Console.Write("Game Over");
                    break;
                }
            }

           Console.ReadLine();
        }


      
 
    }
}
