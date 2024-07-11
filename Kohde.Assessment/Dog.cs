namespace Kohde.Assessment
{
    // Dog class inheriting from Animal and implementing GetDetails method
    public class Dog : Animal
    {
        public string Food { get; set; }

        public override string GetDetails()
        {
            return $"Name: {Name}, Age: {Age}, Food: {Food}";
        }
    }
}