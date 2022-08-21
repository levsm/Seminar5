// Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и 
//наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]
// Массивы к задачам 32 и 33 можно сделать рандомными. 
// В задаче 33 на экран выводится ТОЛЬКО одно сообщение: либо "да", либо "нет".

int [] arrey = new int [12];
Random rand = new Random();

for (int i = 0; i < arrey.Length; i++)
{
    arrey[i] = rand.Next(-9, 10);
}

Console.WriteLine(string.Join(", " , arrey));

for (int i = 0; i < arrey.Length; i++)
{
    arrey[i] *= - 1;
}

Console.WriteLine(string.Join(", " , arrey));
