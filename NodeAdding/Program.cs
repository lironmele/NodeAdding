using System;
using Unit4;

namespace NodeAdding
{
    class Program
    {
        static void Print (Node<int> p)
        {
            if (p.GetNext() == null)
                Console.WriteLine(p.GetValue());
            else
            {
                Console.Write($"{p.GetValue()}, " );
                Print(p.GetNext());
            }
        }
        static void Insert (Node<int> p, int value)
        {
            //throw new NotImplementedException();
            p.SetNext (new Node<int> (value, p.GetNext());
        }
        static void InsertAt (Node<int> head, int value, int place)
        {
            throw new NotImplementedException();
            // הנח שיש מקום כזה
        }
        static bool AddIfNotExist (Node<int> p, int x)
        {
            throw new NotImplementedException();
            //checks if number doesn't exist- adds at the end
        }
        static Node<int> Build(int[] ar)
        {
            throw new NotImplementedException();
        }
        static Node<int> AddSorted (Node<int> head)
        {
            throw new NotImplementedException();
        }
       
        static void Main(string[] args)
        {
            
        }
    }
}
