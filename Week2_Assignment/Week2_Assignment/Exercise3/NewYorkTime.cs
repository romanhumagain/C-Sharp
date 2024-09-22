using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Assignment.Exercise3
{
    public class NewYorkTime : LocalTime
    {
        public override void DisplayTimeAndCity()
        {
            DateTime newYorkTime = GetTimeByOffSet(-5);
            Console.WriteLine($"New York Time: {newYorkTime} ");
        }
    }
}
