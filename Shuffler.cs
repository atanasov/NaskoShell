using System;
using System.Collections.Generic;
using System.Text;

namespace NaskoShell
{
    class Shuffler
    {
        private Random rng = new Random();

        public void Shuffle<T>(T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n);
                n--;
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
}
