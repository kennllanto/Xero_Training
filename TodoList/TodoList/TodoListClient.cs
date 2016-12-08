using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class TodoListClient
    {
        static void Main(string[] args)
        {
            TodoListBusinessLayer.TodoListBusinessLayer businessLayer = new TodoListBusinessLayer.TodoListBusinessLayer();

            Console.WriteLine("Hello!");
            printOptions();

            bool runToDoList = true;
            var input = Console.ReadKey();
            do
            {
                Console.WriteLine();
                switch (input.Key)
                {
                    case (ConsoleKey.R):
                        Console.WriteLine(businessLayer.ReadList().ToString());
                        break;

                    case (ConsoleKey.A):
                        Console.Write("Enter task to be added:");
                        businessLayer.AddTask(Console.ReadLine());
                        Console.WriteLine();
                        break;

                    case (ConsoleKey.C):
                        Console.Write("Enter task to be completed:");
                        businessLayer.DeleteTask(Console.ReadLine());
                        Console.WriteLine();
                        break;

                    case (ConsoleKey.Q):
                        Console.WriteLine("Goodbye!");
                        runToDoList = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        printOptions();
                        break;

                }
                input = Console.ReadKey();
            } while (runToDoList);
        }

        public static void printOptions()
        {
            Console.WriteLine("Here are your options:");
            Console.WriteLine("r - read current your to do list");
            Console.WriteLine("a - add a new task");
            Console.WriteLine("c - complete a task and remove from your list");
            Console.WriteLine("q - to quit");
        }
    }
}
