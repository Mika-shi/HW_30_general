namespace HW_30_task3;

public static class LinqTasks
{
    public static List<int> Method1(List<int> list)
    {
        return list.Where(x => x < 0 && x % 2 == 0).ToList();
    }

    public static int Method2(List<int> list)
    {
        return list.Where(x => x > 0).DefaultIfEmpty(0).Min();
    }

    public static List<string> Method3(List<int> list)
    {
        return list.Where(x => x > 0 && x % 2 != 0).Select(x => x.ToString()).OrderBy(x => x).ToList();
    }

    public static List<int> Method4(List<int> list, int digit)
    {
        return list.Where(x => x > 0 && x % 10 == digit).Distinct().ToList();
    }

    public static List<string> Method5(List<string> list, int idx)
    {
        return list.Take(idx).Where(s => s.Length % 2 != 0 && s.Length > 0 && s[0] >= 'A' && s[0] <= 'Z').Reverse()
            .ToList();
    }

    public static List<int> Method6(List<int> list)
    {
        return list.Select((x, index) => x * index).Where(x => Math.Abs(x) >= 10 && Math.Abs(x) <= 99).Reverse()
            .ToList();
    }

    public static List<string> Method7(List<string> list, int length)
    {
        return list.SelectMany(s => s.Split('.')).Where(word => word.Length >= length).OrderBy(word => word.Length)
            .ThenBy(word => word).ToList();
    }
}