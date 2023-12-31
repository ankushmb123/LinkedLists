﻿using LinkedList;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class ListData
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;

                }
                temp.next = node;
            }
        }
        public void InsertAtPosition(int position, int data)
        {
            int count = 0;
            Node node = new Node(data);
            count++;
            if (head == null)
            {
                head = node;
            }


            if (position == 0)
            {
                node.next = head;
                head = node;
                return;
            }
            Node prev = null;
            Node current = head;

            while (current != null && count <= position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            node.next = prev.next;
            prev.next = node;
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}