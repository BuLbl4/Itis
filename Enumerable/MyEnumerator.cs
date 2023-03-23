using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    public class MyEnumerator : IEnumerator<string>
    {
        private string[] words;
        private int top = -1;

        public MyEnumerator(string[] w)
        {
            this.words = w;
        }

        public string Current 
        {
            get
            {
                return words[top];
            }
        }
        
        public bool MoveNext()  
        {
            top++;
            return top < words.Length;
        }
        public void Reset()
        {
            top = -1;
        }
        
        public void Dispose()
        {

        }
        object IEnumerator.Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

    }
}
