using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAMCalc
{
    public class RAMMath
    {
        public static double CalculateTimeNS(int freq, int cl)
        {
            double ns = cl * (1.0d / (freq / 2.0d)) * 1000.0d;
            return ns;
        }

        public static List<Config> GenerateConfigs(GeneratorViewmodel vm)
        {
            var cls = Enumerable.Range(vm.CLMin, vm.CLMax - vm.CLMin + 1).ToList();
            var mtss = new List<int>();
            var step1 = 66;
            var step2 = 133;

            for (int i = vm.MTSMin; ; i+=200)
            {
                mtss.Add(i);
                if (i >= vm.MTSMax)
                    break;
                mtss.Add(i+step1);
                mtss.Add(i+step2);
            }
            var cfgs = cls.SelectMany(cl => mtss.Select(mts => new Config { Frequency = mts, CL = cl }))
                .Where(cfg => cfg.Time >= vm.NSMin && cfg.Time <= vm.NSMax)
                .OrderBy(m=>m.Time)
                .ToList();

            return cfgs;
        }
    }
}
