using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("ЛАБОРАТОРНАЯ РАБОТА №3 - CS_Basics");
            Console.WriteLine("Основы языка программирования C#");
            Console.WriteLine();
            Console.WriteLine("Выберите блок задач для выполнения:");
            Console.WriteLine();
            Console.WriteLine("1 - Переменные и операторы");
            Console.WriteLine("2 - Условные операторы (if-else, switch)");
            Console.WriteLine("3 - Циклы (while, do-while, for)");
            Console.WriteLine("4 - Массивы (одномерные и двумерные)");
            Console.WriteLine("5 - Функции и методы");
            Console.WriteLine("0 - Выход из программы");
            Console.WriteLine();
            Console.Write("Введите номер блока: ");

            string choice = Console.ReadLine();

            if (choice == "0")
            {
                Console.WriteLine("Выход из программы...");
                break;
            }

            switch (choice)
            {
                case "1":
                    Block1();
                    break;
                case "2":
                    Block2();
                    break;
                case "3":
                    Block3();
                    break;
                case "4":
                    Block4();
                    break;
                case "5":
                    Block5();
                    break;
                default:
                    Console.WriteLine("Неверный выбор! Попробуйте снова.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void Block1()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Блок 1: Переменные и операторы");
            Console.WriteLine();
            Console.WriteLine("1 - Индекс массы тела (ИМТ)");
            Console.WriteLine("2 - Перевод времени");
            Console.WriteLine("3 - Цена со скидкой");
            Console.WriteLine("0 - Вернуться в главное меню");
            Console.WriteLine();
            Console.Write("Введите номер задачи: ");

            string choice = Console.ReadLine();

            if (choice == "0") break;

            switch (choice)
            {
                case "1":
                    Console.Write("Введите рост в сантиметрах: ");
                    double heightCm = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите вес в килограммах: ");
                    double weight = Convert.ToDouble(Console.ReadLine());

                    double heightM = heightCm / 100.0;
                    double bmi = weight / (heightM * heightM);
                    Console.WriteLine($"Индекс массы тела: {Math.Round(bmi, 1)}");
                    break;

                case "2":
                    Console.Write("Введите количество секунд: ");
                    int totalSeconds = Convert.ToInt32(Console.ReadLine());

                    int hours = totalSeconds / 3600;
                    int minutes = (totalSeconds % 3600) / 60;
                    int seconds = totalSeconds % 60;
                    Console.WriteLine($"{totalSeconds} секунд = {hours}ч {minutes}м {seconds}с");
                    break;

                case "3":
                    Console.Write("Введите первоначальную цену: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите размер скидки в процентах: ");
                    double discount = Convert.ToDouble(Console.ReadLine());

                    double finalPrice = price * (100 - discount) / 100;
                    Console.WriteLine($"Цена со скидкой: {finalPrice:F2}");
                    break;

                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }

            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }

    static void Block2()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Блок 2: Условные операторы");
            Console.WriteLine();
            Console.WriteLine("1 - Тип треугольника");
            Console.WriteLine("2 - Оценка по числу");
            Console.WriteLine("3 - Конвертация валют");
            Console.WriteLine("0 - Вернуться в главное меню");
            Console.WriteLine();
            Console.Write("Введите номер задачи: ");

            string choice = Console.ReadLine();

            if (choice == "0") break;

            switch (choice)
            {
                case "1":
                    Console.Write("Введите длину первой стороны: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите длину второй стороны: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите длину третьей стороны: ");
                    double c = Convert.ToDouble(Console.ReadLine());

                    if (a == b && b == c)
                        Console.WriteLine("Равносторонний треугольник");
                    else if (a == b || a == c || b == c)
                        Console.WriteLine("Равнобедренный треугольник");
                    else
                        Console.WriteLine("Разносторонний треугольник");
                    break;

                case "2":
                    Console.Write("Введите оценку (1-5): ");
                    int grade = Convert.ToInt32(Console.ReadLine());

                    switch (grade)
                    {
                        case 1:
                            Console.WriteLine("Плохо");
                            break;
                        case 2:
                            Console.WriteLine("Неудовлетворительно");
                            break;
                        case 3:
                            Console.WriteLine("Удовлетворительно");
                            break;
                        case 4:
                            Console.WriteLine("Хорошо");
                            break;
                        case 5:
                            Console.WriteLine("Отлично");
                            break;
                        default:
                            Console.WriteLine("Неверная оценка!");
                            break;
                    }
                    break;

                case "3":
                    const double usdRate = 3.25;
                    const double eurRate = 3.45;
                    const double gbpRate = 4.15;

                    Console.Write("Введите сумму в белорусских рублях: ");
                    double byn = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Выберите валюту:");
                    Console.WriteLine("1 - Доллар (USD)");
                    Console.WriteLine("2 - Евро (EUR)");
                    Console.WriteLine("3 - Фунт (GBP)");
                    Console.Write("Ваш выбор: ");
                    int currencyChoice = Convert.ToInt32(Console.ReadLine());

                    switch (currencyChoice)
                    {
                        case 1:
                            Console.WriteLine($"{byn} BYN = {byn / usdRate:F2} USD");
                            break;
                        case 2:
                            Console.WriteLine($"{byn} BYN = {byn / eurRate:F2} EUR");
                            break;
                        case 3:
                            Console.WriteLine($"{byn} BYN = {byn / gbpRate:F2} GBP");
                            break;
                        default:
                            Console.WriteLine("Неверный выбор валюты!");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }

            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }

    static void Block3()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Блок 3: Циклы");
            Console.WriteLine();
            Console.WriteLine("1 - Переворот числа");
            Console.WriteLine("2 - Максимальное нечётное число");
            Console.WriteLine("3 - Арифметическая прогрессия");
            Console.WriteLine("0 - Вернуться в главное меню");
            Console.WriteLine();
            Console.Write("Введите номер задачи: ");

            string choice = Console.ReadLine();

            if (choice == "0") break;

            switch (choice)
            {
                case "1":
                    Console.Write("Введите целое число: ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    int reversed = 0;
                    int temp = Math.Abs(number);

                    while (temp > 0)
                    {
                        int digit = temp % 10;
                        reversed = reversed * 10 + digit;
                        temp = temp / 10;
                    }

                    if (number < 0) reversed = -reversed;
                    Console.WriteLine($"Перевёрнутое число: {reversed}");
                    break;

                case "2":
                    Console.Write("Введите начало диапазона (a): ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите конец диапазона (b): ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    int maxOdd = int.MinValue;
                    bool found = false;

                    for (int i = a; i <= b; i++)
                    {
                        if (i % 2 != 0 && i > maxOdd)
                        {
                            maxOdd = i;
                            found = true;
                        }
                    }

                    if (found)
                        Console.WriteLine($"Максимальное нечётное число: {maxOdd}");
                    else
                        Console.WriteLine("В диапазоне нет нечётных чисел");
                    break;

                case "3":
                    Console.Write("Введите количество членов (n): ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите первый член: ");
                    double first = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите шаг прогрессии: ");
                    double step = Convert.ToDouble(Console.ReadLine());

                    double sum = 0;
                    Console.Write("Члены прогрессии: ");

                    for (int i = 0; i < n; i++)
                    {
                        double term = first + i * step;
                        Console.Write($"{term} ");
                        sum += term;
                    }

                    Console.WriteLine();
                    Console.WriteLine($"Сумма прогрессии: {sum}");
                    break;

                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }

            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }

    static void Block4()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Блок 4: Массивы");
            Console.WriteLine();
            Console.WriteLine("1 - Второй по величине элемент");
            Console.WriteLine("2 - Чётные элементы в столбцах");
            Console.WriteLine("3 - Диагонали матрицы");
            Console.WriteLine("0 - Вернуться в главное меню");
            Console.WriteLine();
            Console.Write("Введите номер задачи: ");

            string choice = Console.ReadLine();

            if (choice == "0") break;

            switch (choice)
            {
                case "1":
                    Console.Write("Введите размер массива: ");
                    int size = Convert.ToInt32(Console.ReadLine());

                    int[] array = new int[size];
                    Random rand = new Random();

                    Console.WriteLine("Массив:");
                    for (int i = 0; i < size; i++)
                    {
                        array[i] = rand.Next(1, 101);
                        Console.Write(array[i] + " ");
                    }
                    Console.WriteLine();

                    int max1 = int.MinValue;
                    int max2 = int.MinValue;
                    int max2Index = -1;

                    for (int i = 0; i < size; i++)
                    {
                        if (array[i] > max1)
                        {
                            max2 = max1;
                            max1 = array[i];
                        }
                        else if (array[i] > max2 && array[i] < max1)
                        {
                            max2 = array[i];
                            max2Index = i;
                        }
                    }

                    if (max2Index != -1)
                        Console.WriteLine($"Второй по величине элемент: {max2}, индекс: {max2Index}");
                    else
                        Console.WriteLine("Второго по величине элемента нет");
                    break;

                case "2":
                    Console.Write("Введите количество строк: ");
                    int rows = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите количество столбцов: ");
                    int cols = Convert.ToInt32(Console.ReadLine());

                    int[,] matrix = new int[rows, cols];
                    Random rand2 = new Random();

                    Console.WriteLine("Массив:");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            matrix[i, j] = rand2.Next(1, 101);
                            Console.Write(matrix[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                    int[] evenCounts = new int[cols];

                    for (int j = 0; j < cols; j++)
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            if (matrix[i, j] % 2 == 0)
                                evenCounts[j]++;
                        }
                    }

                    Console.WriteLine("Количество чётных чисел по столбцам:");
                    for (int j = 0; j < cols; j++)
                    {
                        Console.WriteLine($"Столбец {j + 1}: {evenCounts[j]}");
                    }

                    int maxEvenCol = 0;
                    for (int j = 1; j < cols; j++)
                    {
                        if (evenCounts[j] > evenCounts[maxEvenCol])
                            maxEvenCol = j;
                    }

                    Console.WriteLine($"Столбец с максимальным количеством чётных чисел: {maxEvenCol + 1}");
                    break;

                case "3":
                    Console.Write("Введите размер матрицы: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    int[,] squareMatrix = new int[n, n];
                    Random rand3 = new Random();

                    Console.WriteLine("Матрица:");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            squareMatrix[i, j] = rand3.Next(1, 101);
                            Console.Write(squareMatrix[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                    int maxMain = int.MinValue;
                    int maxSecondary = int.MinValue;

                    for (int i = 0; i < n; i++)
                    {
                        if (squareMatrix[i, i] > maxMain)
                            maxMain = squareMatrix[i, i];

                        if (squareMatrix[i, n - 1 - i] > maxSecondary)
                            maxSecondary = squareMatrix[i, n - 1 - i];
                    }

                    Console.WriteLine($"Максимальный элемент на главной диагонали: {maxMain}");
                    Console.WriteLine($"Максимальный элемент на побочной диагонали: {maxSecondary}");
                    Console.WriteLine($"Сумма максимальных элементов: {maxMain + maxSecondary}");
                    break;

                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }

            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }

    static void Block5()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Блок 5: Функции");
            Console.WriteLine();
            Console.WriteLine("1 - Генерация массива");
            Console.WriteLine("2 - Сумма цифр числа");
            Console.WriteLine("3 - Разделение числа");
            Console.WriteLine("4 - Длины строк");
            Console.WriteLine("0 - Вернуться в главное меню");
            Console.WriteLine();
            Console.Write("Введите номер задачи: ");

            string choice = Console.ReadLine();

            if (choice == "0") break;

            switch (choice)
            {
                case "1":
                    int[] generatedArray = GenerateArray(10, 1, 100);
                    Console.WriteLine("Сгенерированный массив: " + string.Join(" ", generatedArray));
                    break;

                case "2":
                    Console.Write("Введите число: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    int digitSum = DigitSum(number);
                    Console.WriteLine($"Сумма цифр числа: {digitSum}");
                    break;

                case "3":
                    Console.Write("Введите число: ");
                    double num = Convert.ToDouble(Console.ReadLine());
                    int whole;
                    double fraction;
                    Split(num, out whole, out fraction);
                    Console.WriteLine($"Целая часть: {whole}, дробная часть: {fraction}");
                    break;

                case "4":
                    int[] lengths = GetLengths("My", "Name", "Is", "Jabbar", "I", "Live", "In", "Qatar");
                    Console.WriteLine("Длины строк: " + string.Join(" ", lengths));
                    break;

                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }

            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }

    static int[] GenerateArray(int count, int min, int max)
    {
        int[] array = new int[count];
        Random rand = new Random();

        for (int i = 0; i < count; i++)
        {
            array[i] = rand.Next(min, max + 1);
        }

        return array;
    }

    //реализовать рекурсивно
    static int DigitSum(int number)
    {
        int sum = 0;
        int n = Math.Abs(number);

        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum;
    }

    static void Split(double number, out int whole, out double fraction)
    {
        whole = (int)number;
        fraction = Math.Abs(number - whole);
    }

    static int[] GetLengths(params string[] strings)
    {
        int[] lengths = new int[strings.Length];

        for (int i = 0; i < strings.Length; i++)
        {
            lengths[i] = strings[i].Length;
        }

        return lengths;
    }
}