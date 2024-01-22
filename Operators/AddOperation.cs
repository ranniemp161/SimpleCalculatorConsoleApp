using SimpleCalculatorApp.Controler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorApp.Operators
{
    internal class AddOperation : ICalculatorOperation
    {
        //Addition method
        public static double Add (double x, double y)
        {

            return x + y;

        }


                // triggered when the addition is performed
        public event ICalculatorOperation.Operation OnOperation;


        //Implementation of Addition
        public double PerformCalculation(double x, double y)
        {

            if (OnOperation != null)
            {

                return OnOperation(y, x);

            }


            else
            {

                throw new NotImplementedException("Invalid Operation");

            }

        }
    }
}
