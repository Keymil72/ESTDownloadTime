using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ESTDownloadTime.logic
{
    internal class Converter
    {
        internal BigInteger convertSpeed(decimal size, int unit)
        {
            switch (unit)
            {
                case 0:
                    return (BigInteger)size;
                case 1:
                    return (BigInteger)(size * 8);
                case 2:
                    return (BigInteger)(size * 1024);
                case 3:
                    return (BigInteger)(size * 1024 * 8);
                case 4:
                    return (BigInteger)(size * 1024 * 1024);
                case 5:
                    return (BigInteger)(size * 1024 * 1024 * 8);
                case 6:
                    return (BigInteger)(size * 1024 * 1024 * 1024);
                case 7:
                    return (BigInteger)(size * 1024 * 1024 * 1024 * 8);
                default:
                    return 0;
            }
        }

        internal BigInteger convertSize(decimal size, int unit)
        {
            switch (unit)
            {
                case 0:
                    BigInteger s = (BigInteger)(size * 8);
                    return s;
                case 1:
                    return (BigInteger)(size * 1024 * 8);
                case 2:
                    return (BigInteger)(size * 1024 * 1024 * 8);
                case 3:
                    return (BigInteger)(size * 1024 * 1024 * 1024 * 8);
                case 4:
                    return (BigInteger)(size * 1024 * 1024 * 1024 * 1024 * 8);
                case 5:
                    return (BigInteger)(size * 1024 * 1024 * 1024 * 1024 * 1024 * 8);
                case 6:
                    return (BigInteger)(size * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 8);
                default:
                    return 0;
            }
        }

        internal string convertToString(List<BigInteger> unit)
        {
            string sec;
            if (unit.Count >= 2 && unit[0] - unit[1] * 60 > 0)
            {
                sec = unit[0] - unit[1] * 60 + "s";
            }
            else if (unit[0] == 0)
            {
                sec = unit[0] + "s";
            }else
            {
                sec = "";
            }
            string min = unit.Count >= 3 && unit[1] - unit[2] > 0 ? unit[1] - unit[2] * 60 + "min" : "";
            string h = unit.Count >= 4 && unit[2] - unit[3] > 0 ? unit[2] - unit[3] * 24 + "h" : "";
            string d = unit.Count >= 4 && unit[3] > 0 ? unit[3] + "d" : "";
            return $"{d} {h} {min} {sec}";
        }

    }
}
