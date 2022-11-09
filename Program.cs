string[] firstArray = new string[5] {"Russian", "Denmrak", ":-)", "123", ":-("};
string[] secondArray = new string[firstArray.Length];
void ArrayOfThreeCharact(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
    if(firstArray[i].Length <= 3)
        {
        secondArray[count] = firstArray[i];
        count++;
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
ArrayOfThreeCharact(firstArray, secondArray);
PrintArray(secondArray);