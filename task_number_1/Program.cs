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
            InputOutPut.OutPutOfResult(result1);
            break;

        case "-":
            double result2=calculate.Minus(firstNumber, secondNumber);
            InputOutPut.OutPutOfResult(result2);
            break;

        case "*":
           double result3=calculate.Multiply(firstNumber, secondNumber);
            InputOutPut.OutPutOfResult(result3);
            break;
        case "/":
            double result4=calculate.Division(firstNumber, secondNumber);
            if (secondNumber == 0)
            {
                InputOutPut.OutPutTryAgain();   
            }
            else
            {
                InputOutPut.OutPutOfResult(result4);
            }
            break;
    }
} while (InputOutPut.AskToContinue());
InputOutPut.GoOut();
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
    public void OutPutOfResult(double result)
    {
        Console.WriteLine($"Результат: {result}");
    }
    public void OutPutTryAgain()
    {
        Console.WriteLine("Попробуйте еще раз");
    }
    public void GoOut()
    {
        Console.WriteLine("Нажмите любую клавишу для выхода из калькулятора");
    }
    public void Mistake()
    {

        Console.WriteLine("Ошибка! Делить на ноль нельзя!");
    }
    public bool AskToContinue()
    {
        while (true)
        {
            Console.WriteLine("Хотите ли вы провести еще одну оперцию?");
            string choice = Console.ReadLine().ToLower().Trim();
            const string wantsToContinue = "да";
            if(choice == wantsToContinue)
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
    InputOutput output= new InputOutput();
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
            output.Mistake();   
        }
        return a / b;
    }
} 


