Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());

if (M > N)
{
    Console.WriteLine("Ошибка: M должно быть меньше или равно N.");
    return;
}

PrintNumbers(M, N);

void PrintNumbers(int current, int N)
{
    if (current > N)
        return;

    Console.WriteLine(current);
    PrintNumbers(current + 1, N);
}
