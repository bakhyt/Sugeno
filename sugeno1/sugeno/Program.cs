using System;

namespace sugeno
{
    class Fuzzyfication
    {
        public double A1; //low
        public double A2; //medium
        public double A3; //high
        public double B1; //strong
        public double B2; //gentle
        
        //Degrees of membership
        public double MA1;
        public double MA2;
        public double MA3;
        public double MB1;
        public double MB2;
        public double MC1;
        public double MC2;
        public double MC3;

        public Fuzzyfication()
        {
            //Console.WriteLine("Crisp to Fuzzy and Fuzzyfication ");              
        }
        
        public void FuzzyA(double t)
        {
            Console.WriteLine("Temperature: low or medium or high");
            if (t <= 10)
            {
                A1 = t;

                if (A1 <= 5)
                {
                    MA1 = 1;
                    //Console.WriteLine("A1<=5 and MA1=1 : " + MA1+" A1="+A1);
                }

                if (A1 > 5 && A1 < 10)
                {
                    MA1 = -A1/5 + 2;
                    //Console.WriteLine("A1>5 and A1<10 and MA1=" + MA1 + " A1=" + A1);

                }

                if (A1 == 10)
                {
                    MA1 = 0;
                    //Console.WriteLine("A1=10 and MA1=0 : " + MA1 + " A1=" + A1);
                }
            }

            if (t >= 5 && t <= 30)
            {
                A2 = t;

                if (A2 == 5)
                {
                    MA2 = 0;
                    //Console.WriteLine("A2=5 and MA2=0 : " + MA2 + " A2=" + A2);
                }

                if (A2 > 5 && A2 < 17.5)
                {
                    MA2 = (2 * A2 - 10 )/ 25;
                    //Console.WriteLine("A2>5 and A2<17.5 and MA2=" + MA2 + " A2=" + A2);
                }

                if (A2 == 17.5)
                {
                    MA2 = 1;
                    //Console.WriteLine("A2=17.5 and MA2=1 : " + MA2 + " A2=" + A2);
                }

                if (A2 > 17.5 && A2 < 30)
                {
                    MA2 = (-2 * A2 + 60) / 25;
                    //Console.WriteLine("A2>17.5 and A2<30 and MA2=" + MA2 + " A2=" + A2);
                }

                if (A2 == 30)
                {
                    MA2 = 0;
                   // Console.WriteLine("A2=30 and MA2=0 : " + MA2 + " A2=" + A2);
                }
            }

            if (t >= 24)
            {
                A3 = t;

                if (A3 == 24)
                {
                    MA3 = 0;
                    //Console.WriteLine("A3=24 and MA3=0 : " + MA3 + " A3=" + A3);
                }

                if (A3 > 24 && A3 < 92 / 3)
                {
                    MA3 = (3 * A3 - 72) / 20;
                   // Console.WriteLine("A3>24 and A3<92/3 and MA3=" + MA3 + " A3=" + A3);
                }

                if (A3 >= 92 / 3)
                {
                    MA3 = 1;
                    //Console.WriteLine("A3>=92/3 and MA3=1 : " + MA3 + " A3=" + A3);
                }
            }

        }

        public void FuzzyB(double w)
        {
            Console.WriteLine("Wind: strongly or gentle");
            if (w <= 39)
            {
                B1 = w;

                if (B1 <= 34)
                {
                    MB1 = 1;
                }

                if (B1 > 34 && B1 < 39)
                {
                    MB1 = (39 - B1) / 5;
                    // Console.WriteLine("B1>34 and B1<39 and MB1="+MB1+" B1="+B1);
                }

                if (B1 == 39)
                {
                    MB1 = 0;
                }
            }

            if (w >= 36)
            {
                B2 = w;

                if (B2 == 36)
                {
                    MB2 = 0;
                }

                if (B2 > 36 && B2 < 41)
                {
                    MB2 = (B2 - 36) / 5;
                    //Console.WriteLine("B2>36 and B1<41 and MB2=" + MB2 + " B2=" + B2);
                }

                if (B2 >= 41)
                {
                    MB2 = 1;
                }
            }
        }
      
    }
    class RuleEvaluation:Fuzzyfication
    {
        public double x;
        public double y;
        public void Rule1()
        {
            x = MA1;
            y = MB1;
            Console.WriteLine("RULE-1: IF temperature is low AND wind is strong THEN weather is cold");
            if (x == MA1 && y == MB1) MC1 = Math.Min(x,y);
            //Console.WriteLine("x="+MA1+" y="+MB1+" z="+MC1);
        }

        public void Rule2()
        {
            x = MA2;
            y = MB2;
            Console.WriteLine("RULE-2: IF temperature is medium OR wind is gentle THEN weather is average");
            if (x == MA2 || y == MB2) MC2 = Math.Max(x, y);
            //Console.WriteLine("x=" + MA2 + " y=" + MB2 + " z=" + MC2);
        }

        public void Rule3()
        {
            x = MA3;
            y = MB2;
            Console.WriteLine("RULE-3: IF temperature is high OR wind is gentle THEN weather is hot");
            if (x == MA3 || y == MB2) MC3 = Math.Max(x, y);
            //Console.WriteLine("x=" + MA3 + " y=" + MB2 + " z=" + MC3);
        }
        public RuleEvaluation()
        {
            //Console.WriteLine("Rule Evaluation and Result Agregation");
        }

    }
    class Defuzzification:RuleEvaluation
    {
        public double Result;
        public double C1;//Cold
        public double C2;//Avergae
        public double C3;//Hot

        public Defuzzification()
        {
           
            //Console.WriteLine("Defuzzification");
            
        }

        public void Center(double C1, double C2, double C3)
        {
            Console.WriteLine("Weather: cold or average or hot");
            this.C1 = C1;//Cold
            this.C2 = C2;//Average
            this.C3 = C3;//Hot            
        }

        public void CrispResult()
        {
            Result = (C1 * MC1 + C2 * MC2 + C3 * MC3) / (MC1 + MC2 + MC3);
        }               
    }
    class Sugeno:Defuzzification
    {
        public Sugeno()
        {
            //Console.WriteLine("Sugeno Fuzzy Model");
        }
        public void DisplayResult()
        {
            Console.WriteLine("Result={0:#.##}%", Result);
        }
    }

    class Program
    {
       
        static void Main()
        {
            double temperature=25;
            double wind = 35;
            Console.WriteLine("Input temperature: "+temperature+" Celcius");
            Console.WriteLine("Input speed of wind: " + wind + " km/h");
            Sugeno f = new Sugeno();
            Console.WriteLine("\nFuzzyfication:\n");
            f.FuzzyA(temperature);
            f.FuzzyB(wind);
            f.Center(35, 55, 75);
            Console.WriteLine();
            Console.WriteLine(value: $"MA1={f.MA1}");
            Console.WriteLine(value: $"MA2={f.MA2}");
            Console.WriteLine(value: $"MA3={f.MA3}");
            Console.WriteLine();
            Console.WriteLine(value: $"MB1={f.MB1}");
            Console.WriteLine(value: $"MB2={f.MB2}");
            Console.WriteLine("\nRule Evaluation:\n");            
            f.Rule1();            
            f.Rule2();            
            f.Rule3();           
            f.CrispResult();
            Console.WriteLine();
            Console.WriteLine(value: $"MC1={f.MC1}");
            Console.WriteLine(value: $"MC2={f.MC2}");
            Console.WriteLine(value: $"MC3={f.MC3}");
            Console.WriteLine();
            Console.WriteLine("Defuzzyfication:\n");
            f.DisplayResult();
            Console.ReadKey();               
        }
    }
}
