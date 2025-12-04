public class Student
{
    private int age;
    private string name;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty.");
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 3 || value > 120)
                throw new ArgumentOutOfRangeException("Invalid age.");
            age = value;
        }
    }
}
