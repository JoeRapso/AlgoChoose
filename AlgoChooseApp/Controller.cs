using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AlgoChooseApp
{
    public class Controller
    {
        private int _algo;
        private int _arrSize;


        public int[] RanArray { get; private set; }
        public int[] SortedArray { get; private set; }



        public Controller(string algo, string arrSize)
        {
            _algo = Convert.ToInt32(algo);
            _arrSize = Convert.ToInt32(arrSize);
        }

        public void genRanArray()
        {
            int[] arr = new int[_arrSize];

            Random rng = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rng.Next(1, 101);
            }

            RanArray = arr;

        }

        public void sortArray()
        {
            Model[] models =
            {
                new BubbleSort()
            };

            models[_algo-1].Sort(RanArray);
  
        }

    }
}

