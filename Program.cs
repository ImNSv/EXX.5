/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

Console.Write("Сколько будет элементов в массиве: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[x];
    
void mas(int x)
{
for (int i = 0; i < x; i++)
{
randomArray[i] = new Random().Next(99,999);
Console.Write(randomArray[i] + " ");
}

}

int kol(int[] randomArray)
{
int kol = 0;
for (int i = 0; i < randomArray.Length; i++)
{
if (randomArray[i] % 2 == 0)
kol = kol + 1;
}
return kol;
}

mas(x);
Console.Write($"\n Количество чётных чисел в массиве: {kol(randomArray)} ");*/


/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void mas(int a)
{
for (int i = 0; i < a; i++)
{
randomArray[i] = new Random().Next(1,9);
Console.Write(randomArray[i] + " ");
}

}

int kol(int[] randomArray)
{
int sum = 0;
int i = 0;
while (i < randomArray.Length)
{
sum = sum + randomArray[i];
i = i + 2;
}
return sum;
}

mas(a);
Console.Write($"\nCумма элементов, стоящих на нечётных позициях: {kol(randomArray)} "); */


/* Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3, 4, 1, 77, 65] => 77 - 1 = 76 */

Console.WriteLine("Введите размер массива:");
int n = Convert.ToInt32(Console.ReadLine());
int [] mass  = new int[n];
Random rnd = new Random();
for (int i = 0; i < n; i++)
    { mass[i] = rnd.Next(-99999, 99999);
    Console.Write($" {mass[i]} ");
}
int min = 0;
int max = 0;
foreach (int i in mass) 
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");
