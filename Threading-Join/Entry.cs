using System;
using DeadlocksDemo;
using JoInInThread;

using LockMethodThread1;

namespace Threading_Join
{
	public class Entry
	{
		public static void  Main(string[] args)

		{
            ///Run Join
            ThreadJoin fs = new ThreadJoin();
			//fs.RunJoin();
			DeadLock deadLock = new DeadLock();

			//Run deadlock
			//deadLock.RunDeadLock();
           LockMethod1 lo = new LockMethod1();

			//Run locked
			lo.RunLocked();




        }
	}
}

