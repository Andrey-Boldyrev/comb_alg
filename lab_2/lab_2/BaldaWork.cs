using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class BaldaWork
    {
        private char[] rusLetters = new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

        private string startWord;
        private int stepNum;
        private TrieTree treeDict = new TrieTree();

        public BaldaWork(string startWord, int stepNum)
        {
            this.startWord = startWord;
            this.stepNum = stepNum;
            FillDict();
        }

        private void FillDict()
        {
            StreamReader stream = new StreamReader(@"..\..\mydict.txt");
            while (!stream.EndOfStream)
                treeDict.Insert(stream.ReadLine().Replace("/n", ""));
        }

        
        //множество хранит все слова для результата, а список найденные на текущем шаге    
        private void FindWords(HashSet<string> allWords,List<string> curList,int stp)
        {
            foreach (var str in curList)
                allWords.Add(str);

            if (stp>0)
                for (int i=0; i < curList.Count(); i++)
                {
                    var str = curList[i];
                    for (int j=0;j<str.Length;j++)
                    {
                        FindWords(allWords, treeDict.DepthFirstSearch(str[j], stp), stp - 1);
                    }
                }            
        }

        public string Work()
        {
            HashSet<string> resWords = new HashSet<string>();

            for (int i = 0; i < startWord.Length; i++)
            {
                FindWords(resWords, treeDict.DepthFirstSearch(startWord[i], stepNum), stepNum);
            }

            StringBuilder res = new StringBuilder();

            foreach (var word in resWords)
                res.Append( word + "/r/n");

            return res.ToString();
        }
            
    }
}
