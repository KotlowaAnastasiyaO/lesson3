/*Задача 1
на вход число проверяет кратно ли оно одновременно 7 и 23
-проверка сразу и 7 и 23
-найти число
-проверить делится на 7
-делится на 23
-вывести результат
да/нет*/


/*1
int num = 57;
int divid1 = 7;
int divid2 = 8;

if (num % divid1 == 0 && num % divid2 == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}*/



/*Задача 2
на вход координаты точки х и y причем х не равен 0 и y не равен 0 и выдает номер координатной четверти плоскости в которой находится та точка.
-4 четверти
-если х и н положитьельные 1 четверть
-xy отрицательные 3 четверть 
-x положит y отриц 4 четверть
*/
/*2
int x = -354;
int y = 7;

if ((x > 0) && (y > 00))
{
    Console.WriteLine(" I quadro");
}
else
{
    if ((x < 0) && (y > 0))
    {
        Console.WriteLine("II quadro");
    }
    else
    {
        if ((x < 0) && (y < 0))
        {
            Console.WriteLine("III quadro");
        }
        else
        {
            if ((x > 0) && (y < 0))
            {
                Console.WriteLine("IV quadro");
            }
        }
    }
}
*/



/*Задача3
Принимает на вход целое число из отрезка [10,99] и показвыыает наибольшую цифрц числа
-обработать все двузначные числа
-двойной амперсант 2 условия

int Numb = 55;
int count1 = Numb / 10 % 10;//9
int count2 = Numb % 10;//1

if ((Numb < 100) && (count1 > count2) && (Numb % 1 == 0))
{
    Console.WriteLine(count1);
    Numb++;
}
else
{
    Console.WriteLine(count2);
    Numb++;
}



/*Задача4
Напишите программу которая принимает натуральное число N а на выходе показывает его цифры через запятую
-больше 0
*/
int Numero = 536;
int num1 = Numero / 10 / 10 % 10;
int num2 = Numero / 10 % 10;
int num3 = Numero % 10;

if ((Numero % 1 == 0) && (Numero > 99))
{
    Console.Write($"{num1}, {num2}, {num3}");
}


