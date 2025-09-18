using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayHashing
{
    class EncodeAndDecodeStrings
    {
        public string Encode(IList<string> strs)
        {
            StringBuilder sb = new StringBuilder();
            foreach(string str in strs)
            {
                sb.Append(str.Length).Append("#").Append(str);              
            }
            return sb.ToString();
        }

        public List<string> Decode1(string s)
        {
            StringBuilder sb =new StringBuilder(s);
            StringBuilder integers = new StringBuilder();
            List<string> Decoded = new List<string>();
            int len;

            while (sb.Length > 0)
            {
                if (!sb[0].Equals('#'))
                {
                    integers.Append(sb[0]);
                    sb.Remove(0, 1);
                    continue;
                }
                else
                {
                    len=int.Parse(integers.ToString());
                    integers.Clear();
                    Decoded.Add(sb.ToString().Substring(1,len));
                    sb.Remove(0, len + 1);
                }
            }
            return Decoded;
        }

        public List<string> Decode2(string s)
        {
            List<string> decoded = new List<string>();
            int i = 0;
            int j=0;
            while(i < s.Length)
            {
                if (!s[i].Equals('#'))
                {
                    i++;
                }
                else
                {
                    j = int.Parse(s.Substring(j, i-j));
                    decoded.Add(s.Substring(i+1, j));
                    i = i + j + 1;
                    j = i;
                }
            }
            return decoded;
        }
    }
}
