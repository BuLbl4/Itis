using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    public class SortEnumerator : IEnumerable
    {
        public string[] words;
        public SortEnumerator(string[] words)
        {
            this.words = words; 
        
        }

        public void GetSorted()
        {
            for(int i = 0; i < words.Length; i++) 
            {
                for(int j =  i + 1; j < words.Length; j++) 
                {
                    if (words[i].Length > words[j].Length)
                    {
                        (words[i], words[j]) = (words[j], words[i]);
                    }
                }
            }
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var i in words)
            {
                yield return i;
            }
        }
    }
}
