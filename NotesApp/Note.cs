using System;

namespace NotesApp
{
    public class Note
    {
        public string Message { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public Note(string message, string title)
        {
            Message = message;
            Title = title;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Title: {Title} Message: {Message} Date Created: {Date.ToShortDateString()}";
        }
    }
}