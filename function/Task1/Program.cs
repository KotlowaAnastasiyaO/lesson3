double CalculateFormula(int a, int b, int c, int d)
{
	double numinatre = a * b;
	int denuminate = c + d;
	double result = numinatre / denuminate;
	return result;
}

double result = CalculateFormula(1,2,3,4);
Console.WriteLine(result);