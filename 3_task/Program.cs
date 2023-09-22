System.Console.WriteLine("Введите число :   ");
int N = Convert.ToInt32(Console.ReadLine());


int ostatok = N%2; 
if (ostatok ==0)
	Console.WriteLine("число четное");
else
	Console.WriteLine("число нечетное");
