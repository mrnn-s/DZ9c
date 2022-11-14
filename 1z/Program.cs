// Показать натуральные числа от M до N, N и M заданы

void numbers(int M, int N)
{
  if (M<=N)
    {
    Console.Write($"{M} ");
    numbers(M+1, N);
    }
}
Console.Write("Введите первое число M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
if(M>0)
{
    if (N>0) 
     numbers(M,N);
}