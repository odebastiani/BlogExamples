using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionInitializers
{
    public static class Program
    {
        public static void Main()
        {
            TestSystemCollections();
            TestMyCollection();

            Console.Read();
        }

        private static void TestSystemCollections()
        {
            // Array
            string[] array1 = { "x", "y", "z" };
            PrintCollection(array1, "Array: without new[]");

            string[] array2 = new[] { "x", "y", "z" };
            PrintCollection(array2, "Array: new[] { }");

            string[] array3 = new string[] { "x", "y", "z" };
            PrintCollection(array3, "Array: new string[] { }");

            // List
            List<string> list1 = new List<string> { "x", "y", "z" };
            PrintCollection(list1, "List: new List<string> { }");

            List<string> list2 = new List<string>() { "x", "y", "z" };
            PrintCollection(list2, "List: new List<string>() { }");

            List<string> list3 = new List<string>(3) { "x", "y", "z" };
            PrintCollection(list3, "List: new List<string>(<ARG>) { }");

            List<string> list4 = new() { "x", "y", "z" };
            PrintCollection(list4, "List: new() { }");

            // Dictionary
            Dictionary<string, string> dictionary1 = new Dictionary<string, string>()
            {
                { "x1", "x2" },
                { "y1", "y2" }
            };
            PrintCollection(dictionary1, "Dictionary: new Dictionary<string, string>() { {,} }");

            Dictionary<string, string> dictionary2 = new Dictionary<string, string>()
            {
                ["x1"] = "x2",
                ["y1"] = "y2"
            };
            PrintCollection(dictionary2, "Dictionary: new Dictionary<string, string>() { [x] = y }");
        }

        private static void TestMyCollection()
        {
            // Custom Collection with Object Initializer
            MyCollection col1 = new MyCollection()
            {
                99,
                "x",
                "y"
            };

            PrintCollection(col1, "Custom: new MyCollection() { int, string, string }");

            MyCollection col2 = new MyCollection()
            {
                { 1, 2 },
                { "x", "y", "z" },
                "z"
            };

            PrintCollection(col2, "Custom: new MyCollection() { { string, string }, string }");

            MyCollection col3 = new MyCollection()
            {
                [1] = "X",
                [2, 3] = "Y"
            };

            PrintCollection(col3, "Custom: new MyCollection() { [int] = string, [int, int] = string }");

            // Custom Collection with Add method
            MyCollection col4 = new MyCollection();
            col4.Add(99); // int
            col4.Add("x"); // string
            col4.Add("y"); // string

            PrintCollection(col4, "Custom: With Add Method");

            MyCollection col5 = new MyCollection();
            col5.Add(1, 2); // int, int
            col5.Add("x", "y", "z"); // params string[]
            col5.Add("z"); // string

            PrintCollection(col5, "Custom: With Add Method");

            MyCollection col6 = new MyCollection();
            col6[1] = "X"; // indexer[int] = string
            col6[2, 3] = "Y"; // indexer[int, int] = string

            PrintCollection(col6, "Custom: With Indexer");
        }

        private static void PrintCollection(IEnumerable collection, string title)
        {
            Console.WriteLine();
            Console.WriteLine(title);

            foreach (object item in collection)
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
