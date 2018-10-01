using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPracticeTutorial
{
    public class LinkedList //declare class public first
    {
        /*constructor
         * Linkedlist() - initializes the private field 
         * 
         * pribate fields:
         * 
         * [*] node head - it is a rference to the First node in the list
         * [*] int size - the current size of the list
         * 
         * public properties
         * [] empty - if the list is empty- returns true /false
         * [] count- returns size (how many items in the list)
         * [] index - allows to access the data like an array
         * eg:
         * int[] a;
         * a[1]; 
         * 
         * Mehthods:
         * [] Add (int index, object 0)- add an item to the list at the specified index
         * []Add (object o) - Add an item to the end of the list 
          * []Remove(int index) Removes the item in the list a the specified index
         * 
         * []Clear()- clear the list
         * [] IndexOf(object 0)- gets the index of the item in the list, if not in the list-returns -1
         * []Contains(object o)- returns true / false if the list contains that object 
         * [] Get(int index) - gets/returns the item at the specified index
         * 
         * 
         * */

        private Node head;
        private int count;

        //constructor- initializes the private fields
        public LinkedList()//takes no parameter
        {
            this.head = null; //because it does not point anything
            this.count = 0; //because there is cuurently no items in the list
        }
        //implement empty public property and count public property
        public bool Empty
        {
            get { return this.count == 0; }
        }
        public int Count
        {
            get { return this.count; }
        }

        //add method adds the items /data into the list
        public object Add(int index, object o)
        {
            //make sure the index that we pass in is within our list
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }
            if (index > count)
            {
                index = count;
            }
            Node current = this.head;//indicates current node is the head node

            if (this.Empty || index == 0)
            {
                this.head = new Node(o, this.head);
            }
            else
            {
                for(int i = 0; i < index -1; i++)
                {
                    current = current.Next;
                    current.Next = new Node(o, current.Next);
                }
            }
            count++;
            return o;
        }
        public object Add(object o)
        {
            return this.Add(count, o);
        }
        public object Remove(int index)
        {
            if(index < 0)
            {
                throw new ArgumentOutOfRangeException("Inded: " + index);

            }
            if (this.Empty)
                return null;
            if (index > this.count)
                index = count - 1;

            Node current = this.head;
            object result = null;

            if(index == 0) // iif removing the first node
            {
                result = current.Data;
                this.head = current.Next;
            }
            else
            {
                for(int i = 0; i < index -1; i++)
                {
                    current = current.Next;
                }
                result = current.Next.Data;
                current.Next = current.Next.Next;
            }
            count--;
            return result;
        }
        public void Clear()
        {
            //remove the reference to first node, which clears all
            this.head = null;
            this.count = 0;
        }
        public int IndexOf(object o)
        {
            Node current = this.head;
            for(int i = 0; i < this.count; i++)
            {
                if(current.Data.Equals(o))
                {
                    return i;
                }
                current = current.Next;
            }
            return -1;
        }
        public bool Contains(object o)
        {
            return this.IndexOf(o) >= 0;
        }
    }

}
