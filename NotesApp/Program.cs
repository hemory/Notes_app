using System;
using System.Collections.Generic;

namespace NotesApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Note> notes = new List<Note>();
            Note note = new Note("Whats up", "Greet");
            
            notes.Add(note);

           var val = NotesAction.EditNote("Greet", notes, "Hello");

          
        }
    }
}