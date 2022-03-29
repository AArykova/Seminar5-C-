// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Random rnd = new Random();
int kol = 10;
int[] array = new int[kol];
FillArr();
PrintArr();
Even();

void FillArr()
{
    for (int i = 0; i < kol; i++)
    {
        array[i] = rnd.Next(100, 1000);
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
void Even()
{
    int even = 0;

    for (int i = 0; i < kol; i++)
    {
        if (array[i] % 2 == 0)
            {
                even++;
            }
    }
Console.WriteLine("Количество четных чисел равно " + even);    
}
