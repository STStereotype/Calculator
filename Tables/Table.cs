using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    public class Table
    {
        public List<float> CriticalValues;
        public List<float> StudentQuantiles;

        public Table()
        {
            CriticalValues = new List<float>();
            StudentQuantiles = new List<float>();
            CompletionCriticalValues();
            CompletionStudentQuantiles();
        }

        private void CompletionCriticalValues()
        {
            CriticalValues.Add(1.463f);
            CriticalValues.Add(1.672f);
            CriticalValues.Add(1.822f);
            CriticalValues.Add(1.938f);
            CriticalValues.Add(2.032f);
            CriticalValues.Add(2.110f);
            CriticalValues.Add(2.176f);
            CriticalValues.Add(2.234f);
            CriticalValues.Add(2.285f);
            CriticalValues.Add(2.331f);
            CriticalValues.Add(2.371f);
            CriticalValues.Add(2.409f);
            CriticalValues.Add(2.443f);
            CriticalValues.Add(2.475f);
            CriticalValues.Add(2.504f);
            CriticalValues.Add(2.532f);
            CriticalValues.Add(2.557f);
            CriticalValues.Add(2.580f);
            CriticalValues.Add(2.603f);
            CriticalValues.Add(2.624f);
            CriticalValues.Add(2.644f);
            CriticalValues.Add(2.663f);
            CriticalValues.Add(2.681f);
            CriticalValues.Add(2.698f);
            CriticalValues.Add(2.714f);
            CriticalValues.Add(2.730f);
            CriticalValues.Add(2.745f);
            CriticalValues.Add(2.759f);

        }

        private void CompletionStudentQuantiles()
        {
            StudentQuantiles.Add(3.1824f);
            StudentQuantiles.Add(2.7764f);
            StudentQuantiles.Add(2.5706f);
            StudentQuantiles.Add(2.4469f);
            StudentQuantiles.Add(2.3646f);
            StudentQuantiles.Add(2.3060f);
            StudentQuantiles.Add(2.2622f);
            StudentQuantiles.Add(2.2281f);
            StudentQuantiles.Add(2.2010f);
            StudentQuantiles.Add(2.1788f);
            StudentQuantiles.Add(2.1604f);
            StudentQuantiles.Add(2.1448f);
            StudentQuantiles.Add(2.1314f);
            StudentQuantiles.Add(2.1199f);
            StudentQuantiles.Add(2.1098f);
            StudentQuantiles.Add(2.1009f);
            StudentQuantiles.Add(2.0930f);
            StudentQuantiles.Add(2.0860f);
            StudentQuantiles.Add(2.0796f);
            StudentQuantiles.Add(2.0739f);
            StudentQuantiles.Add(2.0687f);
            StudentQuantiles.Add(2.0639f);
            StudentQuantiles.Add(2.0595f);
            StudentQuantiles.Add(2.0555f);
            StudentQuantiles.Add(2.0518f);
            StudentQuantiles.Add(2.0484f);
            StudentQuantiles.Add(2.0452f);
            StudentQuantiles.Add(2.0423f);
        }
    }
}
