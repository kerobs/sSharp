using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerobsLibrary
{
    public class sText
    {
        public string _word { get; set; }
        public int _position { get; set; }
        public int _length { get; set; }

        public sText(string words, int pos, int len)
        {
            _word = words;
            _position = pos;
            _length = len;
        }


     

    }
}
