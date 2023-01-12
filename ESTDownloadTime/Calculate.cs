using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTDownloadTime
{
    internal class Calculate
    {
        internal static List<int> time(int timeInSecons)
        {
            List<int> list = new List<int>();
            list.Add(timeInSecons);
            list.Add(timeInSecons/60);
            list.Add((timeInSecons / 60) / 60);
            list.Add(((timeInSecons /60) / 60) / 24);
            list.Add((int)(((timeInSecons / 60) / 60) / 24 / 365.242199));
            return list;
        }
    }
}
