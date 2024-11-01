
using System;
using System.Linq;

namespace Not_quantum_traveling_salesman_calculator
{
    class Program
    {
        static void Main()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            double[] xvals = { 10, 13, 12, 4, -17, 14, 14 };
            double[] yvals = { -5, 19, 5, 15, 9, 12, 0 };

            int ptnum1 = 0;
            int ptnum2 = 1;

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

            double[,] dist = new double[12, 12];
            int points = 7;

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


            int iterations = 720;
            int[,] complps = new int[iterations, points + 1];

            double[] complpdist = new double[iterations];

            int rownum = 0;

            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;
            int f = 6;

            while (a < points)
            {
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

                if (a == b || a == c || a == d || a == e|| a == f || b == c || b == d || b == e || b == f || c == d || c == e || c == f || d == e || d == f || e == f || a == points)
                {
                    f++;
                }
                else
                {
                    complps[rownum, 1] = a;
                    complps[rownum, 2] = b;
                    complps[rownum, 3] = c;
                    complps[rownum, 4] = d;
                    complps[rownum, 5] = e;
                    complps[rownum, 6] = f;
                    
                    complpdist[rownum] = dist[complps[rownum, 0], complps[rownum, 1]] + dist[complps[rownum, 1], complps[rownum, 2]] + dist[complps[rownum, 2], complps[rownum, 3]] + dist[complps[rownum, 3], complps[rownum, 4]] + dist[complps[rownum, 4], complps[rownum, 5]] + dist[complps[rownum, 5], complps[rownum, 6]] + dist[complps[rownum, 6], complps[rownum, 7]];

                    rownum++;
                    f++;

                }
            }

            double solution = complpdist.Min();

            rownum = Array.IndexOf(complpdist, solution);

            Console.WriteLine("Solution:");
            Console.WriteLine(complpdist.Min());

            Console.WriteLine();

            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", complps[rownum, 0], complps[rownum, 1], complps[rownum, 2], complps[rownum, 3], complps[rownum, 4], complps[rownum, 5], complps[rownum, 6], complps[rownum, 7]);
            
            watch.Stop();

            Console.WriteLine();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");


        }
    }
}

