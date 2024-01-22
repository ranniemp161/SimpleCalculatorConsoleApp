using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorApp.Controler
{
    internal interface ICalculatorOperation
    {
        //type for the operation
        delegate double Operation(double x, double y);

        //event operation

        event Operation OnOperation;


        double PerformCalculation (double x, double y);


    }
}
