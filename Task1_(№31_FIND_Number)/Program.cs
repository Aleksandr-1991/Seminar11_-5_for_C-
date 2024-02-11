// №31 (в гр). Прога проверяет, присутствует ли данное число в массиве.
int[] GenerateArray(int lengthArray)
{
    int[] array = new int[lengthArray];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(-100, 100);
    return array;
}
void WriteArray(int[] array)
{
    for (int i =0; i < array.Length - 1; i++)  Console.Write(array[i] + ", ");
    Console.WriteLine(array[array.Length -1]);
}
void CheckBeenNumberInArray(int number, int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        count = array[i] == number ? count + 1 : count;
    }
    if (count > 0)  Console.Write($"Ура, совпадения есть! Количество совпадений: {count}");
    else   Console.Write("Совпадений нет -(");
}

Console.Write("Введите размерность массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = GenerateArray(length);
WriteArray(array);
Console.Write("Введите искомое число: ");
int сheck = Convert.ToInt32(Console.ReadLine());
CheckBeenNumberInArray(сheck, array);