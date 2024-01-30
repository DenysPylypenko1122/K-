using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Production_model
{
    public partial class GameForm : Form
    {
        public Dictionary<string, string> facts = new Dictionary<string, string>();// ID факту, Факт
        public static Dictionary<string, Rule> rules = new Dictionary<string, Rule>();// ID правила, правило A => B
        int gameProgress = 4;

        //знаходимо умови щодо слідства
        public static List<string> findRules(string id, List<string> rep)
        {
            List<string> result = new List<string>();
            foreach (var i in rules)
            {
                if (i.Value.results == id && !rep.Contains(i.Key))
                    result.Add(i.Key);
            }
            return result;
        }

        public GameForm()
        {
            InitializeComponent();
            facts = get_facts("..//..//facts.txt");
            rules = get_rules("..//..//rules.txt");
            load();
        }

        private void resolve(Node n)
        {   
            if (n.flag)
                return;
            if (n is RuleNode)
            {
                n.flag = n.children.All(c => c.flag == true);//якщо є всі факти для правила, то ставимо галочку
            }

            if (n is FactNode)
            {
                if (n.children.Count != 0)
                    n.flag = n.children.Any(c => c.flag == true);//якщо виконується хоча б одне правило, то ставимо галочку
                else
                    n.flag = true;
            }

            //якщо отримали галочку, то дивимося, що там у батьків
            if (n.flag)
                foreach (Node p in n.parents)
                    resolve(p);
        }

        public Tuple<bool, List<string>> backward_reasoning(List<string> Facts, string need_right)
        {

            List<string> known_facts = new List<string>(Facts);//вхідні факти
            List<string> resId = new List<string>();//та потрібний факт
            List<string> tmpRes = new List<string>();

            Dictionary<string, RuleNode> Rule_dict = new Dictionary<string, RuleNode>();
            Dictionary<string, FactNode> fact_dict = new Dictionary<string, FactNode>();
            FactNode root = new FactNode(need_right);
            fact_dict.Add(need_right, root);

            Stack<Node> tree = new Stack<Node>();
            tree.Push(root);

            while (tree.Count != 0)
            {
                Node current = tree.Pop();

                if (!known_facts.Contains(current.name))
                {
                    if (current is RuleNode)
                    {
                        RuleNode Rule_node = current as RuleNode;
                        foreach (var f in rules[Rule_node.name].conditions)
                            if (fact_dict.ContainsKey(f))//якщо факт ноди немає, то створюємо і підв'язуємо, інакше просто підв'язуємо
                            {
                                current.children.Add(fact_dict[f]);
                                fact_dict[f].parents.Add(current);
                            }
                            else
                            {
                                fact_dict.Add(f, new FactNode(f));
                                Rule_node.children.Add(fact_dict[f]);
                                fact_dict[f].parents.Add(Rule_node);
                                tree.Push(fact_dict[f]);
                            }
                    }
                    else
                    {
                        FactNode fact_node = current as FactNode;
                        foreach (var f in findRules(fact_node.name, facts.Keys.ToList()))
                            if (Rule_dict.ContainsKey(f))//якщо рул ноди немає, то створюємо і підв'язуємо, інакше просто підв'язуємо
                            {
                                current.children.Add(Rule_dict[f]);
                                Rule_dict[f].parents.Add(current);
                            }
                            else
                            {
                                Rule_dict.Add(f, new RuleNode(f));
                                fact_node.children.Add(Rule_dict[f]);
                                Rule_dict[f].parents.Add(fact_node);
                                tree.Push(Rule_dict[f]);
                            }
                    }
                }
            }

           foreach (var val in fact_dict)
           {
               if (known_facts.Contains(val.Key))//якщо факт є то ставимо йому галочку і рахуємо його батьків
               {
                   val.Value.flag = true;
                   foreach (Node p in val.Value.parents)
                       resolve(p);
                }
           }
           foreach (var val in fact_dict.Reverse())
           {
               if (known_facts.Contains(val.Key))
               {
                   foreach (var v in val.Value.parents)
                   {
                        if (!tmpRes.Contains(rules[v.name].results))//якщо не отримували ще такого факту, то додаємо
                        {
                            var tmp = "";
                            tmp += facts[rules[v.name].conditions[0]] + " + " + facts[rules[v.name].conditions[1]] + " = " + facts[rules[v.name].results];
                            resId.Add(tmp);
                            known_facts.Add(rules[v.name].results);
                            tmpRes.Add(rules[v.name].results);
                        }
                   }
               }
           }
           if (root.flag == true)
           {
               resId.Add("Ура вийшов елемент : " + facts[root.name] + "!!!");
               if (root.name == need_right)
                   return Tuple.Create(true, resId);
           }
           return Tuple.Create(false, resId);
       }

       

        private void load()
        {
            foreach (var item in facts.Keys)
            {
                if (!returnPrntCheckBox.Checked)
                {
                    FactsBox.Items.Add("" + item + ": " + facts[item]);
                    SecondElComboBox.Items.Add("" + item + ": " + facts[item]);
                }
                else
                {
                    if (item.First() == 'S')
                    {
                        InFactsBox.Items.Add("" + item + ": " + facts[item]);
                    }
                    if (item.First() == 'F')
                    {   
                        FactsBox.Items.Add("" + item + ": " + facts[item]);
                        SecondElComboBox.Items.Add("" + item + ": " + facts[item]);
                    }
                }
            }
            SecondElComboBox.SelectedValue = "лава";
            SecondElComboBox.SelectedItem = "лава";
        }

        private void loadGame()
        {
            foreach (var item in facts.Keys)
            {
                if (gameModeCheckBox.Checked)
                {
                    if (item.First() == 'S')
                    {
                        InFactsBox.Items.Add("" + item + ": " + facts[item]);
                        OutFactsBox.Items.Add("" + item + ": " + facts[item]);
                    }
                }
            }
        }

        private Dictionary<string, string> get_facts(string fname)
        {
            Dictionary<string, string> _facts = new Dictionary<string, string>();
            using (StreamReader fs = new StreamReader(fname))
            {
                while (true)
                {
                    string temp = fs.ReadLine();
                    if (temp == null) break;
                    string[] strs = temp.Split(':');
                    _facts.Add(strs[0].Trim(' '), strs[1]);
                }
            }
            return _facts;
        }

        private Dictionary<string, Rule> get_rules(string fname)
        {
            Dictionary<string, Rule> _rules = new Dictionary<string, Rule>();
            using (StreamReader fs = new StreamReader(fname))
            {
                string line;
                while ((line = fs.ReadLine()) != null)
                {
                    var temp = line.Split(':');
                    temp[1] = temp[1].Trim(' ');
                    _rules[temp[0]] = new Rule(temp[1]);
                }
            }
            return _rules;
        }

        private void agenda(Dictionary<string, Rule> _rules, ref List<string> f, ref bool b)
        {
            b = false;//якщо нічого не отримаємо, то зупинимося
            foreach (var i in _rules)
                if (i.Value.compare(f))
                {
                    var res = i.Value.results;
                    if (!f.Contains(res))
                    {
                        f.Add(i.Value.results);
                        b = true;
                        ResultBox.Text += i.Value.print() + Environment.NewLine;
                        OutFactsBox.Items.Add(facts[i.Value.results]);
                    }
                }
        }
        private Tuple<bool, List<string>> ret_agenda()
        {
            List<string> list = new List<string>();
            string need_id = SecondElComboBox.SelectedItem.ToString().Split(':')[0].Trim(' ');

            List<string> first_facts = new List<string>();
            foreach (var i in InFactsBox.Items)
                first_facts.Add(i.ToString().Split(':')[0].Trim(' '));
            var res = backward_reasoning(first_facts, need_id);
            return res;
        }

        //старт
        private void startButton_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "";
            List<string> in_fact = new List<string>();
            foreach (var i in InFactsBox.Items)
                in_fact.Add(i.ToString().Split(':')[0].Trim(' '));//ID вибраних фактів // звідси беремо
            if (!returnPrntCheckBox.Checked)
            {
                Dictionary<string, Rule> _rules = rules;// ID правила, правило A => B // сюди вивантажуємо
                OutFactsBox.Items.Clear();
                bool b = true;
                while (b) { agenda(rules, ref in_fact, ref b); }
            }
            else
            {
                var r = ret_agenda();
                ResultBox.Text = "Чи вийшов елемент? " + (r.Item1 ? "Так" : "Ні, магії не сталося");

                if (r.Item1)
                    foreach (var id in r.Item2)
                        ResultBox.Text += Environment.NewLine + id;
            }
        }

        //скинути
        private void resetButton_Click(object sender, EventArgs e)
        {
            InFactsBox.Items.Clear();
            FactsBox.Items.Clear();
            OutFactsBox.Items.Clear();
            ResultBox.Text = "";
            gameProgress = 4;
            OwnElementsLabel.Text = "Отримано елементів: 4 з 126";
            textBox1.Text = "Спробуй щось об'єднати!";
            FirstElem.Items.Clear();
            SecondElem.Items.Clear();
            InFactsBox.Enabled = true;
            OutFactsBox.Enabled = true;
            if (gameModeCheckBox.Checked)
                loadGame();
            else
                load();
        }

        private void returnPrntCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (returnPrntCheckBox.Checked)
            {
                MagicLabel.Text = "Виберіть фінальний факт";
                PrintLabel.Text = "Зворотній вивід";
                OutFactsBox.Visible = false;
                SecondElComboBox.Visible = true;
            }
            else
            {
                MagicLabel.Text = "Вжух, отримали елементи!";
                PrintLabel.Text = "Прямий вивід";
                OutFactsBox.Visible = true;
                SecondElComboBox.Visible = false;
            }
            InFactsBox.Items.Clear();
            FactsBox.Items.Clear();
            OutFactsBox.Items.Clear();
            ResultBox.Text = "";
            load();
        }

        private void FactsBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FactsBox.SelectedItem != null)
            {
                InFactsBox.Items.Add(FactsBox.SelectedItem);
                FactsBox.Items.Remove(FactsBox.SelectedItem);
            }

        }

        private void InFactsBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (InFactsBox.SelectedItem != null)   
            if (gameModeCheckBox.Checked)
            {
                FirstElem.Items.Add(InFactsBox.SelectedItem);
                InFactsBox.Items.Remove(InFactsBox.SelectedItem);
                InFactsBox.Enabled = false;
            }
            else
            {
                FactsBox.Items.Add(InFactsBox.SelectedItem);
                InFactsBox.Items.Remove(InFactsBox.SelectedItem);
            }
        }

        private void gameModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (gameModeCheckBox.Checked)
            {
                InElementsLabel.Text = "Виберіть перший елемент";
                MagicLabel.Text = "Виберіть другий елемент";
                PrintLabel.Text = "Глянемо, що в нас вийшло.";

                InFactsBox.Items.Clear();
                FactsBox.Items.Clear();
                OutFactsBox.Items.Clear();
                ResultBox.Text = "";
                FactsBox.Visible = false;
                ResultBox.Visible = false;
                returnPrntCheckBox.Visible = false;
                SecondElComboBox.Visible = false;
                start.Visible = false;
                textBox1.Visible = true;
                compareButton.Visible = true;
                PlusLabel.Visible = true;
                OwnElementsLabel.Visible = true;
                RulesBox.Visible = true;
                FirstElem.Visible = true;
                SecondElem.Visible = true;
                InFactsBox.Enabled = true;
                OutFactsBox.Enabled = true;
                loadGame();
            }
            else
            {
                resetButton_Click(sender, e);
                InElementsLabel.Text = "Вибрані елементи";
                FactsBox.Visible = true;
                ResultBox.Visible = true;
                returnPrntCheckBox.Visible = true;
                start.Visible = true;
                textBox1.Visible = false;
                compareButton.Visible = false;
                PlusLabel.Visible = false;
                RulesBox.Visible = false;
                FirstElem.Visible = false;
                SecondElem.Visible = false;
                OwnElementsLabel.Visible = false;
                returnPrntCheckBox_CheckedChanged(sender, e);
            }
           
        }

        private void OutFactsBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (OutFactsBox.SelectedItem != null)
            {
                if (gameModeCheckBox.Checked)
                {
                    SecondElem.Items.Add(OutFactsBox.SelectedItem);
                    OutFactsBox.Items.Remove(OutFactsBox.SelectedItem);
                    OutFactsBox.Enabled = false;
                }
            }
        }

        private void FirstElem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FirstElem.SelectedItem != null)
            {
                InFactsBox.Items.Add(FirstElem.SelectedItem);
                FirstElem.Items.Remove(FirstElem.SelectedItem);
                InFactsBox.Enabled = true;
            }
        }

        private void SecondElem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (SecondElem.SelectedItem != null)
            {
                OutFactsBox.Items.Add(SecondElem.SelectedItem);
                SecondElem.Items.Remove(SecondElem.SelectedItem);
                OutFactsBox.Enabled = true;
            }
        }

        private void compareButton_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            var tmp = "Нічого не трапилося! Спробуй інші елементи!";
            if (FirstElem.Items.Count > 0 && SecondElem.Items.Count > 0)
            {
                List<string> in_fact = new List<string>();
                in_fact.Add(FirstElem.Items[0].ToString().Split(':')[0].Trim(' '));
                in_fact.Add(SecondElem.Items[0].ToString().Split(':')[0].Trim(' '));
                foreach (var i in rules)
                    if (i.Value.compare(in_fact))
                    {
                        var res = i.Value.results;
                        if (!InFactsBox.Items.Contains(res + ": " + facts[res]) && !OutFactsBox.Items.Contains(res + ": " + facts[res]))
                        {
                            in_fact.Add(i.Value.results);
                            gameProgress++;
                            tmp = "Ура новий елемент!" + Environment.NewLine + i.Value.print() + Environment.NewLine;
                            InFactsBox.Items.Add(res + ": " + facts[res]);
                            OutFactsBox.Items.Add(res + ": " + facts[res]);
                            OwnElementsLabel.Text = "Отримано елементів: " + gameProgress + " з 126";
                            if (gameProgress == 126)
                            {
                                tmp += "Вітаємо! Ти отримав усі елементи!";
                            }
                            break;
                        }
                        else
                        {
                            tmp = "Ми вже маємо такий елемент! Спробуй щось нове! Наприклад Жабу та Енергію :)";

                            break;
                        }
                    }
            }
            else
                tmp = "Виберіть обидва елементи!";
            textBox1.Text = tmp;
        }
    }
}
