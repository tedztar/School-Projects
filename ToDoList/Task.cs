namespace ToDoList
{
    class Task
    {
        //Class properties
        private int id;
        private string task;

        //Class constructors
        public Task(int id, string task)
        {
            this.id = id;
            this.task = task;
        }

        //Methods
        //Setters and Getters
        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getTask()
        {
            return this.task;
        }

        public void setTask(string task)
        {
            this.task = task;
        }

        public string toString()
        {
            return "id: " + this.id + ". Task: " + this.task;
        }
    }
}
