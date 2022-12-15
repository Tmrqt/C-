int[] num = new int[8];
Console.WriteLine("Введите цифры в соответствии с требуемым входом (цифра -> запята -> пробел):");
string[] arr = Console.ReadLine().Split(", ");
System.Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
     num[i] = int.Parse(arr[i]);
     System.Console.Write(num[i]);
     if (i < arr.Length-1)
     {
     System.Console.Write(", ");
     }
}
System.Console.Write("]");