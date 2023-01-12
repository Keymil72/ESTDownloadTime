using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTDownloadTime
{
    internal class Application
    {
        Converter converter = new Converter();
        Calculate calc = new Calculate();
        internal decimal TimeInSeconds(decimal speed, int speedUnit, decimal toDownload, int downloadUnit)
        {
            int speedBit = 1;
            int toDownloadBit = 1;
            if (converter.convertSpeed(speed, speedUnit) != 0)
            {
                speedBit = converter.convertSpeed(speed, speedUnit);
            }
                
            if (converter.convertSize(toDownload, downloadUnit) != 0)
            {
                toDownloadBit = converter.convertSize(toDownload, downloadUnit);
            }
            if ((toDownloadBit / speedBit != null) && (toDownloadBit / speedBit > 0))
            {
                return toDownloadBit / speedBit;
            }
            return 0;
        }


    }
}
