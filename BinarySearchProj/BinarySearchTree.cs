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
        public void Add(Node nodeToAdd)
        {
            if (rootNode == null)
            {
                rootNode = nodeToAdd;
            }
            
            else if(nodeToAdd.data <= rootNode.data)
            {
                if(rootNode.left == null)
                {
                    rootNode.left = nodeToAdd;
                }
                else
                {
                    Node current = rootNode.left;

                    current.left = nodeToAdd;
                }
            }
            else if(nodeToAdd.data > rootNode.data)
            {
                if(rootNode.right == null)
                {
                    rootNode.right = nodeToAdd;
                }
                else
                {
                    Node current = rootNode.right;

                    current.right = nodeToAdd;
                }
            }
        }

    }
}
