namespace Otus.SimpleSortings.FifthHomework.Logic
{
    /// <summary>
    /// Cравниваем элементы, стоящие не только рядом, но и на определённом расстоянии друг от друга
    /// Расческа: предварительная подготовка массива, чтобы не оттаскивать элементы далеко, основан на InsertionSort
    /// Сложность N^(1.75), Недаптивный, Нестабильный, Неонлайн.
    /// </summary>
    public class ShellSort : InsertionSort
    {
        public override int[] Run(int[] array)
        {
            for (var gap = array.Length / 2 - 1; gap > 0; gap /= 2)
            {
                for (var i = gap; i < array.Length; ++i)
                {
                    PlaceCurrentElementInOrderedArray(array, i);
                }
            }

            return array;
        }
    }
}
