using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue mq = new MyQueue();

            mq.Enqueue(10);
            mq.Enqueue(18);
            mq.Enqueue(20);
            mq.Enqueue(5);
            mq.Enqueue(9);
            mq.Print();

            mq.Dequeue();
            mq.Print();
        }
    }
}
