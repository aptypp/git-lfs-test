using System.Collections.ObjectModel;

namespace Test;

class Program
{
    static void Main(
        string[] args)
    {
        var list = new List<int> { 1, 2, 3 };
        var readonlyCollection = new ReadOnlyCollection<int>(list);
        var readonlyList = list as IReadOnlyList<int>;
        var ilist = readonlyCollection as IList<int>;
        
        ilist.Add(2);
    }
}