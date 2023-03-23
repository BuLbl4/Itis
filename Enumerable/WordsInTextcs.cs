using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    public class WordsInTextcs : IEnumerable<string>
    {
        public string[] words;
        public SortEnumerator sortwords;
        public WordsInTextcs(string text)
        {
            words = text.Split(' ');
            sortwords = new SortEnumerator(words);
            sortwords.GetSorted();
        }
        
        public IEnumerator<string> GetEnumerator()
        {
            return new MyEnumerator(words);

        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
