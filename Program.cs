
// условные операторы 


//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите число: ");
//        string input = Console.ReadLine();
//        int number = Convert.ToInt32(input);
//        if (number > 0)
//        {
//            Console.WriteLine("Положительное");
//        }
//        else if (number < 0)
//        {
//            Console.WriteLine("Отрицательное");
//        }
//        else
//        {
//            Console.WriteLine("Ноль");
//        }
//    }
//}


//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите возраст ");
//        int age = Convert.ToInt32(Console.ReadLine());

//        if (age < 12)
//        {
//            Console.WriteLine("Ребенок");
//        }
//        else if (age >= 12 && age <= 17)
//        {
//            Console.WriteLine("ты подросток");
//        }
//        else if (age >= 18 && age <=99)
//        {
//            Console.WriteLine("Взрослый");
//        }

//    }
//}


//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите число: ");
//        int number = int.Parse(Console.ReadLine());

//        if (number % 2 == 0)
//        {
//            Console.WriteLine("Четное");
//        }
//        else
//        {
//            Console.WriteLine("Нечетное");
//        }
//    }
//}


//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите вашу оценку (0-100): ");
//        int grade = int.Parse(Console.ReadLine());

//        if (grade >= 90)
//        {
//            Console.WriteLine("Отлично");
//        }
//        else if (grade >= 70)
//        {
//            Console.WriteLine("Хорошо");
//        }
//        else if (grade >= 50)
//        {
//            Console.WriteLine("Удовлетворительно");
//        }
//        else
//        {
//            Console.WriteLine("Неудовлетворительно");
//        }

//    }
//}

//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите первое число");
//        int a = int.Parse(Console.ReadLine());

//        Console.WriteLine("Введите второе число");
//        int b = int.Parse(Console.ReadLine());

//        if(a > b)
//        {
//            Console.WriteLine("Большое число: " + a);
//        }
//        else
//        {
//            Console.WriteLine("Большое число: " + b);
//        }
//    }
//}


//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите первое число");
//        int a = int.Parse(Console.ReadLine());

//        Console.WriteLine("Введите второе число");
//        int b = int.Parse(Console.ReadLine());

//        Console.WriteLine("Введите третье число");
//        int c = int.Parse(Console.ReadLine());

//        int max = a;

//        if (b > max)
//        {
//            max = b;
//        }
//        if ( c > max )
//        {
//            max = c;
//        }
//        Console.WriteLine("Наибольшое число: " + max);

//        }


//    }


//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите первое число: ");
//        double a = double.Parse(Console.ReadLine());

//        Console.WriteLine("Введите оператор(+, -, *, /): ");
//        string op = Console.ReadLine();

//        Console.WriteLine("Введите второе число: ");
//        double b = double.Parse(Console.ReadLine());

//        double result;

//        if (op == "+")
//        {
//            result = a + b;
//        }
//        else if (op == "-")
//        {
//            result = a - b;
//        }
//        else if (op == "*")
//        {
//            result = a * b;
//        }
//        else if (op == "/")
//        {
//            if (b != 0)
//                result = a / b;
//            else
//            {
//                Console.WriteLine("Ошибка деления на ноль!");
//                return;
//            }
//        }

//        else
//        {
//            Console.WriteLine("Неизвестный оператор!");
//            return;
//        }

//            Console.WriteLine("Результат: " + result);
//  }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите год: ");
//        int year = int.Parse(Console.ReadLine());

//        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
//        {
//            Console.WriteLine(year + " — високосный год");
//        }
//        else
//        {
//            Console.WriteLine(year + " — не високосный год");
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число: ");
//        int number = int.Parse(Console.ReadLine());

//        Console.WriteLine("\nОтчёт о числе:");
//        Console.WriteLine($"Вы ввели: {number}");
       
//        if (number > 0)
//            Console.WriteLine("Категория: натуральное число");
//        else
//            Console.WriteLine("Категория: не является натуральным числом");

//        if (number % 2 == 0)
//            Console.WriteLine("Чётность: чётное");
//        else
//            Console.WriteLine("Чётность: нечётное");

//        if (number > 1)
//        {
//            if (IsPrime(number))
//                Console.WriteLine("Тип: простое число");
//            else
//                Console.WriteLine("Тип: составное число");
//        }
//        else
//        {
//            Console.WriteLine("Тип: не является ни простым, ни составным");
//        }
//    }

    
//    static bool IsPrime(int n)
//    {
//        if (n <= 1) return false;
//        if (n == 2) return true;

//        for (int i = 2; i < n; i++)
//        {
//            if (n % i == 0)
//                return false;
//        }
//        return true;
//    }
//}
