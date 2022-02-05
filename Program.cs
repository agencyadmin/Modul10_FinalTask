namespace Final_Task_10_5_1;

 public interface  IAddition 
{
    string Addition(string A, string B);
};

class Program
{
   static ILogger Logger { get; set; }

    static void Main()
    {
        Logger = new Logger();
        var worker1 = new Worker1(Logger);
        var worker2 = new Worker2(Logger);
        var worker3 = new Worker3(Logger);

        worker1.Work();
        worker2.Work();
        worker3.Work();

        Console.ReadKey();
    }

}

public interface ILogger
{
    public void Event(string message);
    public void Error(string message);
}
public interface IWorker
{
    void Work();
}
public class Logger : ILogger
{
    public void Error(string message)
    {
       Console.WriteLine(message);
    }

    public void Event(string message)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
    }
}


