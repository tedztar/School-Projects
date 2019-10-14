using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTest2017
{
    class Tracker
    {
        //Task $:
        //1: Properties
        private List<Assessment> listOfAssessment;
        private int maxAssessment;

        //2: Constructors
        public Tracker(int maxAssessment)
        {
            this.listOfAssessment = new List<Assessment>();
            this.maxAssessment = maxAssessment;
        }
        public Tracker() : this(12) { }

        //3: Methods
        //TASK 5
        public string add(Assessment newAssessment)
        {
            if (this.listOfAssessment.Count > 12)
            {
                return "tracker is full. Assessment can't be added";
            }
            else
            {
                listOfAssessment.Add(newAssessment);
                return "Assessment has been adde3d successfully!";
            }
        }
        //Task 6
        public double average()
        {
            //Loop throught all assessments to find the avarage
            double sum = 0;
            foreach(Assessment assessment in listOfAssessment)
            {
                sum += assessment.getMark();
            }
            returhn sum / listOfAssessment.Count;
        }
        //Task7
        public string list(string paperName)
        {
            string result = "";
            //Loop through all assessments relebant to this paper
            foreach(Assessment assessment in listOfAssessment)
            {
                //Check if the assessment belongs to the paperName
                if (assessment.getPaperName() == paperName)
                {
                    result += assessment.getAssessmentName() + ": " + assessment.getMark();
                }
            }
            //return
            if(result = "")
            {
                return "Paper not found";
            }
            else
            {
                return result;
            }
        }
    }
}
