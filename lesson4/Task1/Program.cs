/*Напишите программу, которая принимает на вход трехзначное число и удалят цифру этого числа.
Примеры
a =256 => 26
a = 891 => 81
*/

int num = 123;
int firstNum = num / 100;
int thirdNum = num % 10;
int resultNum = firstNum * 10 + thirdNum;
Console.WriteLine(resultNum);
