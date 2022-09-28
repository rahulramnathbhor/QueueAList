using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StackAList
{
    public class Program
    {

        static void Main(string[] args)
        {
           // Queue<string> q = new Queue<string>();
           // q.Enqueue ("Sham");
           //q.Enqueue("Ram");
           // q.Enqueue("Shivam");
           // q.Enqueue("Amol");
           // //q.Dequeue();
           // //q.Dequeue();
           // q.Peek();   

           // foreach (var l in q)
           // {
           //     Console.WriteLine(l);
           // }
           // string[] names = new string[1];

            Queue<int> q1 = new Queue<int>();
            q1.Enqueue(1);
            q1.Enqueue(2);  
            q1.Enqueue(3);  
            q1.Enqueue(4);  
            q1.Enqueue(5);
            //  q1.Contains(6);
            Console.WriteLine( "Count Element in Queue:"+q1.Count());  
           // q1.Clear();
            //q1.Dequeue();
           // q1.Peek();
            foreach (var s in q1)
            {
                Console.WriteLine(s);
            }


        }

    }


}
