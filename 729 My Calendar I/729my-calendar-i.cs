public class MyCalendar
{
    private SortedSet<(int Start, int End)> calendar;
    public MyCalendar()
    {
        calendar = new SortedSet<(int Start, int End)>(
            Comparer<(int Start, int End)>.Create((a, b) => a.Start == b.Start ? a.End.CompareTo(b.End) : a.Start.CompareTo(b.Start)));
    }
    
    public bool Book(int start, int end)
    {
        var booking = (Start: start, End: end);
        var nextIt = calendar.GetViewBetween(booking, (int.MaxValue, int.MaxValue)).Min;

        if (nextIt != default && nextIt.Start < end)
            return false;

        var prevIt = calendar.GetViewBetween((int.MinValue, int.MinValue), booking).Max;

        if (prevIt != default && prevIt.End > start)
            return false;

        calendar.Add(booking);
        return true;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(start,end);
 */