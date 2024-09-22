using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Assignment.Exercise3
{
    public class HongKongTime : LocalTime
    {
        public override void DisplayTimeAndCity()
        {
            DateTime hongKongTime = GetTimeByOffSet(8);  // UTC+8 for Hong Kong
            Console.WriteLine($"Hong Kong Time: {hongKongTime}");
        }
    }
}
