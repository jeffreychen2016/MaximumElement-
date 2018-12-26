using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

// class Input
// {
//     public long Type { get; set; }
//     public long Value { get; set; }
// }

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        // SOLUTION 1: (this will timeout after test case 17)
        //         var N = Convert.ToInt64(Console.ReadLine());
        //         var inputs = new List<Input>();
        //         var stack = new List<Input>();
        //         var value = 0L;

        //         for (var i = 0; i < N; i++)
        //         {
        //             var line = Console.ReadLine();
        //             if (line[0] == '1')
        //             {
        //                 value = Convert.ToInt64(line.Substring(2));
        //                 // Console.WriteLine(value);
        //                 inputs.Add(new Input() { Type = 1, Value = value });
        //             }
        //             else if (line[0] == '2')
        //             {
        //                 inputs.Add(new Input() { Type = 2, Value = 0 });
        //             }
        //             else if (line[0] == '3')
        //             {
        //                 inputs.Add(new Input() { Type = 3, Value = 0 });
        //             }
        //         }

        //         // foreach (var input in inputs)
        //         // {
        //         //     Console.WriteLine(input.type);
        //         // }

        //         foreach (var input in inputs)
        //         {
        //             if (input.Type == 1)
        //             {
        //                 stack.Add(input);
        //             }
        //             else if (input.Type == 2)
        //             {
        //                 stack.RemoveAt(stack.Count - 1);
        //             }
        //             else if (input.Type == 3)
        //             {
        //                 // Console.WriteLine(stack.Count);
        //                 Console.WriteLine(stack.Max(i => i.Value));
        //             }
        //         }

        // SOLUTION 2: (still getting timeout error after case 17.)
        //         var N = Convert.ToInt64(Console.ReadLine());
        //         var stack = new List<long>();

        //         for (var i = 0; i < N; i++)
        //         {
        //             var line = Console.ReadLine();
        //             if (line[0] == '1')
        //             {
        //                 var value = Convert.ToInt64(line.Substring(2));
        //                 stack.Add(value);
        //             }
        //             else if (line[0] == '2')
        //             {
        //                 stack.RemoveAt(stack.Count - 1);
        //             }
        //             else if (line[0] == '3')
        //             {
        //                 Console.WriteLine(stack.Max(val => val));
        //             }
        //         }

        // SOLUTION 3: (Well... still timing out after test case 17... )
        var N = Convert.ToInt64(Console.ReadLine());
        var stack = new Stack();

        for (var i = 0; i < N; i++)
        {
            var line = Console.ReadLine();
            if (line[0] == '1')
            {
                var value = Convert.ToInt64(line.Substring(2));
                stack.Push(value);
            }
            else if (line[0] == '2')
            {
                stack.Pop();
            }
            else if (line[0] == '3')
            {
                Console.WriteLine(stack.ToArray().Max());
            }
        }
    }
}