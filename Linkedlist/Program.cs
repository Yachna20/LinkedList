
using System.Collections.Generic;

namespace Linkedlist
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Addnode(56);
            list.Addnode(30);
            list.Addnode(70);
            list.Display();
            list.Delete();
            list.Display();
        }
    }
}
