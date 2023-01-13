using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ESTDownloadTime.logic
{
    internal class Calculate
    {
        internal List<BigInteger> time(BigInteger timeInSecons)
        {
            BigInteger sec = timeInSecons;
            BigInteger min = sec / 60;
            BigInteger h = min / 60;
            BigInteger d = h / 24;
            List<BigInteger> list = new List<BigInteger>
            {
                sec,
                min,
                h,
                d
            };
            return list;
        }
    }
}
