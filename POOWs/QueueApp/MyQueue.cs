using System;

namespace QueueApp
{
    class MyQueue
    {
        Node first;
        Node last;

        internal MyQueue()
        {
            first = last = null;
        }

        internal void Enqueue(int elem)
        {
            Node newNode = new Node(elem);
            if(last == null)
            {
                first = last = newNode;
            }
            else
            {
                last.Next = newNode;
                last = newNode;

            }
        }
        internal void Dequeue()
        {
            if(first == null)
            {
                Console.WriteLine("The queue is empty");
                return;
            }

            Node temp = first;
            first = first.Next;

            if(first == null)
            {
                last = null;
            }

            Console.WriteLine($"Item deleted: {temp.Data}");
        }
            
        internal void Print()
        {
            Node nod = first;
            while(nod != null)
            {
                Console.WriteLine($"{nod.Data}");
                nod = nod.Next;
            }
        }
    }

    
}
