InputOutput InputOutPut = new InputOutput();
Calculate calculate=new Calculate();
do
{  
    double firstNumber = InputOutPut.InputOfNumber();
    string symbol = InputOutPut.InputOfOperation();
    double secondNumber = InputOutPut.InputOfNumber();
    switch (symbol)
    {
        case "+":
            double result1=calculate.Plus(firstNumber, secondNumber);
            Console.WriteLine($"Результат: {result1}");
            break;

        case "-":
            double result2=calculate.Minus(firstNumber, secondNumber);
            Console.WriteLine($"Результат: {result2}");
            break;

        case "*":
           double result3=calculate.Multiply(firstNumber, secondNumber);
            Console.WriteLine($"Результат: {result3}");
            break;
        case "/":
            double result4=calculate.Division(firstNumber, secondNumber);
            if (secondNumber == 0)
            {
                Console.WriteLine("Попробуйте еще раз");
            }
            else
            {
                Console.WriteLine($"Результат: {result4}");
            }
            break;
    }
} while (InputOutPut.AskToContinue());
Console.WriteLine("Нажмите любую клавишу для выхода из калькулятора");

public class InputOutput
{
    public double InputOfNumber()
    {
        string input;
        string input2;
        double number = 0;
        do
        {
            Console.WriteLine("Введите число");
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Ошибка! Вы ничего не ввели, попробуйте еще раз");
                continue;
            }
            if (!double.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка! Вы ввели не число, попробуйте еще раз");
                continue;
            }
            return number;
        } while (true);
    }
    public string InputOfOperation()
    {
        string input;
        char symbol;
        do
        {
            Console.WriteLine("Введите арифметическую операцию(+, -, /, *)");
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Ошибка! вы ничего не ввели, попробуйте еще раз");
                continue;
            }
            symbol = input[0];
            if (symbol != '+' && symbol != '-' && symbol != '*' && symbol != '/')
            {
                Console.WriteLine("Ошибка! Вы ввели не правильную арифметическую операцию, попробуйте еще раз");
                continue;
            }
            return input;
        } while (true);
    }
    public bool AskToContinue()
    {
        while (true)
        {
            Console.WriteLine("Хотите ли вы провести еще одну оперцию?");
            string choice = Console.ReadLine().ToLower().Trim();
            if(choice == "да")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

public class Calculate
{
    public double Plus(double a, double b)
    {

        return a + b;
    }
    public double Minus(double a, double b)
    {
        return a - b;
    }
    public double Multiply(double a, double b)
    {
        return a * b;
    }
    public double Division(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Ошибка! Делить на ноль нельзя!");
        }
        return a / b;
    }
} 


