using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {

        static void Main(string[] args)
        {
          
            LinkedList<int> intlinked = new LinkedList<int>();
            LinkedList<int> addlist = new LinkedList<int>();

            List<int> mylist = new List<int>();
            List<int> addList = new List<int>();


            for (int J = 0; J < 5; J++)
            {
                mylist.Add(J);
            }
            IEnumerator<int> Listenumerator = mylist.GetEnumerator();
            Console.WriteLine("list is ------------------");
            while (Listenumerator.MoveNext())
            {
                Console.WriteLine(Listenumerator.Current);
            }

            
            for (int K  = 15; K < 20; K ++)
            {
                addList.Add(K);
            }
            IEnumerator<int> AddListenumerator = addList.GetEnumerator();
            Console.WriteLine("add list is ------------------");
            while (AddListenumerator.MoveNext())
            {
                Console.WriteLine(AddListenumerator.Current);
            }

            Console.WriteLine("after add is -------------");
            IEnumerable<int> AddListIEnumerable = addList.AsEnumerable();
            mylist.AddRange(AddListIEnumerable);

            IEnumerator<int> FinalList = mylist.GetEnumerator();
            while (FinalList.MoveNext())
            {
                Console.WriteLine(FinalList.Current);
            }

            Console.WriteLine("Linked List -------------");

            for (int i = 195; i < 200; i++)
            {
                addlist.AddFirst(i);
            }

            for (int i = 0; i < 10; i++)
            {
                intlinked.AddFirst(i);
            }
            IEnumerator<int> enumerator = intlinked.GetEnumerator();
            while (enumerator.MoveNext()) {
                Console.WriteLine(enumerator.Current);
            }
            Console.WriteLine();
            LinkedListNode<int> listNode = intlinked.Find(5);
            Console.WriteLine(listNode.Value);

            IEnumerator<int> addenumerator = addlist.GetEnumerator();
            while (addenumerator.MoveNext()) {
                Console.WriteLine(addenumerator.Current);
                intlinked.AddAfter(listNode, addenumerator.Current);
            }

            Console.WriteLine("----------------------after insert new list in");
            IEnumerator<int> Newenumerator = intlinked.GetEnumerator();
            while (Newenumerator.MoveNext())
            {
                Console.WriteLine(Newenumerator.Current);
            }

        }
    }
}
