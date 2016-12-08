using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListBusinessLayer
{
    public class TodoListBusinessLayer
    {
        private TodoListDataLayer.TodoListDataLayer dataLayerObject = new TodoListDataLayer.TodoListDataLayer();

        List<string> blankList = new List<string> { "You have no items! Well done. I will create a new Todo list for you." };
        /// <summary>
        /// Reads your to do list
        /// </summary>
        /// <returns> A List containing strings of your to do tasks</returns>
        public List<string> ReadList()
        {
            try
            {
                List<string> toDoListContents = dataLayerObject.ReadData();
                if(toDoListContents == null)
                {
                    return blankList;
                }
                return toDoListContents;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while reading the file: '{0}'", e);
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskToAdd"></param>
        public void AddTask(string taskToAdd)
        {
            try
            {
                dataLayerObject.StoreData(taskToAdd);
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured while adding a new task: '{0}'", e);
            }
        }

        public void DeleteTask(string taskToDelete)
        {
            try
            {
                dataLayerObject.DeleteData(taskToDelete);
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while deleting a task: '{0}'", e);
            }
        }

    }
}
