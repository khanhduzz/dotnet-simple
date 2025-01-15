public class NewtonJson
{
    public static void Main(string[] args)
    {
        var person = new
        {
            Name = "John",
            Age = 30
        };

        var personJson = Newtonsoft.Json.JsonConvert.SerializeObject(person);

        Console.WriteLine(personJson);
    }
}