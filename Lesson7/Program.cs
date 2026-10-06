using Lesson7;

var clsMath = new Lesson7.Math();
var clsArray = new Lesson7.GUIConsolApp();
Console.WriteLine("Выберите тип калькулятора: Классический калькулятор (1) / Работа с массивом чисел (2)");
string choice = Console.ReadLine();
if (choice == "1")
{
    while (true)
    {
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите оператор (+ - / * % factorial1/2):");
        string oper = Console.ReadLine();
        if (oper == "+")
        {

            Console.WriteLine($"Результат сложения: {clsMath.sum(num1, num2)}");
        }
        else if (oper == "-")
        {

            Console.WriteLine($"Результат вычитания: {clsMath.minus(num1, num2)}");
        }
        else if (oper == "/")
        {

            Console.WriteLine($"Результат деления: {clsMath.division(num1, num2)}");
        }
        else if (oper == "*")
        {

            Console.WriteLine($"Результат умножения: {clsMath.multiplication(num1, num2)}");
        }
        else if (oper == "%")
        {

            Console.WriteLine($"Результат нахождения процента от числа: {clsMath.percent(num1, num2)}");
        }
        else if (oper == "de%")
        {

            Console.WriteLine($"Результат нахождения числа от процента: {clsMath.depercent(num1, num2)}");
        }
        else if (oper == "factorial1")
        {

            Console.WriteLine($"Результат нахождения факториала от числа: {clsMath.factorial_num1(num1)}");
        }
        else if (oper == "factorial2")
        {

            Console.WriteLine($"Результат нахождения факториала от числа: {clsMath.factorial_num2(num2)}");
        }
        else
        {
            Console.WriteLine("Введите оператор из списка!");
        }
        if (oper == "exit")
        {
            break;
        }
    }
}
else if (choice == "2")
{
    while (true)
    {
        Console.WriteLine("Введите количество элементов в массиве и сами элементы:");
        double[] array = { };
        array = clsArray.GetArray(array);
        Console.WriteLine("Введите функцию (sum, count, max, min):");
        string oper = Console.ReadLine();
        if (oper == "sum")
        {
            Console.WriteLine($"Результат суммирования: {clsMath.Sum(array)}");

        }
        else if  (oper == "count")
        {
            Console.WriteLine($"Длинна вашего массива: {clsMath.Count(array)}");
        }
        else if (oper == "max")
        {
            Console.WriteLine($"Максимальный элемент вашего массива: {clsMath.Max(array)}");
        }
        else if (oper == "min")
        {
            Console.WriteLine($"Минимальный элемент вашего массива: {clsMath.Min(array)}");
        }
        else
        {
            Console.WriteLine("Введите оператор из списка!");
        }

        if (oper == "exit")
        {
            break;
        }
    }
}
