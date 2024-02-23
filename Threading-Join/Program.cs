using System;
using System.Threading;
class Program
{
    public static void Main()
    {
        //Creating the WorkerThread with the help of Thread class.    
        Thread ThreadObject1 = new Thread(WorkerThread);
        ThreadObject1.Start(); //Starting the Thread    
        //ThreadObject1.Join(); //Using Join to block the current Thread    
        Console.WriteLine("1. MainThread Started");
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine("-> MainThread Executing");
            Thread.Sleep(3000); //Here 5000 is 5000 Milli Seconds means 5 Seconds    
        }
        // We are calling the Name of Current running Thread using CurrentThread    
        Thread Th = Thread.CurrentThread;
        Th.Name = "Main Thread";
        Console.WriteLine("\nGetting the Name of Currently running Thread");
        //Name Property is used to get the name of the current Thread    
        Console.WriteLine($"Current Thread Name is: {Th.Name}");
        //Priority Property is used to display the Priority of current Thread    
        Console.WriteLine($"Current Thread Priority is: {Th.Priority}");
    }
    static void WorkerThread()
    {
        Console.WriteLine("2. WorkerThread Started");
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine("-> WorkerThread Executing");
            Console.WriteLine("Child Thread Paused");
            //Sleep method is used to pause the Thread for a specific period    
            Thread.Sleep(3000);
            Console.WriteLine("Child Thread Resumed");
        }
    }
}
