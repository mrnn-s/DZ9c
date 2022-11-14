// Найти сумму элементов от M до N, N и M заданы
int sumnumbers(int M, int N)
{
  if (M==N) return N;
    else return M + sumnumbers (M+1, N);    
}
Console.Write("Введите первое число M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int sum=sumnumbers(M,N);
Console.WriteLine ($"Сумма элементов от M до N = {sum}");