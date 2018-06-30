using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugenoModel
{
    class RuleEvaluation:Fuzzyfication
    {
        public double x;
        public double y;
        public void Rule1()
        {
            x = MA1;
            y = MB1;
            //Console.WriteLine("RULE-1: IF temperature is low AND wind is strong THEN weather is cold");
            if (x == MA1 && y == MB1) MC1 = Math.Min(x, y);
            //Console.WriteLine("x="+MA1+" y="+MB1+" z="+MC1);
        }

        public void Rule2()
        {
            x = MA2;
            y = MB2;
            //Console.WriteLine("RULE-2: IF temperature is medium OR wind is gentle THEN weather is average");
            if (x == MA2 || y == MB2) MC2 = Math.Max(x, y);
            //Console.WriteLine("x=" + MA2 + " y=" + MB2 + " z=" + MC2);
        }

        public void Rule3()
        {
            x = MA3;
            y = MB2;
            //Console.WriteLine("RULE-3: IF temperature is high OR wind is gentle THEN weather is hot");
            if (x == MA3 || y == MB2) MC3 = Math.Max(x, y);
            //Console.WriteLine("x=" + MA3 + " y=" + MB2 + " z=" + MC3);
        }
        public RuleEvaluation()
        {
            //Console.WriteLine("Rule Evaluation and Result Agregation");
        }

    }

}
