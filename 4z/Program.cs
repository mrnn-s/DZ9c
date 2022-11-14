// Написать программу показывающие первые N чисел, для которых каждое следующее 
// равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
void Summ(int a, int b, int n, int s)
{
    if (n <= s)
    {
        int sum = a + b;
        Console.Write($"{sum} ");
        Summ(b,sum,n+1,s);
        
    }
}
Console.Write("Введите первое число a: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число b: ");
int B = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество чисел для показа n: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Summ(A, B, 1, N);
