using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPracticeTutorial
{
    public class Node //normally make the class public
    {
        /*
         * needs constructor (we need two things)
         * [] Node (it is object data) , and Node which is reference to the next node)
         * 
         * private fields 
         * object data- contents the data of the node, what we want to store i the field
         * 
         *  Node next - reerence to the nestt node in the list
         *  
         *  
         *  publlic properties
         * [] Data - get set the data field
         * [] Next - get and set the next field
         * 
         * */

        private object data;
        private Node next; //going to be the reference of the next node in the list

        //constructor
        public Node(object data, Node next)
        {
            this.data = data;
            this.next = next;
        }
        //implement the public properties
        public object Data
        {
            get{return this.data;}
            set{this.data = value;}
        }
        //implement the data through next node
        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
