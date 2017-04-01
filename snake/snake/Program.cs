using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{

    class Program
    {

        static void Main(string[] args)
        {

            Rectangle rect = new Rectangle(1, 1, 80, 25, '#');
            Point p = new Point(35, 17, '*');
            Snake snake = new Snake(p, 3, Directions.RIGHT);

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }else
                {
                    snake.Move();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.handleKey(key.Key);

                }
                Thread.Sleep(300);
                snake.Move();
            }
        }
    }
}