using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldBusinessLayer
{
    /// <summary>
    /// 
    /// </summary>
    public class HelloWorldBusinessLayer
    {
        public string GetHelloWorld()
        {
            HelloWorldDataLayer.HelloWorldDataLayer db= new HelloWorldDataLayer.HelloWorldDataLayer();
            string helloWorldText = db.GetHelloWorld();
            return helloWorldText;
        }
    }
}
