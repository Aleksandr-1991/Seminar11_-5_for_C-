// Зад. 32: Прога заменяет полож-е элементы массива на соот-щие отриц-е, и наоборот.
int[] GenerateArray(int lengthArray)
{
    int[] array = new int[lengthArray];
    for (int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1000);
    }
    return array;
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)  Console.Write(array[i] + ", ");
    Console.WriteLine(array[array.Length -1]);
}
void Reverse(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)  mas[i] *= -1;
}
Console.Write("Введите размерность массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = GenerateArray(length);
WriteArray(array);
Reverse(array);
WriteArray(array);