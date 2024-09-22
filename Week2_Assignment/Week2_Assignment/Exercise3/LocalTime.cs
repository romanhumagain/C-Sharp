using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Assignment.Exercise3
{
    public class LocalTime
    {

        // Virtual method to display time and city, which will be overridden 
        public virtual void DisplayTimeAndCity()
        {
            Console.WriteLine("Base Time");
        }

        // Helper method to get the current time based on the offset
        protected DateTime GetTimeByOffSet(int offset)
        {
            return DateTime.UtcNow.AddHours(offset);
        }

    }
}
