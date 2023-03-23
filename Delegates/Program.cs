
using Delegates;

class Program
{
    static void Main()
    {
        List<int> t = new List<int> { 1, 2 ,3};
        var dt = new Delegate<int>(t);
        Console.WriteLine(dt);   
        //dt.Aggregate2<int>((x, y) => x + y, 0);
        dt.Aggregate2<int>((x,y) =>  x,0);
        dt.Aggregate2<int>((x, y) => y, 0);
        dt.Aggregate2<int>((x, y) => x * 2 + y * 2, 0);
        dt.Aggregate2<int>((x, y) => x * 2 + y, 0);
        Console.WriteLine("_________________");



        List<int> q = new List<int> { 1, 2, 3, 4, 1000, 2424, 21,-1,3 };
        var dq = new Delegate<int>(q);
        Console.WriteLine(dq);
        dq.Aggregate2<int>((x,y) => Math.Max(x,y),0);
        dq.Aggregate2<int>((x, y) => Math.Min(x, y), 0);
        Console.WriteLine("_________________");


        List<string> str = new List<string> { "B", "u", "l", "a", "t" };
        var dstr = new Delegate<string>(str);
        Console.WriteLine(dstr);
        dstr.Aggregate2<string>((x,y) => y + x,"");
        dstr.Aggregate2<string>((x, y) => x + y, "");
        Console.WriteLine("_________________");


        var list = new List<int> { -1,-2,-3,-10,0,1,2,3,4,5,6,7,8};
        var dlist = new Delegate<int>(list);
        dlist.Count(x => x > 0);
        dt.Count(x => x % 2 == 0);
        dt.Count(x => x % 2 == 1);
        dt.Count(x => x % 2 != 0 && x > 5);

        //dt.Aggregate1<int>((x, y) => x + y);

    }
}


