using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugenoModel
{
    class Sugeno:Defuzzyfication
    {
        public Sugeno()
        {
            //Console.WriteLine("Sugeno Fuzzy Model");
        }
        public string DisplayResult()
        {
            return "Result:"+Result.ToString();
            //   Console.WriteLine("Result=", Result);
        }
    }
}
