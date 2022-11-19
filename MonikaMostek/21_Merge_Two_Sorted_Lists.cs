using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace Merge_Two_Sorted_Lists
{
    internal class Program
    {
       
        public class MyList
        {
            public Node root;
            public int length;
            
            public class Node
            {
                public int data;
                public Node next;

                public Node(int data)
                {
                    this.data = data;
                }
                public void setNext(Node n)
                {
                    this.next = n;
                }
            }
            public void addNode(int data)
            {
                Node newNode = new Node(data);
                if (this.root == null)
                {
                    this.root = newNode;
                    length++;
                }
                else
                {
                    Node tmp = root;
                    while (true)
                    {
                        if (tmp.next == null)
                        {
                            break;
                        }
                       tmp = tmp.next;
                    }
                    tmp.setNext(newNode);
                    length++;
                }
            }
            public void writeList()
            {
                Node tmp = root;
                while (tmp != null)
                {
                    Console.Write(tmp.data+" ");
                    tmp = tmp.next;
                }
            }
        }

        static void Main(string[] args)
        {
            

            MyList list1 = new MyList();
            MyList list2 = new MyList();
            MyList list3 = new MyList();

            list1.addNode(1);
            list1.addNode(3);
            list1.addNode(4);
            list1.addNode(6);
            list1.addNode(9);

            list2.addNode(2);
            list2.addNode(4);
            list2.addNode(7);
            list2.addNode(11);

            MyList.Node tmp1 = list1.root;
            MyList.Node tmp2 = list2.root;
            MyList.Node tmp3 = list3.root;

            while(true)
            {
                if(tmp1.data >= tmp2.data || tmp2?.next==null)
                {
                    list3.addNode(tmp2.data);
                    tmp2 = tmp2.next;
                }
                else if (tmp1.data < tmp2.data || tmp1?.next == null)
                {
                    list3.addNode(tmp1.data);
                    tmp1 = tmp1.next;
                }
                if(tmp1?.next == null && tmp2?.next == null)
                {
                    break;
                }
            }

            list3.writeList();
            Console.ReadLine();
        }
    }
}
