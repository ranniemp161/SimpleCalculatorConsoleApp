using SimpleCalculatorApp.Controler;
using SimpleCalculatorApp.Operators;

AddOperation add = new AddOperation();
SubtractOperation subtract = new SubtractOperation();
MultiplyOperation multiply = new MultiplyOperation();
DivisionOperation divide = new DivisionOperation();

add.OnOperation += AddOperation.Add;
subtract.OnOperation += SubtractOperation.Subtract;
multiply.OnOperation += MultiplyOperation.Multiply;
divide.OnOperation += DivisionOperation.Divide;



// intance of the calculator

Calculator calculator = new Calculator(add);

double x, y, result;

int choice;

bool exit = false;


do
{

    Console.WriteLine("PICK AN OPERATION");
    Console.WriteLine("1) Add");
    Console.WriteLine("2) Minus");
    Console.WriteLine("3) Multiply");
    Console.WriteLine("4) Divide");
    Console.WriteLine("5) Exit");


    choice = int.Parse(Console.ReadLine());


    switch (choice)
    {
        // Addition
        case 1:

            calculator.CurrentOperation = add;


            Console.WriteLine("----------------------------------");

            Console.WriteLine("Enter two numbers to add: ");

            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            result = calculator.Calculate(x, y);

            Console.WriteLine("{0} plus {1} = {2}", x, y, result);

            break;

        // Minus
        case 2:

            calculator.CurrentOperation = subtract;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Enter two numbers to subtract: ");

            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            result = calculator.Calculate(x, y);

            Console.WriteLine("{0} minus {1} = {2}", x, y, result);
            break;
        // Multiplication

        case 3:

            calculator.CurrentOperation = multiply;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Enter two numbers to subtract: ");

            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            result = calculator.Calculate(x, y);

            Console.WriteLine("{0} times {1} = {2}", x, y, result);
            break;

        // Division
        case 4:

            calculator.CurrentOperation = divide;

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter two numbers to divide: ");

            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            result = calculator.Calculate(x, y);

            try
            {

                Console.WriteLine("{0} divided by {1} = {2}", x, y, result);
                break;
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            break;

        case 5:
            // exit flag to true
            exit = true;
            break;

        // Default: Invalid choice
        default:
            // Display an error message
            Console.WriteLine("Invalid choice. Please try again.");
            break;



    }


}
while (!exit);


Console.WriteLine("******************************************************");

Console.WriteLine("Thank you for using the calculator. Ciao");

Console.WriteLine("******************************************************");