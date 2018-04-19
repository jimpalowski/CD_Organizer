using System.Collections.Generic;

namespace CDOrg
{
  public class Catalog
  {
    private static List<Catalog> _instances = new List<Catalog> {};
    private string _title;
    private int _id;
    private List<Cd> _cds;

    public Catalog(string cdTitle, int cdId)
    {
      _title = cdTitle;
      _instances.Add(this)
      _id = _instances.Count;
      _cds = new List<Cd>{};
    }
    public string GetTitle()
    {
      return _title
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Catalog> GetAll()
    {
      return _instances;
    }
    public static void Clear()
    {
      _instances.Clear();
    }
    public static Catalog Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public List<Cd> GetItems()
    {
      return _cds;
    }
    public void AddItem(Cd cd)
    {
      _cds.Add(cd)
    }
  }
}
