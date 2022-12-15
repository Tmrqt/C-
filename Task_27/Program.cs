Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[num];
int i = 0;
int sum = 0;
while (num > 0)
{
    arr[i] = num%10;
    sum = sum + arr[i];
    num/=10;
    i++;
}
System.Console.WriteLine(sum);