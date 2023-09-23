using System;

namespace Codecool.MissingDog.Model
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Breed Breed { get; set; }
        public Owner Owner { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsSociable { get; set; }
        public bool IsMale { get; set; }

        public Dog(int id, string name, Breed breed, Owner owner, DateTime dateOfBirth, bool isSociable, bool isMale)
        {
            Id = id;
            Name = name;
            Breed = breed;
            Owner = owner;
            DateOfBirth = dateOfBirth;
            IsSociable = isSociable;
            IsMale = isMale;
        }

    }
}
