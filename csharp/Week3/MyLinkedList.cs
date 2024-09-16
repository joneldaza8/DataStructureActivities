using System;

namespace Week3
{
    public interface IMyLinkedList
    {
        MyLinkedList EmptyList();

        void MakeList(int element);
        
        Node First();

        MyLinkedList Rest();

        bool IsEmpty();

        MyLinkedList ReplaceFirst(int element);

        MyLinkedList ReplaceLast(int element);
    }

    public class MyLinkedList : IMyLinkedList
    {
        public MyLinkedList EmptyList()
        {
            throw new NotImplementedException();
        }

        public Node First()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public void MakeList(int element)
        {
            throw new NotImplementedException();
        }

        public MyLinkedList ReplaceFirst(int element)
        {
            throw new NotImplementedException();
        }

        public MyLinkedList ReplaceLast(int element)
        {
            throw new NotImplementedException();
        }

        public MyLinkedList Rest()
        {
            throw new NotImplementedException();
        }
    }

    public class Node
    {
        public Node Next { get; set; }
        
        public int Data { get; set; }

        public Node Current { get; set; }
    }

}