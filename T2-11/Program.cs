// Напишите программу, которая выводит случайное трёхзначное 
//число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 9);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int find1Of(int[] collection, int position)
{
    int count = collection.Length;
    int find = 0;
    int index = 0;
        
    while (find < count)
    {
        if (collection[find] == position)
        {
            index = position;
            break; // добавляем оператор,чтобы показывал 
                   //первое вхождение в заданный индекс массива
        }
        position++;
    }
    return index;

    
}

int find2Of(int[] collection, int position)
{
    int count = collection.Length;
    int find = 2;
    int index = 0;
        
    while (find < count)
    {
        if (collection[find] == position)
        {
            index = position;
            break; 
        }
        position++;
    }
    return index;

    
}

int[] array = new int[3];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int ind1 = find1Of(array,1);
int ind2 = find2Of(array,1);
Console.WriteLine(ind1);
Console.WriteLine(ind2);