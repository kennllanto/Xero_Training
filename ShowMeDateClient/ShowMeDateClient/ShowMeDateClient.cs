using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeDateClient
{
    /// <summary>
    /// Interface class to user that display current Date
    /// </summary>
    class ShowMeDateClient
    {
        static void Main(string[] args)
        {
            ShowMeDateBusiness.ShowMeDateBusiness businessLayer = new ShowMeDateBusiness.ShowMeDateBusiness();
            Console.WriteLine("Current Date: {0} " , businessLayer.GetDate().ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
