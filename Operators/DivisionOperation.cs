using SimpleCalculatorApp.Controler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorApp.Operators
{
    internal class DivisionOperation : ICalculatorOperation
    {


        public static double Divide (double x, double y)
        {
            if (y != 0) 
            
            {
                return x / y;
            }
            else
            {
                throw new DivideByZeroException("cannot divide to zero");
            }
            
        }    



        public event ICalculatorOperation.Operation OnOperation;

        public double PerformCalculation(double x, double y)
        {

            if (OnOperation != null)
            {
                return OnOperation(x, y);
            }


            else
            {
                throw new NotImplementedException();
            }
            
        }
    }
}
