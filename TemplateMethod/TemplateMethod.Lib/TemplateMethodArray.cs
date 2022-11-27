namespace TemplateMethod.Lib
{
    public abstract class TemplateMethodArray
    {
        public double OperationWithArray()
        {
            Console.WriteLine("Count of elems:");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[n];
            Random random = new Random();
            double r;
            for (int i = 0; i < arr.Length; i++)
            {
                r = Math.Round(random.NextDouble(), 4);
                arr[i] = r;
            }
            Print(arr);
            int index = SearchIndex(arr);
            double c = arr[index];
            if (arr.Any(n => n == index+1))
            {
                c += arr[index+1];
            }
            else
            {
                c += 0;
            }
            if (arr.Any(n => n == index-1))
            {
                c += arr[index-1];
            }
            else
            {
                c += 0;
            }
            double result = SearchResult(arr, c);

            return result;
        }
        public abstract int SearchIndex(double[] arr);
        public abstract double SearchResult(double[] arr, double c);
        public void Print(double[] arr)
        {
            Console.WriteLine("Array Elements: ");
            foreach (var item in arr)
            {
                Console.Write(item + " | ");
            }
        }
    }
}