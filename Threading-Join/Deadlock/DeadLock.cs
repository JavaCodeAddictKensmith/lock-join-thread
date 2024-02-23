using System;
using System.Threading;
namespace DeadlocksDemo
{
    public class DeadLock
    {
        static readonly object Lock1 = new object();
        static readonly object Lock2 = new object();
        static void Display()
        {
            Console.WriteLine("Trying to lock Locker1");
            lock (Lock1)
            {
                Console.WriteLine("Locked Locker1");
                Thread.Sleep(1000);
                Console.WriteLine("Locking Locker2");
                lock (Lock2)
                {
                    Console.WriteLine("Locked Locker2");
                }
                Console.WriteLine("Released Locker2");
            }
            Console.WriteLine("Released Locker1");
        }
        public void RunDeadLock()
        {
            new Thread(new ThreadStart(Display)).Start();
            Thread.Sleep(1000);
            Console.WriteLine("Trying to lock Locker2");
            lock (Lock2)
            {
                Console.WriteLine("Locked Locker2");
                Console.WriteLine("Locking Locker1");
                lock (Lock1)
                {
                    Console.WriteLine("Locked Locker1");
                }
                Console.WriteLine("Released Locker1");
            }
            Console.WriteLine("Released Locker2");
            Console.Read();
        }
    }
}
