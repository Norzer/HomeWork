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
