using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassyStuff
{
    class Sentence
    {
        private string[] words = "This is normal sentence".Split();
        public string this [int wordInd]
        {
            get { return words[wordInd]; }
            set { words[wordInd] = value; }
        }
    }
}
