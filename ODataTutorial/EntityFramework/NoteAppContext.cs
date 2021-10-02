using Microsoft.EntityFrameworkCore;
using ODataTutorial.Entities;

namespace ODataTutorial.EntityFramework;

public class NoteAppContext : DbContext
{
    public DbSet<Note> Notes { get; set; }

    public NoteAppContext(DbContextOptions<NoteAppContext> options) : base(options)
    {

    }
}