﻿// Напишите программу которая выводит  тетью с начала цифру заданного числа или сообщает что третьей цифры нет

/*int num = 7812;
int num1

/*if > 99 <=> есть третья цифра // определить что число трехзначное
% 10
1234
/ 10 % 10
12345
/100 % 10
123456
/10 /10 /10 % 10*/

int numTask4 = 9874561;
if (numTask4 > 99)
{
    while (numTask4 > 999)
    {
        numTask4 = numTask4 / 10; //если нужно найти 3 цифру с начала значит нужно делить до цифры которая меньше 99, то есть если нужна четвертая цифра то делим до 999!
    }
    int trdDigit = numTask4 % 10;
    Console.WriteLine(trdDigit);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
