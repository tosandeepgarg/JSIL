using System;
using System.Collections.Generic;

public static class Program {
    public static int I = 0;

    public static void Main () {
        Console.WriteLine("{0:0000}ms", Time(TestAdd));
        Console.WriteLine("{0:0000}ms", Time(TestIterate));
    }

    public static int TestAdd () {
        int sum = 0;

        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < 1000; i++) {
            set.Clear();

            for (int j = 0; j < 1000; j++) {
                set.Add(j);
            }

            sum += 1;
        }

        return sum;
    }

    public static int TestIterate () {
        int sum = 0;

        HashSet<int> set = new HashSet<int>();
        for (int j = 0; j < 1000; j++) {
            set.Add(j);
        }

        for (int i = 0; i < 5000; i++) {
            sum = 0;
            foreach (var x in set) {
                sum += x;
            }
        }

        return sum;
    }

    public static int Time (Func<int> func) {
        var started = Environment.TickCount;

        int result = func();

        var ended = Environment.TickCount;
        return ended - started;
    }
}