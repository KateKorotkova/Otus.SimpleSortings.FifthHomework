namespace Otus.SimpleSortings.FifthHomework.Logic
{
    public class InsertionSort
    {
        public int[] Run(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var current = array[i];
                int j;
                for (j = i - 1; j >= 0; j--)
                {
                    if (array[j] < current)
                        break;

                    array[j + 1] = array[j];
                }

                array[j + 1] = current;
            }

            return array;
        }
    }
}
