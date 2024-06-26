using Microsoft.EntityFrameworkCore;
using Person = MudBlazorTable.Models.Person;

namespace MudBlazorTable.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "PersonsDb");
        }
        public DbSet<Person> Persons { get; set; }
    }
}
