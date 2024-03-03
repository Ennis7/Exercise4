namespace Exercise4;
abstract class Student
{
    //properties
    public abstract int Id { get; set; }
    public abstract String FirstName { get; set; }
    public abstract String LastName { get; set; }

    //method
    public abstract string StudentInfo();
    public string FullName()
    {
        return FirstName + " " + LastName;
    }
}
//class 
class Program
{
    //properties
    class Schedule : Student
    {
        public string Course { get; set; }
        public int Credits { get; set; }

        //default constructor
        public Schedule()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Course = string.Empty;
            Credits = 0;
        }
        //parameterized constructor
        public Schedule (int id, string firstName, string lastName, string course, int credits)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Course = course;
            Credits = credits;
        }
        public override int Id { get; set; }
        public override string FirstName { get; set; }
        public override string LastName { get; set; }

        public override string StudentInfo()
        {
            return "\nStudent Info: " + "\nID: " + Id + "\nName: " + FullName() + "\nCourse: " + Course + "\nCredits: " + Credits;
        }
    }
    static void Main(string[] args)
    {
        //Object default constructor
        Schedule sarah = new Schedule();
        sarah.Id = 231;
        sarah.FirstName = "Sarah";
        sarah.LastName = "Ann";
        sarah.Course = "Application Development";
        sarah.Credits = 3;
        Console.WriteLine(sarah.StudentInfo());
        Console.WriteLine();

        //Object parameterized constructor
        Schedule lily = new Schedule(643, "Lily", "Faye", "2-D Design", 3);
        Console.WriteLine(lily.StudentInfo());
        Console.WriteLine();
        Console.ReadKey();
    }
}

