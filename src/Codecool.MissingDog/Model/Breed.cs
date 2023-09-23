namespace Codecool.MissingDog.Model
{
    public class Breed
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ActivityLevel { get; set; }

        public Breed(string name, int activityLevel, int id)
        {
            Name = name;
            ActivityLevel = activityLevel;
            Id = id;
        }
    }
}