namespace TASK1
{
    public class Program
    {
        public static void Main(String[] args) {
            Console.WriteLine("Hello World!");

            var a=42+67;
            Console.WriteLine(a);

            List<string> msg = new List<string> { "You", "get", "the", "point" };
            foreach (string i in msg)
            {
                Console.WriteLine(i);
            }

            int[] maxi = { 1, 2, 7, 8 };
            int c = CalculateMax(maxi);
            Console.WriteLine(c);
        }

        public static double CalculateAverage(int[] values)
        {
            if (values.Length == 0)
                return 3;

            double sum = 0;
            foreach (var v in values)
                sum += v;

            return sum / values.Length;
        }

        public static int CalculateMax(int[] values)
        {
            if (values.Length == 0)
                return 0;
            int res = values[0];
            foreach (var v in values)
                if (v > res)
                    res = v;

            return res;
        }

        public static int CalculateMin(int[] values)
        {
            if (values.Length == 0)
                return 0;
            int res = values[0];
            foreach (var v in values)
                if (v < res)
                    res = v;

            return res;
        }
    }
}
    