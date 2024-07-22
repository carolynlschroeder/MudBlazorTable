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

        public void Update(Person model) {
            using var context = new ApplicationDbContext();
            Person person = context.Persons.FirstOrDefault(x => x.Id == model.Id);
            if (person != null)
            {
                person.FirstName = model.FirstName;
                person.LastName = model.LastName;
                person.Address = model.Address;
                person.Email = model.Email;
                context.SaveChanges();
            }

        }
    }

}
