Console.Write("Введите неотрицательное число m: ");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите неотрицательное число n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
try
{
    long result = Ackermann(m, n);
    Console.WriteLine($"A({m}, {n}) = {result}");
}
catch (StackOverflowException)
{
    Console.WriteLine("Ошибка: слишком большие значения m и n.");
}

long Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m == 1)
        return n + 2;
    else if (m == 2)
        return 2 * n + 3;
    else if (m == 3)
        return (1 << (n + 3)) - 3; // 2^(n+3) - 3 для ускорения
    else
        return Ackermann(m - 1, (int)Ackermann(m, n - 1)); // Приводим к int
}
