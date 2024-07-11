namespace Kohde.Assessment
{
    // Cat class inheriting from Animal and implementing GetDetails method
    public class Cat : Animal
    {
        public string Food { get; set; }

        public override string GetDetails()
        {
            return $"Name: {Name}, Age: {Age}, Food: {Food}";
        }
    }
}