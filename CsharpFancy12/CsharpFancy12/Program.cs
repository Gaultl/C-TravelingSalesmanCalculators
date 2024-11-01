using System;
using System.Linq;

namespace CsharpTravellingSalesmanCalulator
{
    class Program
    {
        static void Main()
        {
            //This starts a timer
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            double[] xvals = { 10, 13, 12, 4, -17, 14, 14, -7, -14, 4, 6, 4 };
            double[] yvals = { -5, 19, 5, 15, 9, 12, 0, 3, -6, -12, -19, 4 };

            int ptnum1 = 0;
            int ptnum2 = 1;

            //This prints out the x and y values
            Console.WriteLine("X values:");

            foreach (int i in xvals)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("Y values:");

            foreach (int i in yvals)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            //This creates an array to store the distances between the points
            double[,] dist = new double[12, 12];
            int points = 12;

            //This calculates the distances between the points and stores them in a reachable place in the array of distances
            while (ptnum2 < points)
            {
                double x1 = xvals[ptnum1];
                double x2 = xvals[ptnum2];
                double y1 = yvals[ptnum1];
                double y2 = yvals[ptnum2];
                dist[ptnum1, ptnum2] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                dist[ptnum2, ptnum1] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                ptnum2++;
            }

            ptnum1++;
            ptnum2 = 2;

            while (ptnum2 < points)
            {
                double x1 = xvals[ptnum1];
                double x2 = xvals[ptnum2];
                double y1 = yvals[ptnum1];
                double y2 = yvals[ptnum2];
                dist[ptnum1, ptnum2] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                dist[ptnum2, ptnum1] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                ptnum2++;
            }

            ptnum1++;
            ptnum2 = 3;

            while (ptnum2 < points)
            {
                double x1 = xvals[ptnum1];
                double x2 = xvals[ptnum2];
                double y1 = yvals[ptnum1];
                double y2 = yvals[ptnum2];
                dist[ptnum1, ptnum2] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                dist[ptnum2, ptnum1] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                ptnum2++;
            }

            ptnum1++;
            ptnum2 = 4;

            while (ptnum2 < points)
            {
                double x1 = xvals[ptnum1];
                double x2 = xvals[ptnum2];
                double y1 = yvals[ptnum1];
                double y2 = yvals[ptnum2];
                dist[ptnum1, ptnum2] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                dist[ptnum2, ptnum1] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                ptnum2++;
            }

            ptnum1++;
            ptnum2 = 5;

            while (ptnum2 < points)
            {
                double x1 = xvals[ptnum1];
                double x2 = xvals[ptnum2];
                double y1 = yvals[ptnum1];
                double y2 = yvals[ptnum2];
                dist[ptnum1, ptnum2] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                dist[ptnum2, ptnum1] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                ptnum2++;
            }

            ptnum1++;
            ptnum2 = 6;

            while (ptnum2 < points)
            {
                double x1 = xvals[ptnum1];
                double x2 = xvals[ptnum2];
                double y1 = yvals[ptnum1];
                double y2 = yvals[ptnum2];
                dist[ptnum1, ptnum2] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                dist[ptnum2, ptnum1] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                ptnum2++;
            }

            ptnum1++;
            ptnum2 = 7;

            while (ptnum2 < points)
            {
                double x1 = xvals[ptnum1];
                double x2 = xvals[ptnum2];
                double y1 = yvals[ptnum1];
                double y2 = yvals[ptnum2];
                dist[ptnum1, ptnum2] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                dist[ptnum2, ptnum1] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                ptnum2++;
            }

            ptnum1++;
            ptnum2 = 8;

            while (ptnum2 < points)
            {
                double x1 = xvals[ptnum1];
                double x2 = xvals[ptnum2];
                double y1 = yvals[ptnum1];
                double y2 = yvals[ptnum2];
                dist[ptnum1, ptnum2] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                dist[ptnum2, ptnum1] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                ptnum2++;
            }

            ptnum1++;
            ptnum2 = 9;

            while (ptnum2 < points)
            {
                double x1 = xvals[ptnum1];
                double x2 = xvals[ptnum2];
                double y1 = yvals[ptnum1];
                double y2 = yvals[ptnum2];
                dist[ptnum1, ptnum2] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                dist[ptnum2, ptnum1] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                ptnum2++;
            }

            ptnum1++;
            ptnum2 = 10;

            while (ptnum2 < points)
            {
                double x1 = xvals[ptnum1];
                double x2 = xvals[ptnum2];
                double y1 = yvals[ptnum1];
                double y2 = yvals[ptnum2];
                dist[ptnum1, ptnum2] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                dist[ptnum2, ptnum1] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                ptnum2++;
            }

            ptnum1++;
            ptnum2 = 11;

            while (ptnum2 < points)
            {
                double x1 = xvals[ptnum1];
                double x2 = xvals[ptnum2];
                double y1 = yvals[ptnum1];
                double y2 = yvals[ptnum2];
                dist[ptnum1, ptnum2] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                dist[ptnum2, ptnum1] = (Math.Sqrt(Math.Abs((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
                ptnum2++;
            }

            //This creates an array to store all of the different loops and their lenghts
            int iterations = 39916800;
            int[,] complps = new int[iterations, points + 1];

            double[] complpdist = new double[iterations];

            int rownum = 0;

            //This is a counting system to go through all of the possible iterations of loops
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;
            int f = 6;
            int g = 7;
            int h = 8;
            int j = 9;
            int k = 10;
            int l = 11;

            while (a < points)
            {
                if (l == points)
                {
                    l = 1;
                    k++;
                }
                if (k == points)
                {
                    k = 1;
                    j++;
                }
                if (j == points)
                {
                    j = 1;
                    h++;
                }
                if (h == points)
                {
                    h = 1;
                    g++;
                }
                if (g == points)
                {
                    g = 1;
                    f++;
                }
                if (f == points)
                {
                    f = 1;
                    e++;
                }
                if (e == points)
                {
                    e = 1;
                    d++;
                }
                if (d == points)
                {
                    d = 1;
                    c++;
                }
                if (c == points)
                {
                    c = 1;
                    b++;
                }
                if (b == points)
                {
                    b = 1;
                    a++;
                }
                //This checks to see if any of the points are repeated or if it has gone through all of the iterations, if either of these are true it does not calculate the loop distance
                if (a == b || a == c || a == d || a == e || a == f || a == g || a == h || a == j || a == k || a == l 
                    || b == c || b == d || b == e || b == f || b == g || b == h || b == j || b == k || b == l 
                    || c == d || c == e || c == f || c == g || c == h || c == j || c == k || c == l 
                    || d == e || d == f || d == g || d == h || d == j || d == k || d == l 
                    || e == f || e == g || e == h || e == j || e == k || e == l 
                    || f == g || f == h || f == j || f == k || f == l 
                    || g == h || g == j || g == k || g == l 
                    || h == j || h == k || h == l 
                    || j == k || j == l 
                    || k == l 
                    || a == points)
                {
                    l++;
                }
                //This finds and calulates the length of the loop then stores the length and the loop in arrays
                else
                {
                    complps[rownum, 1] = a;
                    complps[rownum, 2] = b;
                    complps[rownum, 3] = c;
                    complps[rownum, 4] = d;
                    complps[rownum, 5] = e;
                    complps[rownum, 6] = f;
                    complps[rownum, 7] = g;
                    complps[rownum, 8] = h;
                    complps[rownum, 9] = j;
                    complps[rownum, 10] = k;
                    complps[rownum, 11] = l;
                    complpdist[rownum] = dist[complps[rownum, 0], complps[rownum, 1]] + dist[complps[rownum, 1], complps[rownum, 2]] + dist[complps[rownum, 2], complps[rownum, 3]] + dist[complps[rownum, 3], complps[rownum, 4]] + dist[complps[rownum, 4], complps[rownum, 5]] + dist[complps[rownum, 5], complps[rownum, 6]] + dist[complps[rownum, 6], complps[rownum, 7]] + dist[complps[rownum, 7], complps[rownum, 8]] + dist[complps[rownum, 8], complps[rownum, 9]] + dist[complps[rownum, 9], complps[rownum, 10]] + dist[complps[rownum, 10], complps[rownum, 11]] + dist[complps[rownum, 11], complps[rownum, 12]];

                    rownum++;
                    l++;

                }
            }

            //This searches the array of lenghts and finds the shortest loop and then finds the order of the points in that loop
            double solution = complpdist.Min();

            rownum = Array.IndexOf(complpdist, solution);

            //This writes out the shortest path, the order of the points, and the time it took in milliseconds
            Console.WriteLine("Solution:");
            Console.WriteLine(complpdist.Min());

            Console.WriteLine();

            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} ", complps[rownum, 0], complps[rownum, 1], complps[rownum, 2], complps[rownum, 3], complps[rownum, 4], complps[rownum, 5], complps[rownum, 6], complps[rownum, 7], complps[rownum, 8], complps[rownum, 9], complps[rownum, 10], complps[rownum, 11], complps[rownum, 12]);

            watch.Stop();

            Console.WriteLine();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");


        }
    }
}
