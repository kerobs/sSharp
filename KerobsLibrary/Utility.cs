using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerobsLibrary
{
    public class Utility : IUtility
    {

        public List<sText> GetPalindromeWords(string inputstr)
        {
            char[] arr = inputstr.ToCharArray();
            char[] arrB = arr;

            List<sText> arrPalindromelist = new List<sText>();

            for (int i = 0; i < arr.Length; i++)
            {
                //Even letter Palindrome
                string _str = string.Empty; int _cnt = 0;
                if (i < arr.Length - 1)
                {
                    while (_cnt < 2)
                    {
                        _str = _str + arr[i + 1].ToString();
                        _cnt++;
                    }
                    char[] arrChar1 = _str.ToCharArray();
                    Array.Reverse(arrChar1);
                    string rev = new string(arrChar1);

                    string paledromeword = ""; bool flag = false;
                    if (_str == rev)
                    {
                        //Move left or right to check if other letters are mirror too
                        int keyIndex = i;
                        flag = true;
                        bool isMatch = true; int _count = 1;
                        for (int k = keyIndex; k >= 0; k--)
                        {
                            if (((keyIndex - _count) > -1) && ((keyIndex + 1 + _count) < arr.Length)) { }
                            else { isMatch = false; }

                            if (isMatch)
                            {
                                var l_ch = arr[keyIndex - _count];
                                var r_ch = arr[keyIndex + 1 + _count];
                                if (l_ch == r_ch) { _str = l_ch + _str + r_ch; }
                                else { isMatch = false; }
                            }
                            _count++;
                        }
                        paledromeword = _str;
                    }

                    if (flag)
                    {
                        if (paledromeword.Length > 3)
                        {
                            sText ob = new sText(paledromeword, inputstr.IndexOf(paledromeword), paledromeword.Length);
                            arrPalindromelist.Add(ob);
                        }
                    }
                }

                //odd letter Palindrome
                string str = string.Empty; int cnt = 0;
                if (i < arr.Length - 2)
                {
                    while (cnt < 3)
                    {
                        str = str + arr[i + cnt].ToString();
                        cnt++;
                    }
                    char[] arrChar1 = str.ToCharArray();
                    Array.Reverse(arrChar1);
                    string rev = new string(arrChar1);

                    string paledromeword = ""; bool flag = false;
                    if (str == rev)
                    {
                        //Move left or right to check if other letters are mirror too
                        int keyIndex = i + 1;
                        bool isMatch = true; int _count = 2;
                        for (int k = keyIndex; k >= 0; k--)
                        {
                            if (((keyIndex - _count) > -1) && ((keyIndex + _count) < arr.Length)) { }
                            else { isMatch = false; }

                            if (isMatch)
                            {
                                var l_ch = arr[keyIndex - _count];
                                var r_ch = arr[keyIndex + _count];
                                if (l_ch == r_ch) { str = l_ch + str + r_ch; }
                                else { isMatch = false; }
                            }
                            _count++;
                        }
                        paledromeword = str;
                        flag = true;
                    }

                    if (flag)
                    {
                        sText ob = new sText(paledromeword, inputstr.IndexOf(paledromeword), paledromeword.Length);
                        arrPalindromelist.Add(ob);
                    }
                }
            }

            var sorted = from s in arrPalindromelist
                         orderby s._length descending
                         select s;

            return sorted.ToList();

        }
    }
}
