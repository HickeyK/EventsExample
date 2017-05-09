using System;

namespace EventsExample
{

    public delegate void WorkDoneEventHandler(int i);

    class Worker
    {

        public event WorkDoneEventHandler WorkDone;
        public event EventHandler WorkComplete;


        public void DoWork(int i)
        {
            for (int count = 0; count < i; count++)
            {
                OnWorkDone(count);
            }
            OnWorkCompleted();
        }


        protected virtual void OnWorkDone(int i)
        {
            var del = WorkDone as WorkDoneEventHandler;
            if (del != null)
            {
                del(i);
            }
        }

        protected virtual void OnWorkCompleted()
        {
            var del = WorkComplete as EventHandler;
            if (del != null)
            {
                del(this, EventArgs.Empty);
            }
        }




    }
}
