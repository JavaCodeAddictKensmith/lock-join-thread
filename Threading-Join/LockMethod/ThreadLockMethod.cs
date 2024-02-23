using System;
using System.Threading;
namespace LockMethodThread1
{
	public class LockMethod1
	{
        
            //Creating a normal Method to Display Names    
            public void Display()
            {
                //Lock is used to lock-in the Current Thread    
                lock (this)
                {
                    for (int i = 0; i <= 3; i++)
                    {
                        Thread.Sleep(3000);
                        Console.WriteLine($"My Name is Abhishek{i}");
                    }
                }
            
        }
       
            public  void RunLocked()
            {
                //Creating object for LockExample1 Class as _locker so that we can access its Display Method    
                //LockExample1 _locker = new LockExample1();
                Console.WriteLine("Threading with the help of Lock");
                //Calling the Display Method using ThreadStart Delegate which is supplied to Thread constructor.    
                Thread t1 = new Thread(new ThreadStart(Display));
                Thread t2 = new Thread(new ThreadStart(Display));
                t1.Start(); //Starting Thread1    
                t2.Start(); //Starting Thread2    
            }
        
    }
}


