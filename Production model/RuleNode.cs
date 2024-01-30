using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production_model
{
    class RuleNode : Node
    {
        public RuleNode() { }
        public RuleNode(string rule)
        {
            name = rule;
        }
    }
}
