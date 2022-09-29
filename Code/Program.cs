Console.Write("Введите массив строк(кол-во строк/цифр): ");
int length = Convert.ToInt32(Console.ReadLine());
void FillArray(string[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write("Введите строку {0}: ", i + 1);
      array[i] = Console.ReadLine();
   }
}
void PrintArray(string[] array) 
{
   Console.Write("[ ");
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write($"'{array[i]}' ");
   }
   Console.Write("] -> ");
}
void FindingThreeCharacters(string[] array) 
{
   string[] result = new string[length];
   Console.Write("[ ");
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i].Length <= 3) {
         result[i] = array[i];
         Console.Write($"'{result[i]}' ");
      }
   }
   Console.Write("]");
}
string[] array = new string[length];
FillArray(array);
Console.WriteLine();
PrintArray(array);
FindingThreeCharacters(array);