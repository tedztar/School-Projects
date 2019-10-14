using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticalTestSolution_2016
{
    class test
    {
        //1: Properties
        //TASK2
        private int id;
        private string description;
        private bool passed;

        //2: Construcvtors
        //Task 3:
        public test(string description, bool passed)
        {
            this.description = description;
            this.passed = passed;
            this.id = -1;
        }
        public test(string description) : this(description, false) { }
        public test(): this("new test"){}

        //3: Methods: Getters and setters
        public int getId()
        {
            return this.id;
        }
        public void setId(int id)
        {
            //Check if the id has been set or not
            if (this.id == -1)
            {
                this.id = id;
            }
        }
        public bool getPassed()
        {
            return this.passed;
        }
        public string getDescription()
        {
            return this.description;
        }
        public void setPassed(bool passed)
        {
            this.passed = passed;
        }
    }
}
