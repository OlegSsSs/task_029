// Напишите программу, которая задает массив из 8 элементов и выводит их на экран
// 1,2,5,7,19 -> [1,2,5,7,19]
// 6,1,33 -> [6,1,33]

int[] array = new int[8];
Console.Write("[");
int len = array.Length;
int index = 0;
while (index < len)
{
    array[index] = new Random().Next(0,33);
    index++;
}
for (int i = 0; i < len; i++)
{
    Console.Write(array[i]);
    if (i < (array.Length-1)) Console.Write($", "); // разделение вывода массива запятыми и пробелами
}
Console.Write("]");
