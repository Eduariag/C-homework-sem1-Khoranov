﻿// Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input a first number:  ");
int num1=Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number:  ");
int num2=Convert.ToInt32(Console.ReadLine());


if(num1>num2)

else
{
    Console.Write(num2 + "  ");
}
*/


// Задача 4: Напишите программу, которая принимает 
//на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("number a:   ");
int a=Convert.ToInt32(Console.ReadLine());

Console.Write("number b:   ");
int b=Convert.ToInt32(Console.ReadLine());

Console.Write("number c:   ");
int c=Convert.ToInt32(Console.ReadLine());

int max=a;
if(a>max)max=a;
if(b>max)max=b;
if(c>max)max=c;

Console.Write("max=");
Console.WriteLine(max);
*/


 //    Задача 6: Напишите программу, которая на вход принимает число
 // и выдаёт, является ли число чётным (делится ли оно на два без остатка).   
    
  
Console.Write("Input a number:  ");
int num=Convert.ToInt32(Console.ReadLine());

if(int num/2)
{
    Console.WriteLine("Yes");
}    
else
{
    Console.WriteLine("No");
}
