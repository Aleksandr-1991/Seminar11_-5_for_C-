// №35. Задайте 1мерный массив 125 случ-чисел. Най кол. эл-тов, значения к-ых лежат на отрезке [10, 99].
void Find(int [] array)
{
    int count = 0;
    for(int i=0; i < array.Length; i++)
    {
        count = (array[i] > 9) && (array[i] < 100) ? count +1 : count;
    }
    Console.Write(count);
}
int[] FillArray(int [] array)
{
    for (int i=0; i <array.Length; i++)  array[i] = new Random().Next(-1000, 1000);
    return array;
}

int[] array = new int [125];
int[] iobArray = FillArray(array);
Console.WriteLine(String.Join(", ", array));
Find (iobArray);