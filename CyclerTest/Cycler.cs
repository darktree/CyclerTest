using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclerTest
{
    class Cycler
    {
        List<int> range;

        int currentRangeIndex = 0;

        public Cycler(List<int> range)
        {
            this.range = range;
        }

        public string DoRangeStep(int stepCount)
        {
            string output = string.Empty;

            for (int i = 0; i < stepCount; i++)
            {
                currentRangeIndex = (currentRangeIndex >= range.Count) ? 0 : currentRangeIndex;

                if (i != stepCount - 1)
                    output += range[currentRangeIndex] + ", ";
                else
                    output += range[currentRangeIndex];

                ++currentRangeIndex;
            }

            return output;
        }
    }
}
