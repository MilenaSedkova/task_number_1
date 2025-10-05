string choice;
do
{
    Console.WriteLine("Введите первое число");
    double firstNumber = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    double secondNumber = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите арифметическую операцию(+, -, /, *)");
    char symbol = char.Parse(Console.ReadLine());
    switch (symbol)
    {
        case '+':
            double result1 = firstNumber + secondNumber;
            Console.WriteLine(result1);
            break;

        case '-':
            double result2 = firstNumber - secondNumber;
            Console.WriteLine(result2);
            break;

        case '*':
            double result3 = firstNumber * secondNumber;
            Console.WriteLine(result3);
            break;
        case '/':
            double result4 = firstNumber / secondNumber;
            Console.WriteLine(result4);
            break;
    }

    choice = Console.ReadLine().Trim().ToLower();
} while (choice == "Да");
Console.WriteLine("Нажмите любую клавишу для выхода из калькулятора");

