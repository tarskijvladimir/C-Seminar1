Console.Write("Введите число :   ");
int N = Convert.ToInt32(Console.ReadLine());
int num = N%2 +1;
if(N>0)   
{
    if (num ==2)
    {
     while(num<=N){
        System.Console.Write($"{num} ");
        num = num + 2;    }
    }      
    else
    {
        num = num + 1;
        while(num<=N){
            System.Console.Write($"{num} ");
            num = num + 2;}
    }
}
  else
{
    if (num == 0)
    {
     while(num>=N){
        System.Console.Write($"{num} ");
        num = num - 2;    }
    }      
    else
    {
        num = num - 1;
        while(num>=N){
            System.Console.Write($"{num} ");
            num = num - 2;}
    }
}

 
