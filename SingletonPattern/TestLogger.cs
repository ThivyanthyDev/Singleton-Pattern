using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._11sigleton
{
    class TestLogger
    {
        static void Main(String[] args)
        {
            Console.WriteLine("---Singleton---");
            Logger obj1 = Logger.GetInstance();
            Logger obj2 = Logger.GetInstance();
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            Console.WriteLine("---Non Singleton---");
            Test obj3 = new Test();
            Test obj4 = new Test();
            Console.WriteLine(obj3.GetHashCode());
            Console.WriteLine(obj4.GetHashCode());

        }

    }
    class Test
    {

    }
}