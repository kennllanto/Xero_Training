using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldBusinessLayer.HelloWorldBusinessLayer businessHelloWorld = new HelloWorldBusinessLayer.HelloWorldBusinessLayer();
            string helloWorldText = businessHelloWorld.GetHelloWorld();
            Console.WriteLine(helloWorldText);

            Console.ReadKey();
        }
    }
}
