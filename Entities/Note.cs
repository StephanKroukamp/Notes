using System.ComponentModel.DataAnnotations.Schema;

namespace Notes.Entities
{
    public class Note
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}
