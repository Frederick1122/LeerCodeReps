
var nums = new int[1, 1, 2, 2, 4, 5];
var newList = new List<int>();

foreach (var num in nums)
{
    if(!newList.Contains(num))
        newList.Add(num);
}

Console.WriteLine(newList.Count);