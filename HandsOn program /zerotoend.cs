using System;

namespace c_training
{
    public class zerotoend
    {
        public void find()
        {
            int[][] arrays =
            {
                new int[] { 1, 2, 0, 4, 3, 0, 5, 0 },  //input 1
                new int[] { 10, 20, 30 },              //input 2
                new int[] { 0, 0 }                     //input 3
            };
          
            foreach (var arr in arrays)
            {
                zeroatend(arr);  
                Console.WriteLine("[" + string.Join(", ", arr) + "]");
            }
        }
        private void zeroatend(int[] arr)
        {
            int zeros = 0;  // Pointer to track position for non-zero elements

            // Loop to move non-zero elements to the front
            foreach (var num in arr)
            {
                if (num != 0)
                {
                    arr[zeros++] = num;  // Place non-zero element at the correct position
                }
            }
            for (int i = zeros; i < arr.Length; i++) // Fill remaining positions with zeros
            {
                arr[i] = 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            zerotoend myZeroToEnd = new zerotoend();
            myZeroToEnd.find();
            Console.ReadLine();
        }
    }
}
