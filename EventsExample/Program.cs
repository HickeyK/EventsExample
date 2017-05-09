using System;

namespace EventsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();

            worker.WorkDone += new WorkDoneEventHandler(Worker_WorkDone);
            worker.WorkComplete += new EventHandler(Worker_WorkComplete);

            worker.DoWork(10);
        }


        private static void Worker_WorkDone(int i)
        {
            Console.WriteLine("Done work {0}", i.ToString());
        }

        private static void Worker_WorkComplete(Object Sender, EventArgs e)
        {
            Console.WriteLine("Work Complete");
        }

    }
}
