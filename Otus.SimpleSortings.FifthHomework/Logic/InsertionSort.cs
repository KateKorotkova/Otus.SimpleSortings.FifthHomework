namespace Otus.SimpleSortings.FifthHomework.Logic
{
    /// <summary>
    /// Элементы просматриваются по одному, каждый новый элемент размещается
    /// в подходящее место среди ранее упорядоченных элементов
    /// Сложность 0(n^2), Адаптивный, Стабильный, Онлайн.
    /// </summary>
    public class InsertionSort
    {
        public virtual int[] Run(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                PlaceCurrentElementInOrderedArray(array, i);
            }

            return array;
        }


        #region Support Methods

        protected void PlaceCurrentElementInOrderedArray(int[] array, int i)
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

        #endregion
    }
}
