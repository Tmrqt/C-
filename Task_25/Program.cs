int[] Point (string A, string B)
{
    int[] num = new int[2];
    Console.WriteLine($"Введите {A} и {B} через пробел:");
    string[] arr =  Console.ReadLine().Split();
    for (int i = 0; i < arr.Length; i++)
    {
        num[i] = int.Parse(arr[i]);
    }
    return num;
}
int[] num1 = Point ("A", "B");
System.Console.WriteLine((Math.Pow(num1[0], num1[1])));