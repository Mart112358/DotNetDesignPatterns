using System;
using System.Collections.Generic;

namespace DotNetDesignPatterns.Iterator
{
    public class IteratorTest
    {
        public static void Test()
        {
            var list = new List<string> {"Test1", "Test2", "Test3"};

            using (var enumerator = list.GetEnumerator())
            {
                do
                {
                    if (enumerator.Current == null && enumerator.MoveNext())
                    {
                        // First
                        Console.Write(enumerator.Current);
                    }
                    else
                    {
                        if (enumerator.Current == null) continue;
                        Console.WriteLine(",");
                        Console.Write(enumerator.Current);
                    }
                } while (enumerator.MoveNext());
            }
        }
    }
}