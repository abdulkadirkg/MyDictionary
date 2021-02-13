static void Main(string[] args)
{
  MyDictionary<int, string> dic = new MyDictionary<int, string>();
  dic.Add(1, "Test");
  dic.Add(3, "AbdulkadirKG");
  dic.ShowAll();
}
 
class MyDictionary<TKey,TValue> where TKey : notnull
{
  List<(TKey, TValue)> list = new List<(TKey, TValue)>();
  public void Add(TKey key, TValue value)
  {
  list.Add((key, value));
  }

  public void ShowAll()
  {
    for (int i = 0; i < list.Count; i++)
    {
    Console.WriteLine("[" + list[i].Item1 + "," + list[i].Item2 + "]");
    }
  }
}
