using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ESTDownloadTime.logic
{
    internal class App
    {
        Converter converter = new Converter();
        Calculate calc = new Calculate();
        internal decimal TimeInSeconds(decimal speed, int speedUnit, decimal toDownload, int downloadUnit)
        {
            BigInteger speedBit = 1;
            BigInteger toDownloadBit = 1;
            if (converter.convertSpeed(speed, speedUnit) != 0)
            {
                speedBit = converter.convertSpeed(speed, speedUnit);
            }

            if (converter.convertSize(toDownload, downloadUnit) != 0)
            {
                toDownloadBit = (BigInteger)converter.convertSize(toDownload, downloadUnit);
            }
            if (toDownloadBit / speedBit != null && toDownloadBit / speedBit > 0)
            {
                return (decimal)(toDownloadBit / speedBit);
            }
            return 0;
        }

        internal string init(decimal speed, int speedUnit, decimal toDownload, int downloadUnit)
        {
            BigInteger sec = (BigInteger)TimeInSeconds(speed, speedUnit, toDownload, downloadUnit);
            List<BigInteger> times = calc.time(sec);
            string final = converter.convertToString(times);
            return final;

        }


    }
}
