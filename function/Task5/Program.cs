int size = 10;
int [] arr1 = new int [size];
int i = 0;
while(i < size)
{
	Console.WriteLine("Введите целое число:");
    string input = Console.ReadLine();
	arr1 [i] = Convert.ToInt32(input);
	i++;
}

i = 0;
while(i< size)
{
	Console.Write($"{arr1[i]} ");
	i++;
}
