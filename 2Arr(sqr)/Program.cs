Console.Write("Введите m = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n = ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [m, n];

Random rand = new Random();

for (int i = 0 ; i < m ; i++)
{
    for (int j = 0 ; j < n ; j++)
    {
        array[i,j] = rand.Next(0, 10); 
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Новая матрица");

for (int i = 0 ; i < m ; i++)
{
    for (int j = 0 ; j < n ; j++)
    {
        if (i % 2 == 0 && j % 2 == 0) Console.Write($"{array[i,j] * array[i,j]} ");
        else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}