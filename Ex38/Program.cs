// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Random rnd = new Random();
int kol = 10;
double[] array = new double[kol];

FillArr();
PrintArr();
DifMaxMin();

void FillArr()
{
    for (int i = 0; i < kol; i++)
    {
        array[i] = rnd.NextDouble();
    }
}
void PrintArr()
{
    for (int i = 0; i < kol; i++)
    {
        Console.Write(array[i] + "   ");
    }
    Console.WriteLine(" ");
}
void DifMaxMin()
{
    double max = array[0];
    double min = array[0];
    double dif = 0;

    for (int i = 0; i < kol; i++)
    {
        if (array[i] > max) {max = array[i];}
        if (array[i] < min) {min = array[i];}
    }
dif = max - min;
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine("Разница между максимальным и минимальным равна " + dif);    
}
