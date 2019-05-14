using System;

namespace StackApp
{
    class myStack
    {
        Node top;

        internal myStack()
        {
            top = null;
        }

        internal void Push(int elem)
        {
            Node newNode = new Node(elem);
            if(top == null)
            {
                newNode.Next = null;
            }
            else
            {
                newNode.Next = top;
            }
            top = newNode;
        }

        internal void Pop()
        {
            if(top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Console.WriteLine($"Poped node is {top.Data}");
            top = top.Next;
        }

        internal void Print()
        {
            Node nod = top;
            while(nod != null)
            {
                Console.WriteLine($"{nod.Data}");
                nod = nod.Next;
            }
        }
    }
}
