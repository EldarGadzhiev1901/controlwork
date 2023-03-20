string[] array1 = new string[5] {"doink", "1911", "gunner", "yup", "pup"};
string[] array2 = new string[5];

void Arrayless3(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[j] = array1[i];
        j++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Arrayless3(array1, array2);
PrintArray(array2);