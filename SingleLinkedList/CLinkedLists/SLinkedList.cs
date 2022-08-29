using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SingleLinkedList.CLinkedLists
{
    internal class SLinkedList
    {
        CustomNode.CustomNode head;
        CustomNode.CustomNode current;
        string data;
        int nodeCount;

        public void appendNode(string data)
        {
            //if the list is empty make a node call it head
            if (head == null)
            {
                head = new CustomNode.CustomNode(data);
                nodeCount++;
                return;
            }
            current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new CustomNode.CustomNode(data);
        }
        public void prepend(string data)
        {
            if (head == null)
            {
                head = new CustomNode.CustomNode(data);
            }
            else
            {
                CustomNode.CustomNode newHead = new CustomNode.CustomNode(data);
                nodeCount++;

                newHead.Next = head;

                head = newHead;
            }
        }
        public void printList()
        {
            CustomNode.CustomNode current = head;
            while (current!=null)
            {
                DialogResult dialogResult = MessageBox.Show(current.data, "Showing the nodes in order that they are", MessageBoxButtons.OK);
                current = current.Next;

            }
        }
        //https://social.msdn.microsoft.com/Forums/vstudio/en-US/4023c2fc-7b35-4622-9571-db2013d70567/delete-node-from-a-linked-list?forum=csharpgeneral
        public void DeleteNode(string data)
        {
            if (head.data == data)
            {
                head = head.Next;
            }
            else
            {
                CustomNode.CustomNode removed = Find(data);
                if (removed.Next != null)
                    removed.Next = removed.Next.Next;
                else
                    MessageBox.Show("The give element is not found in the list");
            }
        }
        private CustomNode.CustomNode Find(string data)
        {
            CustomNode.CustomNode n = head;
            while (n.Next != null)
            {
                if (n.Next.data != data)
                {
                    n = n.Next;
                }
                else
                    return n;
            }
            return n;
        }
        public void ReplaceProfanity(string data)
        {
            if (head.data == data)
            {
                head = head.Next;
            }
            else
            {
                CustomNode.CustomNode removed = FindProfanity(data);
                if (removed.Next != null)
                    removed.Next = removed.Next.Next;
                else
                    MessageBox.Show("The give element is not found in the list");
            }
        }
        private CustomNode.CustomNode FindProfanity(string data)
        {
            CustomNode.CustomNode n = head;
            while (n.Next != null)
            {
                if (!n.Next.data.Contains(data))
                {
                    n = n.Next;
                }
                else
                {
                    string s = data;
                    string replaceString = s.Replace(data, "");
                    n.data = replaceString;
                    return n;
                }
                   
            }
            return n;
        }
    }
}
