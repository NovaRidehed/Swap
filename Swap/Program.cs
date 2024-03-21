namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Swap
            int[] swapTestData = { 8, 4, 6, 9 };
            Console.WriteLine("Demonstration av Swap:");
            Console.WriteLine("Före: " + string.Join(",", swapTestData));
            Swap(1, 3, swapTestData); // ska fungera med olika index!
            Console.WriteLine("Efter: " + string.Join(",", swapTestData));
        }
        public static void Swap(int index1, int index2, int[] numbers)
        {
            // TODO
            int previntarray = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = previntarray;
        }
    }
}