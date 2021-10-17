namespace NotesApp
{
    public class Note
    {
        public string Message { get; set; }
        public string Title { get; set; }

        public Note(string message, string title)
        {
            Message = message;
            Title = title;
        }
    }
}