using System.Collections.Generic;

namespace Codecool.MissingDog.Model
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<Dog> Dogs { get; set; }

        public Owner(int id, string firstName, string lastName, string phoneNumber, string email, List<Dog> dogs)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            Dogs = dogs;
        }
    }
}