using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba04
{
        public class BinarySearchTree
        {
        public BSTNode Root { get; set; }

        public void Insert(int key, string value)
        {
            Root = Insert(Root, key, value);
        }

        private BSTNode Insert(BSTNode node, int key, string value)
        {
            if (node == null)
            {
                return new BSTNode(key, value);
            }

            if (key < node.Key)
            {
                node.Left = Insert(node.Left, key, value);
            }
            else if (key > node.Key)
            {
                node.Right = Insert(node.Right, key, value);
            }
            else
            {
                node.Value = value;
            }

            return node;
        }

        public string Search(int key)
        {
            return Search(Root, key);
        }

        private string Search(BSTNode node, int key)
        {
            if (node == null || node.Key == key)
            {
                return node?.Value;
            }

            if (key < node.Key)
            {
                return Search(node.Left, key);
            }
            else
            {
                return Search(node.Right, key);
            }
        }

        public void Remove(int key)
        {
            Root = Remove(Root, key);
        }

        private BSTNode Remove(BSTNode node, int key)
        {
            if (node == null)
            {
                return null;
            }

            if (key < node.Key)
            {
                node.Left = Remove(node.Left, key);
            }
            else if (key > node.Key)
            {
                node.Right = Remove(node.Right, key);
            }
            else
            {
                if (node.Left == null)
                {
                    return node.Right;
                }
                else if (node.Right == null)
                {
                    return node.Left;
                }

                node.Key = GetMin(node.Right).Key;
                node.Value = GetMin(node.Right).Value;
                node.Right = Remove(node.Right, node.Key);
            }

            return node;
        }

        private BSTNode GetMin(BSTNode node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        public List<KeyValuePair<int, string>> Traverse()
        {
            List<KeyValuePair<int, string>> result = new List<KeyValuePair<int, string>>();
            Traverse(Root, result);
            return result;
        }

        private void Traverse(BSTNode node, List<KeyValuePair<int, string>> result)
        {
            if (node != null)
            {
                Traverse(node.Left, result);
                result.Add(new KeyValuePair<int, string>(node.Key, node.Value));
                Traverse(node.Right, result);
            }
        }
    }
}
