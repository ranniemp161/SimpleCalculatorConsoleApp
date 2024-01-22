using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorApp.Controler
{
    internal class Calculator
    {

        private ICalculatorOperation _currentOperation;


        public ICalculatorOperation CurrentOperation
        {
            get {
                return _currentOperation;
            
                }

            set
            {
                _currentOperation = value;
            }
        }

        public Calculator(ICalculatorOperation operation)
        {

            CurrentOperation = operation;
        }

        public double Calculate(double x, double y)
        {
            if(CurrentOperation != null)
            {

                return CurrentOperation.PerformCalculation(x, y);
            }

            else
            {
                throw new InvalidOperationException("Invalid operation mo BOBO");
            }

        }





    }
}
