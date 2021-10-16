using System;

namespace Week3
{
    public interface IMyQueue
    {
        void Empty();

        MyQueue Enqueue(int element);
        
        int Top();

        MyQueue Dequeue();

        bool IsEmpty();
    }


    public class MyQueue : IMyQueue
    {
        public MyQueue Dequeue()
        {
            throw new NotImplementedException();
        }

        public void Empty()
        {
            throw new NotImplementedException();
        }

        public MyQueue Enqueue(int element)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public int Top()
        {
            throw new NotImplementedException();
        }
    }
}