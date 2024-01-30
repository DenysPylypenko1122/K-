using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production_model
{
    class Node
    {
        public string name;
        public List<Node> parents = new List<Node>();
        public List<Node> children = new List<Node>();
        public bool flag = false;
        public Node() { }
    }
}
