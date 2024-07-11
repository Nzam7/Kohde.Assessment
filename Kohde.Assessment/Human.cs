namespace Kohde.Assessment
{
    // Human class inheriting from Animal and implementing GetDetails method
    public class Human : Animal
    {
        public string Gender { get; set; }

        public override string GetDetails()
        {
            return $"Name: {Name}, Age: {Age}, Gender: {Gender}";
        }
        public override string ToString()
        {
            return GetDetails();
        }
    }
}