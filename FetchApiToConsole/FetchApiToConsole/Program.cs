public class FetchJson
{
    static async Task Main(string[] args)
    {
        using HttpClient client = new HttpClient();
        string url = "https://jsonplaceholder.typicode.com/todos/1";

        Console.WriteLine("Fetching data...");
        string response = await client.GetStringAsync(url);

        Console.WriteLine("Response:");
        Console.WriteLine(response);
    }
}   