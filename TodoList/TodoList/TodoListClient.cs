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
                        Console.WriteLine("---------------------------------------------------------------------");
                        Console.WriteLine("Current todo list:");
                        foreach (var task in businessLayer.ReadList())
                        {
                            Console.WriteLine(task);
                        }
                        Console.WriteLine("---------------------------------------------------------------------");
                        break;

                    case (ConsoleKey.A):
                        Console.Write("Enter task to be added: ");
                        businessLayer.AddTask(Console.ReadLine());
                        Console.WriteLine("Task Added.");
                        break;

                    case (ConsoleKey.C):
                        Console.Write("Enter task to be completed: ");
                        businessLayer.DeleteTask(Console.ReadLine());
                        Console.WriteLine("Task Completed.");
                        break;

                    case (ConsoleKey.Q):
                        Console.WriteLine("Goodbye!");
                        runToDoList = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input. Please try again. ");
                        printOptions();
                        break;

                }
                input = Console.ReadKey();
            } while (runToDoList);
        }

        public static void printOptions()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("X  Here are your options:                                           X");
            Console.WriteLine("X  r - read current your to do list                                 X");
            Console.WriteLine("X  a - add a new task                                               X");
            Console.WriteLine("X  c - complete a task and remove from your list                    X");
            Console.WriteLine("X  q - to quit                                                      X");
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}
