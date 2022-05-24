namespace Otus.SimpleSortings.FifthHomework.Logic
{
    public class InsertionSort
    {
        public int[] Run(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var current = array[i];
                var j = i - 1;
                while (j >= 0 && array[j] > current)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = current;
            }

            return array;
        }
    }
}
