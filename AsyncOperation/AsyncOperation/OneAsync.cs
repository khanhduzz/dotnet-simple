public class AsynOperation
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Asynchronous Operation: ");

        Task<string> res = RunTask();
        Console.WriteLine("Main Task Start running, it will take 5s to finish...");

        Console.WriteLine("This part will appear, does not wait for the main task done, because it async, we can run some another tasks");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Task " + i + " run");
            Task.Delay(1000).Wait();
        }

        string result = await res;
        Console.WriteLine(result);

        Console.WriteLine("Finish!!!");

    }

    public static async Task<string> RunTask()
    {
        return await Task.Run(() =>
        {
            Task.Delay(5000).Wait();
            return "Main Task done!";
        }
        );
    }
}