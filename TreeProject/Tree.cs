using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    internal class Tree
    {
        public Node Head = null;
        public int count;

        public void Add(int Data)
        {
            Node newNode = new Node(Data);

            if (Head == null)
            {
                Head = newNode;
                count++;
            }
            else
            {
                AddAt(Head, Data);
            }
        }

        private void AddAt(Node Head, int Data)
        {
            if (Head.Data < Data) // Right
            {
                if (Head.Right == null)
                {
                    Head.Right = new Node(Data);
                    count++;
                }
                else
                {
                    AddAt(Head.Right, Data);
                }
            }
            else
            {
                if (Head.Left == null)
                {
                    Head.Left = new Node(Data);
                    count++;
                }
                else
                {
                    AddAt(Head.Left, Data);
                }
            }
        }

        public void InOrder()
        {
            InOrder(Head);
        }
        private void InOrder(Node Head)
        {
            if (Head != null)
            {
                InOrder(Head.Left);
                Console.Write(Head.Data + " ");
                InOrder(Head.Right);
            }
        }



        public void PreOrder()
        {
            PreOrder(Head);
        }

        private void PreOrder(Node Head)
        {
            if (Head != null)
            {
                Console.Write(Head.Data + " ");
                PreOrder(Head.Left);
                PreOrder(Head.Right);
            }
        }

        public void PostOrder()
        {
            PostOrder(Head);
        }
        private void PostOrder(Node Head)
        {
            if (Head != null)
            {
                PostOrder(Head.Left);
                PostOrder(Head.Right);
                Console.Write(Head.Data + " ");
            }
        }
    }
}
