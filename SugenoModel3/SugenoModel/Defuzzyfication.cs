using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugenoModel
{
    class Defuzzyfication:RuleEvaluation
    {
        public double Result;
        public double C1;//Cold
        public double C2;//Avergae
        public double C3;//Hot

        public Defuzzyfication()
        {

            //Console.WriteLine("Defuzzification");

        }

        public void Center(double C1, double C2, double C3)
        {
           // Console.WriteLine("Weather: cold or average or hot");
            this.C1 = C1;//Cold
            this.C2 = C2;//Average
            this.C3 = C3;//Hot            
        }

        public void CrispResult()
        {
            Result = (C1 * MC1 + C2 * MC2 + C3 * MC3) / (MC1 + MC2 + MC3);
        }

    }
}
