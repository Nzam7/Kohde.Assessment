namespace Kohde.Assessment
{
    // Abstract base class defining common properties and methods
    public abstract class Animal : IAnimal
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public abstract string GetDetails();
    }
}
