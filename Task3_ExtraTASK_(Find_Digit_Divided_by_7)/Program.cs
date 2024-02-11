// Доп. Задайте массив из N случ-х целых чисел (N с клавиатуры).
// Най кол-во чисел, к-ые оканч на 1 и делятся нацело на 7. Пример[1 5 11 21 81 4 0 91 2 3]=> 2
int[] FillArray(int lengthArray)
{
    int[] array = new int[lengthArray];
    for (int i=0; i <array.Length; i++)  array[i] =new Random().Next(-99, 100);
    return array;
}   
void WriteArray(int[] array)
{
    for (int i =0; i < array.Length - 1; i++)  Console.Write(array[i] + ", ");
    Console.WriteLine(array[array.Length -1]);
}
void CheckNumberInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        count = (array[i] %10 == 1 && array[i] %7 == 0) ? count + 1 : count;
    }
    if (count > 0)  Console.Write($"Ура, совпадения есть! Количество совпадений: {count}");
    else   Console.Write("Совпадений нет -(");
}

Console.Write("Введите размерность массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(length);
WriteArray(array);
CheckNumberInArray(array);