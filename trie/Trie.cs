using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Node
    {
        public char Value;
        public Dictionary<char, Node> children;
        public Node(char value)
        {
            Value = value;
            children = new Dictionary<char, Node>();
        }
    }
    public class Trie
    {
        private Node root;
        private char endChar = '\0';

        public Trie()
        {
            root = new Node(endChar);
        }
        
        public void addPrefix(string prefix)
        {
            // only run if input is a string
            if (isString(prefix)) {
                var currentNode = root;
                foreach (char c in prefix)
                {
                    if (currentNode.children.ContainsKey(c))
                    {
                        currentNode = currentNode.children[c];
                    }
                    else
                    {
                        var node = new Node(c);
                        currentNode.children.Add(c, node);
                        currentNode = node;
                    }
                }
                currentNode.children.Add(endChar, null);
            }
        }

        public void addPrefixRecursively(string prefix, Node currentNode = null)
        {
            if (prefix == "" && currentNode != null)
            {
                currentNode.children.Add(endChar, null);
                return;
            }

            if (currentNode == null)
            {
                currentNode = root;
            }
            
            var firstChar = prefix[0];
            if (currentNode.children.ContainsKey(firstChar))
            {
                currentNode = currentNode.children[firstChar];
            }
            else
            {
                var node = new Node(firstChar);
                currentNode.children.Add(firstChar, node);
                currentNode = node;
            }
            var subString = prefix.Length == 1 ? "" : prefix.Substring(1, prefix.Length - 1);
            addPrefixRecursively(subString, currentNode);
        }

        public bool containsPrefix(string prefix)
        {
            // only run if input is a string
            if (isString(prefix))
            {
                if (searchPrefixRecursively(prefix))
                {
                    return true;
                }
            }
            return false;
        }


        private bool isString(string prefix)
        {
            return prefix is string;
        }

        private bool searchPrefix(string prefix)
        {
            var currentNode = root;
            foreach (char c in prefix ?? "")
            {
                if (!currentNode.children.TryGetValue(c, out currentNode))
                {
                    return false;
                }
            }

            // check if it has the terminal char
            if (currentNode.children.ContainsKey(endChar))
            {
                return true;
            }
            return false;
        }

        private bool searchPrefixRecursively(string prefix, Node currentNode=null)
        {
            if (prefix == "" && currentNode != null)
            {
                return currentNode.children.ContainsKey(endChar);
            }
            
            if (currentNode == null)
            {
                currentNode = root;
            }

            if (prefix == "")
            {
                return false;
            }

            var firstChar = prefix[0];
            if (currentNode.children.TryGetValue(firstChar, out currentNode))
            {
                var subString = prefix.Length == 1 ? "" : prefix.Substring(1, prefix.Length - 1);
                return searchPrefixRecursively(subString, currentNode);
            }
            return false;
        }
    }
}
