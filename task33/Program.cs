// Задача 33: Задайте массив. Напишите программу, 
//которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да
//Массивы к задачам 32 и 33 можно сделать рандомными. 
//В задаче 33 на экран выводится ТОЛЬКО одно сообщение: либо "да", либо "нет".

Console.WriteLine("Введите количество элементов в массиве: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для поиска в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
int [] arrey = new int [A];
Random rand = new Random();
int i;
bool res = false;

for (i = 0; i < arrey.Length; i++)
{
    arrey[i] = rand.Next(-9, 10);
    if (arrey [i] == number)
    res = true;
}

Console.WriteLine(string.Join(", " , arrey));

for (i = 0; i < arrey.Length; i++)

if (res == true)
{
    Console.WriteLine("Да");
}
if (res == false)
{
    Console.WriteLine("Нет");
}

