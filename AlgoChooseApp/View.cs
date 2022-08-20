using System.Diagnostics;


namespace AlgoChooseApp
{
    public class View
    {
        public static void Main()
        {

            Console.WriteLine("1. Bubble sort 2. Merge sort");
            string choice = Console.ReadLine();
            Console.WriteLine("Enter array size");
            string arrSize = Console.ReadLine();


            Controller c = new Controller(choice, arrSize);
            c.genRanArray();
            Console.WriteLine(string.Join(",", c.RanArray));
            c.sortArray();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Console.WriteLine(string.Join(",", c.SortedArray));
            timer.Stop();
            Console.WriteLine($"It took: {timer.Elapsed.ToString()} to order the array");


        }

    }
}
