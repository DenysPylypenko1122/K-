using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production_model
{
    class FactNode : Node
    {
        public FactNode() { }
        public FactNode(string fact)
        {
            name = fact;
        }
    }
}
