public class MyHashMap
{
    private int[] contains = new int[1_000_001];

    public MyHashMap() {
        
    }
    
    public void Put(int key, int value) => contains[key] = value + 1;
    
    public int Get(int key) => contains[key] - 1;
    
    public void Remove(int key) => contains[key] = 0;
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */