using System.Collections;
using System.Collections.Generic;

namespace Module11_Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList al = new ArrayList();
            al.Add("A");
            al.Add("B");
            al.Add("C");
            al.RemoveAt(0);
            al.Remove(al.Add("B"));

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(123);
            stack.Push(22);
            int t = (int)stack.Pop();

            Queue q = new Queue();
            q.Enqueue("A");
            q.Enqueue("B");
            q.Enqueue("C");
            string s = (string)q.Dequeue();

            Hashtable h = new Hashtable();
            h.Add("a", "lkjlk");
            h.Add("b", "hghghg");
            string ss = h["a"] as string;


            List<Hund> list = new List<Hund>();
            list.Add(new Hund() { Navn = "buller" });

            Hund hh = list[0];

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(3, "tre");
            dic.Add(4, "fire");

            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }


        }
    }
    class Hund
    {
        public string Navn { get; set; }
    }
}
