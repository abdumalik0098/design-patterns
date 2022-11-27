namespace StrategyPattern.Lib
{
    public class BubbleSort : ISort
    {
        public void GetSortNumbers(int[] arr)
        {
            int len = arr.Length;
            int tp = 0;
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        tp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = tp;
                    }
                }
            }
            Console.WriteLine("\nBubble Sort: ");

            for (int i = 0; i < len; ++i)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}