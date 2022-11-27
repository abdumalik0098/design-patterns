using StrategyPattern.Lib;

Console.WriteLine("Hello, Strategy Pattern!");

int[] arr = new int[10]{23, 12, 9, 45, 66, 99, 214, 999, 10, 24 };

Console.WriteLine("Array elements:");
foreach (var item in arr)
{
    Console.Write($"{item} ");
}
Console.WriteLine("\n");
Console.WriteLine("Sorting: ");

SortContext sortContext = new SortContext(arr, new BubbleSort());
sortContext.Sort();

sortContext._Sort = new ShellaSort();
sortContext.Sort();

sortContext._Sort = new ShakerSort();
sortContext.Sort();