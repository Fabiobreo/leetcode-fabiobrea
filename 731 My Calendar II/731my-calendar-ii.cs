public class MyCalendarTwo
{
    public class Event
    {
        public int start;
        public int end;

        public Event(int start, int end)
        {
            this.start = start;
            this.end = end;
        }  
    }

    List<Event> overLapBookings;
    List<Event> bookings;

    public MyCalendarTwo()
    {
        overLapBookings = new List<Event>();
        bookings = new List<Event>();
    }
    
    public bool Book(int start, int end)
    {
        foreach (var e in overLapBookings)
        {
            if (IsOverlap(e, start, end))
            {
                return false;  
            } 
        } 

        foreach (var e in bookings)
        {
            if (IsOverlap(e, start, end))
            {
                overLapBookings.Add(GetOverlapEvent(e, start, end));
            }    
        }  
        bookings.Add(new Event(start, end));

        return true; 
    }

    public bool IsOverlap(Event e, int start, int end)
    {
        return Math.Max(e.start, start) < Math.Min(e.end, end); 
    }

    public Event GetOverlapEvent(Event e, int start, int end)
    {
        return new Event(Math.Max(e.start, start), Math.Min(e.end, end));  
    }
}

/**
 * Your MyCalendarTwo object will be instantiated and called as such:
 * MyCalendarTwo obj = new MyCalendarTwo();
 * bool param_1 = obj.Book(start,end);
 */