string choice;
do
{
    Console.WriteLine("Введите первое число");
    double firstNumber = InputOfNumber();
    Console.WriteLine("Введите арифметическую операцию(+, -, /, *)");
    string symbol = InputOfOperation();
    Console.WriteLine("Введите второе число");
    double secondNumber = InputOfNumber();  
    switch (symbol)
    {
        case "+":
            double result1 = firstNumber + secondNumber;
            Console.WriteLine($"Результат: {result1}");
            break;

        case "-":
            double result2 = firstNumber - secondNumber;
            Console.WriteLine($"Результат: {result2}");
            break;

        case "*":
            double result3 = firstNumber * secondNumber;
            Console.WriteLine($"Результат: {result3}");
            break;
        case "/":
            if (secondNumber == 0)
            {
                DivisionByZero(secondNumber);
            }
            else
            {
                double result4 = firstNumber / secondNumber;
                Console.WriteLine($"Результат: {result4}");
            }
            break;
    }
    Console.WriteLine("Хотите ли Вы выполнить еще одну операцию?(да/нет)");
    choice = Console.ReadLine().ToLower().Trim();
} while (choice == "да");
Console.WriteLine("Нажмите любую клавишу для выхода из калькулятора");

static int InputOfNumber()
{
    string input;
    int number=0;
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
    }while(true);
}
static string InputOfOperation()
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
static void DivisionByZero(double second)
{
    if (second == 0)
    {
        Console.WriteLine("Ошибка! На ноль делить нельзя!");
    }
}