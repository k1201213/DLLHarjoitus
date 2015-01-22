using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringMethods
{
    public class FilterFactory
    {

        public enum FilterType
        {
            AVERAGE, MEDIAN
        }

        public static Filter CreateFilter(FilterType type, int length)
        {
        Filter f = null;
        switch (type)
        {
            case FilterType.AVERAGE:
                f = new AverageFilter(length);
                break;

            case FilterType.MEDIAN:
                f = new MedianFilter(length);
                break;
        }
        return f;
        }
       
    }
}
