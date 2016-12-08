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
        private enum updateType
        {
            append , replaceAll , deleteAll
        }
        private List<string> fileContents = new List<string>();
        const string toDoListFileName = "todolist.txt";
        static string fileFolder = Directory.GetCurrentDirectory();
        string filePath = fileFolder + "\\" + toDoListFileName;

        public TodoListDataLayer()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                fileContents = lines.ToList();
            }
        }

        /// <summary>
        /// Add a task on the todo list file
        /// </summary>
        /// <param name="textToWrite"></param>
        /// <returns></returns>
        public bool StoreData(string taskToWrite)
        {
            List<string> temporaryList = new List<string>();
            temporaryList.Add(taskToWrite);            

            fileContents.Add(taskToWrite);
            UpdateToDoList(temporaryList, updateType.append);
            return true;
        }

        /// <summary>
        /// Reads the todolist
        /// </summary>
        /// <returns> List containing all data </returns>
        public List<String> ReadData()
        {
            return fileContents;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskTobeDeleted"></param>
        /// <returns></returns>
        public bool DeleteData(string taskTobeDeleted)
        {
            fileContents.Remove(taskTobeDeleted);
            UpdateToDoList(fileContents, updateType.replaceAll);
            return true;
        }

        public bool DeleteAllData()
        {
            fileContents.Clear();
            UpdateToDoList(fileContents, updateType.deleteAll);
            return true;
        }

        private bool UpdateToDoList(List <string> dataToAdd, updateType updateAction)
        {
            switch (updateAction)
            {
                case (updateType.append):
                    File.AppendAllLines(filePath, fileContents);
                    break;

                case (updateType.replaceAll):
                    File.Delete(filePath);
                    //File.Create(filePath + toDoListFileName);
                    File.AppendAllLines(filePath, fileContents);
                    break;

                case (updateType.deleteAll):
                    File.Delete(filePath);
                    break;

                default:
                    throw new Exception("Invalid action for UpdateDate()");
            }
            return true;
        }

    }
}
