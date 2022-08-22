namespace Notes.Entities
{
    public class NoteItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public bool Checked { get; set; }

        public int NoteId { get; set; }

        public Note Note { get; set; }
    }
}