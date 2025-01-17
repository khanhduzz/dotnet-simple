public class TwoAsynOperation
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Asynchronous Operation: ");

        DateTime startTime = DateTime.Now;
        Console.WriteLine("Start time: " + startTime);
        Task<string> res1 = RunTask1();
        Console.WriteLine("Task 1 start, it will take 2s to complete");
        Task<string> res2 = RunTask2();
        Console.WriteLine("Task 2 start, it will take 2s to complete");

        string result1 = await res1;
        string result2 = await res2;

        DateTime endTime = DateTime.Now;
        Console.WriteLine(result1);
        Console.WriteLine(result2);

        Console.WriteLine("End time: " + endTime);

        Console.WriteLine("Total time taken: " + (endTime - startTime));

    }

    public static async Task<string> RunTask1()
    {
        return await Task.Run(() =>
        {
            Task.Delay(2000).Wait();
            return "Task 1 done!";
        }
        );
    }

    public static async Task<string> RunTask2()
    {
        return await Task.Run(() =>
        {
            Task.Delay(2000).Wait();
            return "Task 2 done!";
        }
        );
    }
}