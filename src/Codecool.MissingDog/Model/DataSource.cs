using Codecool.MissingDog.Model;
using System.Collections.Generic;

namespace Codecool.MissingDog.Repository
{
    public class DataSource
    {
        public List<Dog> Dogs { get; set; }
        public List<Owner> Owners { get; set; }
        public List<Breed> Breeds { get; set; }

        public DataSource()
        {
            Dogs = new List<Dog> { };
            Owners = new List<Owner> { };
            Breeds = new List<Breed> { };
        }
    }
}
