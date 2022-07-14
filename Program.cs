using System;

namespace ConsoleApp
{
     class Program
     {
        static void Main(string[] args)
        {//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

        void Domashka()
        {
            Console.WriteLine("введите номер дня недели от 1 до 7");
            int number=Convert.ToInt32(Console.ReadLine());
            
            if (number==6||number==7)
            {
                Console.WriteLine("Это выходной день");
            }
            
            else if (1>number||7<number)
                Console.WriteLine("Ошибка ввода");

            else Console.WriteLine("рабочий день");
            

            
            
        }
        Domashka();
     }
    
 }
} 