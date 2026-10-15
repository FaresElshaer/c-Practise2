
using System;
using System.Collections.Generic;
namespace CsharpAdvanced;
public class Program
{
    static void Main(string[] args)
    {
        var numbers=new List<int>(){6,3,8,2,7,5,10};
        //var result=from number in numbers orderby number descending where number>2 select number;
        var result=numbers.OrderByDescending(x => x).Where(x => x > 2);
        foreach (var number in result)
        {
            Console.WriteLine(number);
        }



        //Console.WriteLine("---------------------------------------");
        //numbers.AddRange(new int[] {11,12,13,14,15});
        //foreach (var number in result)
        //{
        //    Console.WriteLine(number);
        //}
        //var result=new List<int>();
        //foreach(var number in numbers)
        //{
        //    if(number>5)
        //        {
        //        result.Add(number);
        //    }
        //}
        //foreach(var number in result)
        //{
        //    Console.WriteLine(number);
        //}
    }
}