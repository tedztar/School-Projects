using System;
using System.Collections.Generic;

namespace NoteBookApp
{
    class noteCollection
    {
        //properties
        private List<Note> noteList = new List<Note>();
        //constructors
        public noteCollection()
        {
            this.noteList = new List<Note>();//Initialize an empty list
        }
        //methods
        //method listAll(): list information of all notes in the collection
        public string listAll()
        {
            //declare a variable to store all info for the collection
            string allNotes = "";
            //loop through all notes in the collection
            foreach(Note note in noteList)
            {
                allNotes += note.toString();
            }
            //Return value
            return allNotes;
        }

        //method add(): add new note to the collection
        public void add(Note newNote)
        {
            this.noteList.Add(newNote);
        }
        //method update(): update an existing note
        public void update()
        {

        }
        //method delete)(: delete an existing note
        public void delete()
        {

        }
    }
}
