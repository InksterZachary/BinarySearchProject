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
        public Node lastNode;
        

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

                while (current.data == data == false)
                {
                    if (data < current.data)
                    {
                        current = current.left;
                        break;
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
                    if(nodeToAdd.data < current.data)
                    {
                        if(current.left == null)
                        {
                            current.left = nodeToAdd;
                            break;
                        }
                        else
                        {
                            lastNode = current.left;
                            lastNode = current;
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
                            lastNode = current.right;
                            current = lastNode;
                        }
                    }    
                }
            }
            //else if(nodeToAdd.data <= rootNode.data)
            //{
            //    if(rootNode.left == null)
            //    {
            //        rootNode.left = nodeToAdd;
            //    }
            //    else
            //    {
            //        Node current = rootNode.left;

            //        if(nodeToAdd.data <= current.data)
            //        {
            //            current.left = nodeToAdd;
            //        }
            //        else
            //        {
            //            current.right = nodeToAdd;
            //        }
            //    }
            //}
            //else if(nodeToAdd.data > rootNode.data)
            //{
            //    if(rootNode.right == null)
            //    {
            //        rootNode.right = nodeToAdd;
            //    }
            //    else
            //    {
            //        Node current = rootNode.right;
            //        if (nodeToAdd.data > current.data)
            //        {
            //            current.right = nodeToAdd;
            //        }
            //        else
            //        {
            //            current.left = nodeToAdd;
            //        }
            //    }
            //}
        }

    }
}
