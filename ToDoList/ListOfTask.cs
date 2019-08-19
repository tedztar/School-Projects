using System.Collections.Generic;

namespace ToDoList
{
    class ListOfTask
    {
        //Class properties
        private List<Task> taskList = new List<Task>();
        
        //Class contructors
        public ListOfTask()
        {
            this.taskList = new List<Task>();
        }

        //Class methods
        public List<Task> getList()
        {
            return this.taskList;
        }
        public void setList(List<Task> taskList)
        {
            this.taskList = taskList;
        }
        //view() method; return all tasks information
        public string view()
        {
            //delare the string to store all tasks info
            string taskInfo = "";
            //loop all tasks in the list and appens it to the taskInfo cvariable
            foreach(Task task in taskList)
            {
                taskInfo += task.toString();//use toString method of the Task cl;ass to get task info
            }
            //return taskInfo
            return taskInfo;
        }
        //Add() method: add a new task to the list
        public void add(Task newTask)
        {
            this.taskList.Add(newTask);
        }

        //update() method: update an existing task in the list
        public void update(Task updateTask)
        {
            //Loop through all existing tasks in the list to see if the task exists
            bool foundTask = false;
            Task foundTaskObject = null;
            foreach(Task task in taskList)
            {
                //Check if the task is equal to updateTask or Not?
                if (task.getId() == updateTask.getId())
                {
                    foundTask = true;
                    foundTaskObject = task;
                    break;
                }
                if (foundTask == true){
                    //Remove the old object
                    this.taskList.Remove(foundTaskObject);
                    //Add the updateObject
                    this.taskList.Add(updateTask);
                }
            }
        }

        //delet() method: delete an existing task in the list
        public void delete(Task deleteTask)
        {
            this.taskList.Remove(deleteTask);
        }
    }
}
