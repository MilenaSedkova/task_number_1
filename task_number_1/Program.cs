InputOutput InputOutPut = new InputOutput();
Calculate calculate=new Calculate();
string choice;
do
{
    
    Console.WriteLine("Введите первое число");
    double firstNumber = InputOutPut.InputOfNumber();
    Console.WriteLine("Введите арифметическую операцию(+, -, /, *)");
    string symbol = InputOutPut.InputOfOperation();
    Console.WriteLine("Введите второе число");
    double secondNumber = InputOutPut.InputOfNumber();
    switch (symbol)
    {
        case "+":
            calculate.Plus(firstNumber, secondNumber);
            break;

        case "-":
            calculate.Minus(firstNumber, secondNumber);
            break;

        case "*":
           calculate.Multiply(firstNumber, secondNumber);
            break;
        case "/":
            calculate.Division(firstNumber, secondNumber);        
            break;
    }
    Console.WriteLine("Хотите ли Вы выполнить еще одну операцию?(да/нет)");
    choice = Console.ReadLine().ToLower().Trim();
} while (choice == "да");
Console.WriteLine("Нажмите любую клавишу для выхода из калькулятора");

public class InputOutput
{
    public double InputOfNumber()
    {
        string input;
        int number = 0;
        do
        {
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Ошибка! Вы ничего не ввели, попробуйте еще раз");
                continue;
            }
            if (!int.TryParse(input, out number))
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

}

public class Calculate
{
    public double Plus(double a, double b)
    {

        return a * b;
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


//static int InputOfNumber()
//{
//    string input;
//    int number=0;
//    do
//    {
//        input = Console.ReadLine();
//        if (string.IsNullOrEmpty(input))
//        {
//            Console.WriteLine("Ошибка! Вы ничего не ввели, попробуйте еще раз");
//            continue;
//        }
//        if (!int.TryParse(input, out number))
//        {
//            Console.WriteLine("Ошибка! Вы ввели не число, попробуйте еще раз");
//            continue;
//        }
//        return number;
//    }while(true);
//}
//static string InputOfOperation()
//{
//    string input;
//    char symbol;
//    do
//    {
//        input = Console.ReadLine();
//        if (string.IsNullOrEmpty(input))
//        {
//            Console.WriteLine("Ошибка! вы ничего не ввели, попробуйте еще раз");
//            continue;
//        }
//        symbol = input[0];
//        if (symbol != '+' && symbol != '-' && symbol != '*' && symbol != '/')
//        {
//            Console.WriteLine("Ошибка! Вы ввели не правильную арифметическую операцию, попробуйте еще раз");
//            continue;
//        }
//        return input;
//    } while (true);
//}
//static void DivisionByZero(double second)
//{
//    if (second == 0)
//    {
//        Console.WriteLine("Ошибка! На ноль делить нельзя!");
//    }
//}