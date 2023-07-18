﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

using System;
 class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите пятизначное число: ");
        int number = int.Parse(Console.ReadLine());
         // Разделяем число на отдельные цифры
        int digit1 = number / 10000;
        int digit2 = (number / 1000) % 10;
        int digit4 = (number / 10) % 10;
        int digit5 = number % 10;
         // Проверяем, является ли число палиндромом
        if (digit1 == digit5 && digit2 == digit4)
        {
            Console.WriteLine("Число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом.");
        }
    }
}