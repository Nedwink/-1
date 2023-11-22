using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                            (Задание 9)
            string number1String = Microsoft.VisualBasic.Interaction.InputBox("Введите первое число:", "Число 1", "");
            string number2String = Microsoft.VisualBasic.Interaction.InputBox("Введите второе число:", "Число 2", "");
            double number1 = Convert.ToDouble(number1String);
            double number2 = Convert.ToDouble(number2String);
            double sum = number1 + number2;
            MessageBox.Show("Сумма: " + sum, "Результат");
            Console.ReadLine();








        }
    }



}
   