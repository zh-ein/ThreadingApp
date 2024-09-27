using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using System.Threading;

namespace ThreadingApp
{
    class MyThreadClass
    {
        public static void Thread1()
        {
            for (int loopCount = 0; loopCount < 2; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                Thread.Sleep(500);
            }
            int threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"The thread 0x{threadId} has exited with code 0 (0x0).");
        }

        public static void Thread2()
        {
            for (int loopCount = 0; loopCount < 6; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                Thread.Sleep(1500);
            }
            int threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"The thread 0x{threadId} has exited with code 0 (0x0).");
        }
    }
}