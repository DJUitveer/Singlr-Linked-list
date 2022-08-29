using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleLinkedList
{
    public partial class Form1 : Form
    {
        private CLinkedLists.SLinkedList slinkedList = new CLinkedLists.SLinkedList();
        public Form1()
        {
            InitializeComponent();
            CLinkedLists.SLinkedList slinkedList = new CLinkedLists.SLinkedList();
            //adds a new node after one another
            //slinkedList.appendNode("I am the Head");
            //slinkedList.appendNode("I am the Second Node");
            //slinkedList.appendNode("I am the Third Node");
            //adds a new node before one another
            //slinkedList.printList();


            //prependAppend();
            
            
            //deleteNode();

            replaceProfanity();
        }
        
        public void prependAppend()
        {
            slinkedList.prepend("I am the new head(prepend 1)");
            slinkedList.prepend("I am the second new head(prepend 2)");
            slinkedList.prepend("I am the third new head(prepend 3)");
            //adds a new node before one another
            slinkedList.appendNode("I am append 1");
            slinkedList.appendNode("I am append 2");
            slinkedList.appendNode("I am append 3");
            slinkedList.printList();
        }
        
        public void deleteNode()
        {
            slinkedList.appendNode("I");
            slinkedList.appendNode("am");
            slinkedList.appendNode("the");
            slinkedList.appendNode("boss");
            slinkedList.appendNode("!");
            slinkedList.printList();
            DialogResult dialogResult = MessageBox.Show("Deleting 'boss' node", "Warning", MessageBoxButtons.OK);
            slinkedList.DeleteNode("boss");
            slinkedList.printList();
        }

        public void replaceProfanity()
        {
            slinkedList.appendNode("I am not strong");
            slinkedList.appendNode("I am not tall");
            slinkedList.appendNode("I am human");
            slinkedList.appendNode("I am not sober");
            slinkedList.printList();
            slinkedList.ReplaceProfanity("not");
            slinkedList.printList();
        }
    }
}
