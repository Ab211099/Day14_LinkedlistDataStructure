using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructureDemo
{
    internal class UC3
    {
            Node head;
        public void AddEnd(int newData)
        {
            Node newNode = new Node(newData);

            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head; 
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        public void display()
        {
            Node temp = this.head;
            if (temp == null) ;
            {
                Console.WriteLine("Linked list is empty");
            }


            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }

        }
    }
}
