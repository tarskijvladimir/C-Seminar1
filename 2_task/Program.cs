Console.Write("Введите число a:   "); //ввод данных
int a = Convert.ToInt32(Console.ReadLine());// преобразование в тип, т.к Console это строка – мы принимаем сточку – и нам надо преобразовать в тип int
Console.Write("Введите число b:   ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c:   ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b) max = b;
if (max < c) max = c;

Console.WriteLine("Максимальное из этих чисел = " + max);