namespace MudBlazorTable.Models
{

    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string Email { get; set; } = default!;
    }
}