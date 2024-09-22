using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Assignment.Exercise3
{
    public class LondonTime : LocalTime
    {

        public override void DisplayTimeAndCity()
        {
            DateTime londonTime = GetTimeByOffSet(0);
            Console.WriteLine($"London Time: {londonTime}");
        }
    }
}
