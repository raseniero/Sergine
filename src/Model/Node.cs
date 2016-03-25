using System;
using System.Collections.Generic;

namespace Sergine.Model
{
    public class Node
    {
        public NodeType Type;
        
        public HashSet<Node> Children;
        
        public Node()
        {
        }
        
        public Node(NodeType type, HashSet<Node> children)
        {
            this.Type = type;
            this.Children = children;
        }
        
        public Node(string text, string tagName, Dictionary<String, String> attribute)
        {
            ElementData element = new ElementData(tagName, attribute);
            
            NodeType nodeType = new NodeType(text, element);
        }
    }
}
