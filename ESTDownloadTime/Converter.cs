using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTDownloadTime
{
    internal class Converter
    {
        internal int convertSpeed(decimal size, int unit)
        {
            switch (unit)
            {
                case 0:
                    return (int)size;
                case 1:
                    return (int)(size * 8);
                case 2:
                    return (int)(size * 1024);
                case 3:
                    return (int)(size * 1024 * 8);
                case 4:
                    return (int)(size * 1024 * 1024);
                case 5:
                    return (int)(size * 1024 * 1024 * 8);
                case 6:
                    return (int)(size * 1024 * 1024 * 1024);
                case 7:
                    return (int)(size * 1024 * 1024 * 1024 * 8);
                default:
                    return 0;
            }
        }

        internal int convertSize(decimal size, int unit)
        {
            switch (unit)
            {
                case 0:
                    return (int)(size * 8);
                case 1:
                    return (int)(size * 1024 * 8);
                case 2:
                    return (int)(size * 1024 * 1024 * 8);
                case 3:
                    return (int)(size * 1024 * 1024 * 1024 * 8);
                case 4:
                    return (int)(size * 1024 * 1024 * 1024 * 1024 * 8);
                case 5:
                    return (int)(size * 1024 * 1024 * 1024 * 1024 * 1024 * 8);
                case 6:
                    return (int)(size * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 8);
                default:
                    return 0;
            }
        }

    }
}
