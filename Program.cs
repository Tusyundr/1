string [] array = new string[] {"hello", "2", "world", ":-)"};
string[] result = new string [0];

foreach (var item in array)
{
    if (item.Length <= 3)
    {
    Array.Resize(ref result, result.Length + 1);
    result [result.Length-1] = item;
    }
}
Console.WriteLine($"[{String.Join(", ", result)}]");



