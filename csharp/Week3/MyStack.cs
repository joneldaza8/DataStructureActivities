using System;

namespace Week3
{
    public interface IMyStack
    {
        void Empty();

        void Push(int element);

        int Top();

        MyStack Pop();

        bool IsEmpty();

    }

    public class MyStack : IMyStack
    {
        public void Empty()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public MyStack Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(int element)
        {
            throw new NotImplementedException();
        }

        public int Top()
        {
            throw new NotImplementedException();
        }
    }

}