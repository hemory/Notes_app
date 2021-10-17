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

        public override string ToString()
        {
            return $"Title: {Title} Message: {Message}";
        }
    }
}