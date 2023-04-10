using Semestrovka;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        //CreateFile();
        //ReadFile();
        Check();
    }
    static void CreateFile()
    {
        int pcount = 0;
        var r = new Random();
        for (int i = 1; i < 51; i++)
        {
            pcount += 10000;
            int[] ints = new int[pcount];
            using (var sw = new StreamWriter($@"C:\Sem\Set{i}.txt",false))
            {
                for (int j = 0; j < pcount; j++)
                {
                    ints[j] = r.Next(-10000, 10000);
                    sw.Write($"{ints[j]} ");

                }
            }
        }
    }
    static void ReadFile()
    {
        int qcount = 0;
        for (int q = 1; q < 51; q++)
        {
            qcount += 10000;
            int[] ints = new int[qcount];
            using (StreamReader sr = new StreamReader($@"C:\Sem\Set{q}.txt"))
            {
                while (sr.Peek() != -1)
                {
                    string[] str = sr.ReadLine().Split(' ');
                    for (int i = 0; i < str.Length - 1; i++)
                    {
                        ints[i] = int.Parse(str[i]);
                    }
                    Stopwatch watch = new Stopwatch();
                    watch.Start();
                    Shellsort(ints);
                    watch.Stop();
                    Console.WriteLine(watch.ElapsedMilliseconds);
                }
            }
        }
    }
    static int[] Shellsort(int[] array)
    {
        int iteration = 0;
        var d = array.Length / 2;
        while (d >= 1)
        {
            for (var i = d; i < array.Length; i++)
            {
                var j = i;
                while ((j >= d) && (array[j - d] > array[j]))
                {
                    (array[j], array[j - d]) = (array[j - d], array[j]);
                    j = j - d;
                    iteration++;
                }
            }
            d = d / 2;
        }
        Console.WriteLine($"Итерации - {iteration}  Кол-во элементов - {array.Length} ");
        return array;
    }
    static void Check()
    {
        var r = new Random();
        int[] t = new int[100];
        for (int i = 0; i < t.Length; i++)
        {
            t[i] = r.Next(-1000, 1000);
        }
        Shellsort(t);
        foreach (var i in t)
        {
            Console.WriteLine(i);
        }
    }
}






