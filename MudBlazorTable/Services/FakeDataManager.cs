using System;
using Bogus;
using Person = MudBlazorTable.Models.Person;

namespace MudBlazorTable.Services
{
    public class FakeDataManager
    {
        public const int NumberOfPersons = 50;

        public IEnumerable<Person> GeneratePersonData()
        {
            var persons = new Faker<Person>()
                .RuleFor(p => p.Id, _ => Guid.NewGuid())
                .RuleFor(p => p.FirstName, f => f.Name.FirstName())
                .RuleFor(p => p.LastName, f => f.Name.LastName())
                .RuleFor(p => p.Address, f => f.Address.FullAddress())
                .RuleFor(p => p.Email, (f, e) => f.Internet.Email(e.FirstName, e.LastName))
                .Generate(NumberOfPersons);

            return persons;
        }
    }
}
