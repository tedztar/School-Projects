using System;

namespace NoteBookApp
{
    class Note
    {
        //Properties
        private string title;
        private string text;
        private DateTime timestamp;

        //Constructors
        public Note(string title, string text)
        {
            this.title = title;
            this.text = text;
            this.timestamp = DateTime.Now;
        }
        //create the second contractor that had only 1 parameter: "title'
        public Note(string title) : this(title, "") { }

        //create the third constgructor: no parameter
        public Note() : this("untitle") { }

        //Methods
        //Method toString()
        public string toString()
        {
            return this.title + "" + this.text + "" + this.timestamp;
        }
        //setters and setters
        public string getTitle()
        {
            return this.title;
        }
        public void setTitle(string title)
        {
            this.title = title;
        }
        public string getText()
        {
            return this.text;
        }
        public void setText(string text)
        {
            this.text = text;
        }
        public string getTimeStamp()
        {
            return this.timestamp.ToString();
        }
    }
}
