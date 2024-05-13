int n = 10;
int[] arr = new int[n];
int i = 0; // cчетчик

while (i < n) // (i <  arr.Lenght)
{
    arr[i] = i + 1;
    // Console.Write(arr[i]);
    // Console.Write(' ');
    Console.Write($"{arr[i]} ");
    i = i + 1;
}
