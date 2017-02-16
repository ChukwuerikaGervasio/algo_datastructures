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

            // add empty string
            addPrefix("");
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

        public bool containsPrefix(string prefix)
        {
            // only run if input is a string
            if (isString(prefix))
            {
                if (searchPrefix(prefix))
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
    }
}
