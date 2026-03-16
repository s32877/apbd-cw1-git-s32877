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
        }

        public double CalculateAverage(int[] values)
        {
            if (values.Length == 0)
                return 0;

            double sum = 0;
            foreach (var v in values)
                sum += v;

            return sum / values.Length;
        }
    }
}
    