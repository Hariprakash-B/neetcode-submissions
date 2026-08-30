public class TimeMap {
    Dictionary<string,List<(int timestamp,string value)>> store;
    List<int> list = new List<int>();
    public TimeMap() {
        store = new Dictionary<string, List<(int timestamp, string value)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!store.ContainsKey(key)){
            store[key] = new List<(int timestamp,string value)>();
        }
        store[key].Add((timestamp,value));
    }
    
    public string Get(string key, int timestamp) {
        if(!store.TryGetValue(key, out var currentList)){
            return string.Empty;
        }
        int left = 0;
        int right = currentList.Count-1;
        int result = -1;
        while(left <= right){
            int mid = left + ((right-left)/2);
            if(currentList[mid].timestamp == timestamp){
                return currentList[mid].value;
            }
            else if(currentList[mid].timestamp < timestamp){
                left = mid+1;
                result = mid;
            }
            else{
                right = mid-1;
            }
        }
        if(result == -1){
            return string.Empty;
        }
        return currentList[result].value;
    }
}
