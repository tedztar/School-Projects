using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTest2017
{
    class Assessment
    {
        //1: Properties
        //TASK 2:
        private string paperName;
        private string assessmentName;
        private int mark;

        //2: Constructors
        //Task 3:
        public Assessment(string paperName, String assessmentName, int mark)
        {
            this.paperName = paperName;
            setAssessmentName(assessmentName);
            setMark(mark);
        }

        public Assessment(string paperName, string assessmentName) : this(paperName, assessmentName, 0) { }

        public Assessment(string paperName) : this(paperName, "Assessment") { }
        //3: Methods
        public string getAssessmentName()
        {
            return this.assessmentName;
        }
        public void setAssessmentName(String assessmentName)
        {
            if (assessmentName != "")
            {
                this.assessmentName = assessmentName;
            }
            else
            {
                this.assessmentName = "Assessment";
            }
        }
        public int getMark()
        {
            return this.mark;
        }
        public void setMark(int mark)
        {
            if (mark>=0 && mark <= 100)
            {
                this.mark = mark;
            }
            else
            {
                this.mark = 0;
            }
            
        }
        //paperName
        public string getPaperName()
        {
            return this.paperName;
        }
        public void setPaperName(string paperName)
        {
            this.paperName = paperName;
        }
    }
}
