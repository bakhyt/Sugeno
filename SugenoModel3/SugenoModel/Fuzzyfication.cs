using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugenoModel
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
           // Console.WriteLine("Temperature: low or medium or high");
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
                    MA1 = -A1 / 5 + 2;
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
                    MA2 = (2 * A2 - 10) / 25;
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
            //Console.WriteLine("Wind: strongly or gentle");
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
}
