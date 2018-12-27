using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab_2
{
    class TrieTree
    {
        private readonly Node root;

        public TrieTree()
        {
            root = new Node('^', 0, null);
        }

        public Node Prefix(string s)
        {
            var currentNode = root;
            var result = currentNode;

            foreach (var c in s)
            {
                currentNode = currentNode.FindChildNode(c);
                if (currentNode == null)
                    break;
                result = currentNode;
            }

            return result;
        }

        public bool Search(string s)
        {
            var prefix = Prefix(s);
            return prefix.Depth == s.Length && prefix.FindChildNode('$') != null;
        }

        public void Insert(string s)
        {
            var commonPrefix = Prefix(s);
            var current = commonPrefix;

            for (var i = current.Depth; i < s.Length; i++)
            {
                var newNode = new Node(s[i], current.Depth + 1, current);
                current.Children.Add(newNode);
                current = newNode;
            }

            current.Children.Add(new Node('$', current.Depth + 1, current));
        }

        public void Delete(string s)
        {
            if (Search(s))
            {
                var node = Prefix(s).FindChildNode('$');

                while (node.IsLeaf())
                {
                    var parent = node.Parent;
                    parent.DeleteChildNode(node.Value);
                    node = parent;
                }
            }
        }
        
        
        //поиск в ширину ищет все слова начинающиеся с заданной буквы И заданной длинны
        public List<string> DepthFirstSearch(char ch, int depth)
        {            
            Node startRoot = Prefix(ch.ToString());

            Queue<Node> Q = new Queue<Node>();
            Queue<Node> traverseOrder = new Queue<Node>();  
            
            Queue<string> tmp_words = new Queue<string>();
            Queue<string> words = new Queue<string>();

            Q.Enqueue(startRoot);
            tmp_words.Enqueue(startRoot.Value.ToString());//Добавляем первую букву
            
            while (Q.Count > 0 && depth > 0)
            {
                words.Clear();
                traverseOrder.Clear();

                Node e = Q.Dequeue();
                string str = tmp_words.Dequeue();

                words.Enqueue(str);//cлова
                traverseOrder.Enqueue(e);//Node последней буквы
                
                foreach (Node emp in e.Children)
                {                   
                    Q.Enqueue(emp);
                    tmp_words.Enqueue(str + emp.Value.ToString());
                                       
                    depth--;
                }
            }

            while(traverseOrder.Count > 0)
            {
                Node e = traverseOrder.Dequeue();
                string tmp = words.Dequeue();
                if (e.FindChildNode('$') != null)//если это является словом
                {
                    words.Enqueue(tmp);
                }
            }

            return words.ToList();
        }
    }
}
