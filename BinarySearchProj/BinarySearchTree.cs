using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchProj
{
    class BinarySearchTree
    {
        public Node rootNode;
        

        public BinarySearchTree()
        {
            

        }
        public Node Search(int data)
        {
            if (data == rootNode.data)
            {
                return rootNode;
            }
            else
            {
                Node current = rootNode;

                while (current.data != data)
                {
                    if (data < current.data)
                    {
                        current = current.left;
                    }
                    else
                    {
                        current = current.right;
                    }
                }
                return current;
            }
        }
        public void Add(Node nodeToAdd)
        {
            if (rootNode == null)
            {
                rootNode = nodeToAdd;
            }
            else
            {
                Node current = rootNode;
                while (true)
                {
                    if(nodeToAdd.data <= current.data)
                    {
                        if(current.left == null)
                        {
                            current.left = nodeToAdd;
                            break;
                        }
                        else
                        {
                            current = current.left;
                        }
                    }
                    else if(nodeToAdd.data > current.data)
                    {
                        if(current.right == null)
                        {
                            current.right = nodeToAdd;
                        }
                        else
                        {
                            current = current.right;
                        }
                    }    
                }
            }
        }

    }
}
