using System.Diagnostics;

public class Exemple

    // Thread - Creates and controles a thread, and gets its status. Is a unit of execution within a process.
{
    public static void Main(string[] args)
    {
        var th = new Thread(ExecuteInForground);
        th.Start();
        Thread.Sleep(1000);
        Console.WriteLine("Main thread ({0}) exiting....", Thread.CurrentThread.ManagedThreadId);
    }

    private static void ExecuteInForground()
    {
        var sw = Stopwatch.StartNew();
        Console.WriteLine("Thread {0}: {1}, Priority {2}",
            Thread.CurrentThread.ManagedThreadId,
            Thread.CurrentThread.ThreadState,
            Thread.CurrentThread.Priority);

        do
        {
            Console.WriteLine("Thread {0}: Elapsed {1:N2} seconds",
                Thread.CurrentThread.ManagedThreadId,
                sw.ElapsedMilliseconds / 1000.0);
            Thread.Sleep(500);
        }
        while (sw.ElapsedMilliseconds <= 5000);
        sw.Stop();
    }
}
