namespace Notes.Entities
{
    public class Note
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public ICollection<NoteItem> NoteItems{get; set;}
    }
}