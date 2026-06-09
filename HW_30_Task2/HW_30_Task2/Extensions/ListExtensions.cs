namespace HW_30_Task2.Extensions;

public static class ListExtensions
{
    public static List<T> CustomSort<T>(this List<T> source) where T : IComparable<T>
    {
        List<T> result = new List<T>(source);
        for (int i = 0; i < result.Count - 1; i++)
        {
            for (int j = 0; j < result.Count - i - 1; j++)
            {
                if (result[j].CompareTo(result[j + 1]) > 0)
                {
                    T temp = result[j];
                    result[j] = result[j + 1];
                    result[j + 1] = temp;
                }
            }
        }
        return result;
    }
}