public class TimeMap {
    Dictionary<string,Dictionary<int,string>> store;
    public TimeMap() {
        store = new Dictionary<string, Dictionary<int,string>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!store.ContainsKey(key)){
            store[key] = new Dictionary<int,string>();
        }
        store[key][timestamp]=value;
    }
    
    public string Get(string key, int timestamp) {
        while(timestamp>=0){ 
            if (store.ContainsKey(key) && store[key].ContainsKey(timestamp))
            {
                return store[key][timestamp];
            }
            else
            {
                timestamp--;
            }
        }
        return string.Empty;
    }
}
