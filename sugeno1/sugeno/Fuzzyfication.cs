namespace mamdani1
{
    class Fuzzyfication
    {
        public double A1; //low
        public double A2;   //medium
        public double A3;   //high
        public double MA1;
        public double MA2;
        public double MA3;
        public Fuzzyfication()
        {
            A1 = 0;
            A2 = 0;
            A3 = 0;
            MA1 = 0;
            MA2 = 0;
            MA3 = 0;
        }
        public void FuzzyficationA(double temp)
        {
            if (temp <= 10)
            {
                A1 = temp;

                if (A1 <= 5)
                {
                    MA1 = 1;
                }

                if (A1 > 5 && A1 < 10)
                {
                    MA1 = (-1 / 5) * A1 + 2;
                }

                if (A1 == 10)
                {
                    MA1 = 0;
                }
            }

            if (temp >= 5 && temp <= 30)
            {
                A2 = temp;

                if (A2 == 5)
                {
                    MA2 = 0;
                }

                if (A2 > 5 && A2 < 17.5)
                {
                    MA2 = (2 / 25) * A2 - (2 / 5);
                }

                if (A2 == 17.5)
                {
                    MA2 = 1;
                }

                if (A2 > 17.5 && A2 < 30)
                {
                    MA2 = (-2 / 25) * A2 + (12 / 5);
                }

                if (A2 == 30)
                {
                    MA2 = 0;
                }
            }

            if (temp >= 24)
            {
                A3 = temp;

                if (A3 == 24)
                {
                    MA3 = 0;
                }

                if (A3 > 24 && A3 < 92/3)
                {
                    MA3 = 3 / 20 * A3;
                    MA3=MA3 - 72 / 20;
                }

                if (A3 >= 92 / 3)
                {
                    MA3 = 1;
                }
            }

        }
    }
}
