using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production_model
{
    public class Rule
    {
        public List<string> conditions;//ID умов
        public string results;//ID результату

        public Rule(string r)
        {
            conditions = new List<string>();
            var temp = r.Split('-');
            results = temp[1].Trim(' ');
            var lst = temp[0].Split(',');
            foreach (var i in lst)
                conditions.Add(i.Trim(' '));
        }

        public bool compare(List<string> f)
        {
            bool res = true;
            foreach (var i in conditions)
                res = res && f.Contains(i);//перевіряємо чи є всі умови
            return res;
        }

        public string print()
        {
            GameForm _form = new GameForm();
            string res = "";
            foreach (var i in conditions)
            {
                res += _form.facts[i];
                if (i != conditions.Last())
                    res += " , ";
            }
            res += "->" + _form.facts[results];
            return res;
        }
    }
}
