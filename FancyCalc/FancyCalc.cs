using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;
namespace FancyCalc
{
    
    public class FancyCalcEnguine
    {

        public double Add(int a, int b)
        {
            //throw new NotImplementedException();
            return a + b;
        }


        public double Subtract(int a, int b)
        {
            //throw new NotImplementedException();
            return a - b;
        }


        public double Multiply(int a, int b)
        {
            return a * b;
        }

        //generic calc method. usage: "10 + 20"  => result 30
        public double Culculate(string expression)
        {
            if (!String.IsNullOrEmpty(expression))
            {
                Regex regex = new Regex(@"\W");
                string str = expression.Replace(" ", "");
                string operate = Convert.ToString(regex.Match(str));
                string[] array = str.Split(new char[] { '+', '-', '*', '/' });
                double i = Convert.ToDouble(array[0]);
                double j = Convert.ToDouble(array[1]);
                double k = 0;
                switch (operate)
                {
                    case "+":
                        return k = i + j;
                    case "-":
                        return k = i - j;
                    case "*":
                        return k = i * j;
                    case "/":
                        if (j != 0)
                        {
                            return k = i / j;
                        }
                        else
                        {
                            throw new DivideByZeroException();
                        }

                }
                return k;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}
