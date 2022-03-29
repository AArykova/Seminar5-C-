// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Random rnd = new Random();
int kol = 10;
int[] array = new int[kol];
FillArr();
PrintArr();
UnevenIndex();

void FillArr()
{
    for (int i = 0; i < kol; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
}
void PrintArr()
{
    for (int i = 0; i < kol; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
}
void UnevenIndex()
{
    int summa = 0;

    for (int i = 0; i < kol; i++)
    {
        if (i % 2 != 0)
            {
                summa = summa + array[i];
                Console.Write(array[i] + " ");
            }
    }
Console.WriteLine();
Console.WriteLine("Сумма чисел с нечетным индексом равна " + summa);    
}
