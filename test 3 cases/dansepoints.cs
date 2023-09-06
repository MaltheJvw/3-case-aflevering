using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Cases
{
    internal class dansepoints
    {
        internal string navn;
        internal int points;
        internal dansepoints(string navn, int points)
        {
            this.navn = navn;
            this.points = points;
        }
        public static dansepoints operator +(dansepoints first, dansepoints last)
        {
            string navn = $"{first.navn} og {last.navn}";
            int points = first.points + last.points;
            dansepoints total = new dansepoints(navn, points);
            return total;
        }
    }
}

