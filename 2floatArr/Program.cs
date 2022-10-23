Console.Write("Введите m = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n = ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] array = new double [m, n];

for (int i = 0 ; i < m ; i++)
{
    for (int j = 0 ; j < n ; j++)
    {
        Console.Write($"Введите значение элемента {i}-{j} = ");
        array[i,j] = Convert.ToDouble(Console.ReadLine());
    }
}

for (int i = 0 ; i < m ; i++)
{
    for (int j = 0 ; j < n ; j++)
    {
        Console.Write($"{array[i,j] :f3} ");
    }
    Console.WriteLine();
}