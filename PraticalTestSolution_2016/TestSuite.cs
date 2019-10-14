using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticalTestSolution_2016
{
    class TestSuite
    {
        //1: Properties
        //Task 4
        private List<test> tests;
        private int maxTestNumber;

        //2: Constructors
        public TestSuite(int maxTestNumber)
        {
            tests = new List<test>();
            this.maxTestNumber = maxTestNumber;
        }
        public TestSuite() : this(50) { }

        //3: Methods
        //TASK 5
        public string add(test newTest)
        {
            //Find the next available value for id
            int id = tests.Count + 1;
            //Check if the number if test reaches the max value
            if (id > 50)
            {
                return "Testsuite is full. Can't add a new test";
            }
            else
            {
                //update the id to the newTest
                newTest.setId(id);
                tests.Add(newTest);
                return "Test with ID " + id + " has been added!";
            }
        }
        //Task 6:
        public string update(int id, bool passed)
        {
            if(id>=1 && id <= tests.Count)
            {
                //Find the test with the id "id" and update the passes status
                tests.ElementAt(id - 1).setPassed(passed);
                return "Test with ID= " + id + " set to " + passed.ToString();
            }
            else
            {
                //The test with the id "id" doesn't ecist
                return " test with ID= " + id + " Does not exist";
            }
        }
        //Task 7:
        public string report()
        {
            string result = "";
            int failed = 0;
            int passed = 0;
            //Loop through all tests in the tests List
            foreach(test test in tests)
            {
                //check if the test status is PASSED or FAILED
                if(test.getPassed() == true)
                {
                    passed++;
                }
                else
                {
                    failed++;
                }
                result += "Test with ID = " + test.getId() + "Description: " + test.getDescription() + ": " + test.getPassed().ToString();
            }
            return result + "\n" + failed*100/(failed+passed) + "%" + " " + passed*100/(failed+ passed) + "%";
        }
    }
}
