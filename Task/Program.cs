string[] input_array = new string[6] {"0123", "arr", "hello", "world", "res", "zub"};
string[] output_array = new string[input_array.Length];
void ChangingArray(string[] input_array, string[] output_array)
{
    int count = 0;
    for (int i = 0; i < input_array.Length; i++)
    {
    if(input_array[i].Length <= 3)
        {
        output_array[count] = input_array[i];
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
ChangingArray(input_array, output_array);
PrintArray(output_array);