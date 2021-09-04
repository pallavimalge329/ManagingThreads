using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ManagingThreads
{

    class Program
    {

        public static void childthreadcall1()
        {
            try
            {
                Console.WriteLine("Child thread called");
                Thread.Sleep(5000);

                for (int i = 1; i <= 5; i++)
                {

                    Console.WriteLine(i);


                }
                Console.WriteLine("Waking up");
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Unable to handle");
            }
        }

        public static void childthreadcall2()
        {
            try
            {
                Console.WriteLine("Child thread called");
                Thread.Sleep(5000);

                for (int i = 11; i <= 15; i++)
                {

                    Console.WriteLine(i);


                }
                Console.WriteLine("Waking up");
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Unable to handle");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=======Creation of Our Main Thread=========");
            Console.WriteLine("Calling child thread");

            //it is a reference to the method
            ThreadStart ts1 = new ThreadStart(childthreadcall1);

            Thread th1 = new Thread(ts1);             // it is unstarted / ready mode

            th1.Start();                     // runnable mode 
            th1.Join();


            ThreadStart ts2 = new ThreadStart(childthreadcall2);
            Thread th2 = new Thread(ts2);
            th2.Start();




            th2.Join();


            Console.WriteLine("===========Main Ends here======");
            Console.ReadKey();
        }
    }
}


