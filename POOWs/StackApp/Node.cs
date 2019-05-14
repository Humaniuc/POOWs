namespace StackApp
{
    class Node
    {
        private int data;
        private Node next;

        internal int Data
        {
            get { return data; }
            set { data = value; }
        }
        internal Node Next
        {
            get { return next; }
            set { next = value; }
        }

        internal Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
