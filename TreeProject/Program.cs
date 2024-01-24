using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            //tree.Add(75);
            //tree.Add(57);
            //tree.Add(90);
            //tree.Add(32);
            //tree.Add(7);
            //tree.Add(44);
            //tree.Add(60);
            //tree.Add(86);
            //tree.Add(93);
            //tree.Add(99);


            tree.Add(18);
            tree.Add(20);
            tree.Add(16);
            tree.Add(5);
            tree.Add(17);
            tree.Add(19);
            tree.Add(70);
            tree.Add(60);
            tree.Add(85);

            Console.WriteLine("In Order");
            tree.InOrder();
            Console.WriteLine("\n");

            Console.WriteLine("Pre Order");
            tree.PreOrder();
            Console.WriteLine("\n");

            Console.WriteLine("Post Order");
            tree.PostOrder();
            Console.WriteLine("\n");


            Console.ReadKey();
        }
    }
}
