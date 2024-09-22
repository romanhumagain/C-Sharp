using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Assignment.Exercise3
{
    public class TokyoTime : LocalTime
    {

        public override void DisplayTimeAndCity()
        {
            DateTime tokyoTime = GetTimeByOffSet(9);  // UTC+9 for Tokyo
            Console.WriteLine($"Tokyo Time: {tokyoTime}");
        }
    }
}
