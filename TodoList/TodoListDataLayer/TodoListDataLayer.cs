using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListDataLayer
{
    public class TodoListDataLayer
    {
        private List<string> fileContents;
        const string toDoListFileName = "todolist.txt";

        public TodoListDataLayer()
        {
            string path = Directory.GetCurrentDirectory();
            string[] lines = File.ReadAllLines(path + toDoListFileName);
            fileContents =  lines.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="textToWrite"></param>
        /// <returns></returns>
        public bool StoreData(string textToWrite)
        {
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
            streamWriter.WriteLine(textToWrite);
            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();

            fileStream.Open
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool ReadData()
        {
            StreamReader r = new StreamReader(fs, Encoding.UTF8);
            Console.WriteLine(r.ReadLine());
            return true;
        }

        public bool DeleteData()
        {
            return true;
        }

    }
}
