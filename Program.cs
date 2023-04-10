/*string [] CreateAndFillArray (int size)
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}
*/
void ArrayComparison(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
      if(array1[i].Length <= 3)
        {
          array2[count] = array1[i];
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

string[] arr1 = new string[5] {"ki", "dkjgkjdfgh", "helloworld", "345", "mir"};
string[] arr2 = new string[arr1.Length];
//CreateAndFillArray(s);
//string[] arr2 = new string[] {};
ArrayComparison(arr1, arr2);
PrintArray(arr2);
