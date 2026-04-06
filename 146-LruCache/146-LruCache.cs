// Last updated: 4/6/2026, 11:48:34 PM
public class Node{
        public int key;
        public int value;
        public Node prev;
        public Node next;

        public Node(int _key, int _value)
        {
            key = _key;
            value = _value;
            prev = null;
            next = null;
        }
    }


public class LRUCache {

   
    int cap = 0;
    Dictionary<int, Node> cache;
        Node head;
        Node tail;

    public LRUCache(int capacity) {
        cap = capacity;
        cache = new Dictionary<int, Node>();
        head = new Node(0,0);
        tail = new Node(0, 0);
        head.next = tail;
        tail.prev = head;
    }


        public void Add(int key, int value)
        {
            Node newNode = new Node(key, value);
            cache[key] = newNode;
            var temp = head.next;
            head.next = newNode;
            newNode.prev = head;
            temp.prev = newNode;
            newNode.next = temp;
        }

        public void Remove(int key)
        {
                Node prevNode = cache[key].prev;
                Node nextNode = cache[key].next;
                prevNode.next = nextNode;
                nextNode.prev = prevNode;
        }
    
    
    public int Get(int key) {

        if(cache.ContainsKey(key))
        {
        var res = cache[key];
        Remove(key);
        Add(res.key, res.value);
        return res.value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if(cache.ContainsKey(key))
        {
            Remove(key);
        }
        Add(key, value);

        if(cache.Count > cap)
        {
            var lastNode = tail.prev;
            Remove(lastNode.key);
            cache.Remove(lastNode.key);
       }
        
    }
}
