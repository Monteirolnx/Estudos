
var custumer = new Custumer()
{
    FirstName = "Luis",
    LastName = "Monteiro",
    Age = 40
};

Console.WriteLine(custumer.ToString());

Console.ReadLine();

public class Custumer
{
    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public required int Age { get; set; }

    public override string ToString()
    {
        return $"FirstName: {FirstName}, LastName: {LastName}, Age: {Age}";
    }
}   