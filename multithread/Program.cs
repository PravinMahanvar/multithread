using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace multithread
{
    public class ThreadDemo
    {
        // Task 1
        public void First()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
        //Task 2
        public void Second()
        {
            for (int i = 6; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }

    }

    public class program
    {
        static void Main(string[] args)
        {
            ThreadDemo first = new ThreadDemo();
            //create thread
            // allocate method ref to the ThreadStart delegate
            Thread t1 = new Thread(new ThreadStart(first.First));
            Thread t2 = new Thread(new ThreadStart(first.Second));

            //req to cpu
            t2.Priority = ThreadPriority.Highest;
            t1.Priority = ThreadPriority.AboveNormal;
            t1.Start();
           // t1.Join();
            t1.Join(1000);
            t2.Start();

        }
    }
}
