Random rnd = new Random();

int size = 30;
int [] arr1 = new int [size];
int i = 0;
while(i < size)
{
	arr1 [i] = rnd.Next(1,10);
	i++;
}

i = 0;
while(i < size)
{
	Console.Write($"{arr1[i]} ");
	i++;
}
