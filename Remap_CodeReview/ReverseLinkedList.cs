using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Remap_CodeReview
{
    internal class ReverseLinkedList
    {
        public Node head;
        public  void ReverseLnkedListElement(int data)
        {
           
            Node prev = null;
            Node current = head;
            Node next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

           
        }
        //public void Display()
        //{
        //    Node temp = head;
        //    while (temp != null)
        //    {
        //        Console.Write(temp.data + " ");
        //        temp = temp.next;
        //    }
        //}
    }
}
