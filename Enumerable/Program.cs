using Enumerable;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        var text = "bamfefr bamff bimfrfrfrfrf bimfrfrfr beme b yr oeeo prpt";
        WordsInTextcs s = new WordsInTextcs(text);
        foreach (var item in s)
            Console.WriteLine(item);
     
        foreach (var item in s)
            Console.WriteLine(item);

        var text1 = "1 23 456 7890";
        WordsInTextcs s1 = new WordsInTextcs(text1);
        foreach (var c in s1) 
            Console.WriteLine(c);

    }
}
    

