using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int X, int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        HashSet<int> waitingForLeaves = new HashSet<int>();
        for(int i = 1; i <= X; i++)
        {
            waitingForLeaves.Add(i);
        }
        for(int i = 0; i < A.Length; i++)
        {
            var item = A[i];
            if(waitingForLeaves.Contains(item))
            {
                waitingForLeaves.Remove(item);
            }
            if(waitingForLeaves.Count == 0)
            {
                return i;
            }
        }
        return -1;
    }
}