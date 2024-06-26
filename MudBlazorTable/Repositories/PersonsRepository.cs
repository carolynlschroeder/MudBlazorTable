using MudBlazorTable.Data;
using MudBlazorTable.Services;
using MudBlazorTable.Models;

namespace MudBlazorTable.Repositories
{
    public class PersonsRepository
    {

        public PersonsRepository(FakeDataManager manager)
        {
            using var context = new ApplicationDbContext();
            List<Person> persons = manager.GeneratePersonData().ToList();
            context.Persons.AddRange(persons);
            context.SaveChanges();
        }

        public List<Person> Get()
        {
            using var context = new ApplicationDbContext();
            return context.Persons.ToList();
        }
    }

}
