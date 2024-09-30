public class CustomStack
{
    private int[] stack;
    private int capacity = 0;
    private int maxSize = 0;

    public CustomStack(int maxSize)
    {
        stack = new int[maxSize];
        this.maxSize = maxSize;
    }
    
    public void Push(int x)
    {
        if (capacity >= maxSize)
        {
            return;
        }
        stack[capacity] = x;
        capacity++;
    }
    
    public int Pop()
    {
        if (capacity == 0)
        {
            return -1;
        }
        capacity--;
        return stack[capacity];
    }
    
    public void Increment(int k, int val)
    {
        for (int i = 0; i < k && i < capacity; ++i)
        {
            stack[i] += val;
        }
    }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */