using Microsoft.EntityFrameworkCore;
using Notes.Entities;

namespace Notes.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public DbSet<NoteItem> NoteItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Notepad;Integrated Security=True");
        }
    }
}