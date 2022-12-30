Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(1, n));

string PrintNumbers(int start, int end)
{
    if (start == end) return end.ToString();
    return (start + " " + PrintNumbers(start + 1, end)); // "3  2  1"
}
