using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAMCalc
{
    public class Config
    {
        public int Frequency { get; set; }
        public int CL { get; set; }
        public double Time => RAMMath.CalculateTimeNS(Frequency, CL);
    }
}
