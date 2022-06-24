namespace Otus.SimpleSortings.FifthHomework.Logic
{
    /// <summary>
    /// За каждый проход элементы последовательно сравниваются попарно и,
    /// если порядок в паре неверный, выполняется перестановка элементов.
    /// Сложность 0(n^2), Неадаптивный, Стабильный, Неонлайн.
    /// </summary>
    public class BubbleSort
    {
        public int[] Run(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }

            return array;
        }
    }
}
