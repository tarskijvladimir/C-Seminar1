
Console.Write("Введите число a:   "); //ввод данных
int a = Convert.ToInt32(Console.ReadLine());// преобразование в тип, т.к Console это строка – мы принимаем сточку – и нам надо преобразовать в тип int
Console.Write("Введите число b:   ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine("max = a ");
}
else
{
    Console.WriteLine("max = b");
}

