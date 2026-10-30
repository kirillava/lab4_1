int[] mas = { 1, 2, 3, 2, 4, 2, 5, 3, 3, 6 };
int[] result = new int[mas.Length];
int k = 0;

for (int i = 0; i < mas.Length; i++)
{
    int count = 0;

    for (int j = 0; j < mas.Length; j++)
    {
        if (mas[i] == mas[j])
            count++;
    }

    if (count <= 2)
    {
        result[k] = mas[i];
        k++;
    }
}

Console.WriteLine("Массив после удаления:");

for (int i = 0; i < k; i++)
{
    Console.Write(result[i] + " ");
}