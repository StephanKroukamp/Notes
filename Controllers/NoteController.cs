using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Notes.Data;
using Notes.Entities;
using Notes.Models;

namespace Notes.Controllers
{
    public class NoteController : Controller
    {
       private DataContext _context;

        public NoteController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Note> notes = _context.Notes.Include(n => n.NoteItems).ToList();

            return View(notes);
        }

        public IActionResult Create()
        {
            Note note = new Note
            {
                Title = "New Note",
                CreatedDate = DateTimeOffset.Now
            };

            _context.Notes.Add(note);

            _context.SaveChanges();

            return Redirect("/Note/Index");
        }

        public IActionResult Edit(int noteId)
        {

            return Redirect("/Note/Index");
        }

        public IActionResult Delete(int noteId)
        {

            return Redirect("/Note/Index");
        }

        public IActionResult CreateNoteItem(int noteId)
        {
            var stop = "";

            NoteItem noteItem = new NoteItem
            {
                NoteId = noteId,
                Title = "New Note Item",
                Checked = false,
                CreatedDate = DateTimeOffset.Now
            };

            _context.NoteItems.Add(noteItem);

            _context.SaveChanges();

            return Redirect("/Note/Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}