using SimpleCalculatorApp.Controler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorApp.Operators
{
    internal class SubtractOperation : ICalculatorOperation
    {

     
        public static double Subtract(double x, double y)
        {

            return x - y;

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

                throw new NotImplementedException("invalid operation");

            }
            
        }
    }
}
