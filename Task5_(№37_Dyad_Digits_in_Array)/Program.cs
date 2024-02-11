// №37: Найти произв. пар чисел в 1мерном массиве. Парой считаем 1ый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> [5 8];   [6 7 3 6] -> [36 21]

int[] GenerateArray(int lengthArray)
{
    int[] array = new int[lengthArray];
    for (int i=0; i <array.Length; i++)  array[i] =new Random().Next(10);
    return array;
}
// void WriteArray(int[] array)
// {
//     for (int i =0; i < array.Length - 1; i++)  Console.Write(array[i] + ", ");
//     Console.WriteLine(array[array.Length -1]);
// }
int [] ProductOfDyadDigits(int[] array)
{
int[] result = new int [array.Length / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    return result;
}

Console.Write("Введите размерность массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = GenerateArray(length);
// WriteArray(array);
Console.WriteLine(String.Join(", ", array));  // Полностью тоже самое что и искуственный  WriteArray.
Console.WriteLine(String.Join("\t", ProductOfDyadDigits(array)));