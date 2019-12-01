using info.lundin.math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;

namespace Dichotomy
{
    class Class1
    {
        static ExpressionParser parser = new ExpressionParser();

        public void CalculateIter(string atb, string btb, string etb, string f)
        {
            parser.RequireParentheses = true;

            parser.ImplicitMultiplication = true;

            double a = 0;

            double b = 0;

            double e = 1;

            double c = 0;

            //a = -10;

            //b = 10;

            //e = 0.001;

            //f = "x*2^x-1";

            if (atb == "-") a = -2140000000;
            else try
                {
                    a = Convert.ToDouble(atb);
                }
                catch (System.IO.IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            if (btb == "-") b = 2140000000;
            else
                try
                {
                    b = Convert.ToDouble(btb);
                }
                catch (System.IO.IOException ex)
                {                    
                    Console.WriteLine(ex.Message);
                }   

            if (etb == "-") e = 0.1;
            else
                try
                {
                    e = Convert.ToDouble(etb);
                }
                catch (System.IO.IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            if (func(a) * func(b) < 0)
            {
                long h = Convert.ToInt64(Math.Log(Convert.ToInt64((b - a) / e), 2)) + 1;

                for (int i = 0; i < h; i++)
                {
                    c = (a + b) / 2;

                    if (func(a) * func(c) < 0)
                    {
                        b = c;
                    }

                    else if (func(b) * func(c) < 0)
                    {
                        a = c;
                    }
                }
                Data.ans = c;
            }
            else if (func(a) == 0) Data.ans = a;
            else if (func(b) == 0) Data.ans = b;
        }

        public double func(double x)
        {
            parser.Values.Clear();
            parser.Values.Add("x", x);
            return parser.Parse(Data.formula);
        }
    }
}
