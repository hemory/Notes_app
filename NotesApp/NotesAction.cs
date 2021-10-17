using System.Collections.Generic;

namespace NotesApp
{
    public static class NotesAction
    {
        
        public static bool EditNote(string title, List<Note> notes, string newMessage)
        {
            Note noteToUpdate = GetNoteByTitle(notes, title);
            
            if (noteToUpdate != null)
            {
                noteToUpdate.Message = newMessage;
                return true;
            }

            return false;
        }
        
        public static bool RemoveNote(string title, List<Note> notes)
        {
            Note noteToRemove = GetNoteByTitle(notes, title);

            if (noteToRemove != null)
            {
                notes.Remove(noteToRemove);
                return true;
            }

            return false;
        }

        public static Note GetNoteByTitle(List<Note> notes, string title)
        {
            foreach (var note in notes)
            {
                if (note.Title.ToLower() == title.ToLower())
                {
                    return note;
                }
            }
            
            return null;
        }
        
        
    }
}