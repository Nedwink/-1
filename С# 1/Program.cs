using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace С__1
{
    class Lesson
    {
        static void Main(string[] args)
        {
            (Задание 2)
            Console.WriteLine("Введите имя: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Введите Фамилию");
            string secondname = Console.ReadLine();
            Console.WriteLine($"Ваше имя : {firstname}");
            Console.WriteLine($"Ваша Фамилия : {secondname}");
            Console.ReadLine();
            Console.ReadKey();

            (Задание 3)
            Console.WriteLine();
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите ваш возраст: "); int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя: " + name);
            Console.WriteLine("Ваш возраст: " + age);
            Console.Title = "Ваше имя и возраст";
            string txt = "Ваше имя: " + name + " Ваш возраст:  " + age;
            Console.WriteLine(txt);
            Console.ReadKey();

            (Задание 4)
            Console.WriteLine("Название текушего дня недели: ");
            string dayofweek = Console.ReadLine();
            Console.WriteLine("Введите название месяца: ");
            string month = Console.ReadLine();
            Console.WriteLine("Введите номер месяца: ");
            string dayofmonth = Console.ReadLine();
            Console.WriteLine($"Текущий день недели : {dayofmonth}");
            Console.WriteLine($"Название месяца : {month}");
            Console.WriteLine($"Номер дня в месяце: {dayofmonth}");
            Console.ReadLine();
            Console.ReadKey();

            (Задание 5)
            Console.Write("Введите ваш год рождения: ");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());
            int currentYear = DateTime.Now.Year;
            int age = currentYear - yearOfBirth;
            Console.WriteLine("Ваш возраст: " + age);
            Console.ReadLine();

            (Задание 6)
            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int currentYear = DateTime.Now.Year;
            int birthYear = currentYear - age;
            Console.WriteLine("Ваш год рождения: " + birthYear);
            Console.ReadLine();










            (Задание 8)
            Console.Write("Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            double sum = number1 + number2;
            Console.WriteLine("Сумма: " + sum);
            Console.ReadLine();

            (Задание 10)
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Последовательность: " + (number - 1) + ", " + number + ", " + (number + 1));
            Console.ReadLine();



            (Задание 11)
            Console.Write("Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            double sum = number1 + number2;
            double difference = number1 - number2;
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Разность: " + difference);
            Console.ReadLine();












        }
    }
}
