using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static System.Console;

namespace ConsoleApp1
{
    class Class2 
    {
        /*class MyClass<T> 
        {
            public T value;
            public MyClass(T value)
            {
                this.value = value;
            }
        }*/

        class SquareCalulator
        {
            public int this[int i]
            {
                get { return i * i; }
            }
            
        }
        static void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }

        static void Div(int x, int y, out int rx, out int ry)
        {
            rx = x / y;
            ry = x % y;
        }

        class ATest 
        {
            public string str;
            public int idx;

            public ATest(string s, int i)
            {
                str = s;
                idx = i;
            }
        }

        static void Main(string[] args)
        {
            /*MyClass<string> mcl = new MyClass<string>("aa");
            MyClass<int> mc2 = new MyClass<int>(123);
           
            MyClass<Class2> mc3 = new MyClass<Class2>(new Class2());*/

            //SquareCalulator square = new SquareCalulator();
            //Console.WriteLine(square[10]);

            /*int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;
            NextPosition(x, y, vx, vy, out x, out y);*/
            //int x, y;
            //Div(10, 3, out x, out y);
            //Console.WriteLine($"몫: {x} 나머지: {y}");

            //배열 정렬(오름/내림차순)
            /*int[] arr = new int[] {3,6,1,7,2};
            foreach (var v in arr) Console.Write(v + " ");
            Console.WriteLine();
            Array.Sort(arr);
            foreach (var v in arr) Console.Write(v + " ");
            Console.WriteLine();
            Array.Reverse(arr);
            foreach (var v in arr) Console.Write(v + " ");*/

            //리스트 정렬(오름/내림차순)
            /*List<double> list = new List<double>() {6.8, -9,0, 9.8, 3.14, 1.2,10.7};
            foreach (var v in list) Write(v+" ");
            WriteLine();
            list.Sort();
            foreach (var v in list) Write(v + " ");
            WriteLine();
            list.Reverse();
            foreach (var v in list) Write(v + " ");*/

            //클래스를 담고있는 리스트 정렬. 클래스 속의 int 자료형 변수 기준으로 리스트를 내림/오름차순 정렬
            List<ATest> l = new List<ATest>();
            l.Add(new ATest("p1", 9));
            l.Add(new ATest("p2", 2));
            l.Add(new ATest("p3", 10));
            foreach (var a in l) Write(a.str + ":" + a.idx + ", ");
            WriteLine();

            //ATest[] r = l.ToArray();라는 것도 있음.

            //방법 1 (람다 사용, Linq 사용 X)
            /*l.Sort((a, b) => a.idx.CompareTo(b.idx));
            foreach (var a in l) Write(a.str + ":" + a.idx + ", ");
            WriteLine();
            l.Reverse();
            foreach (var a in l) Write(a.str + ":" + a.idx + ", ");*/

            //방법 2 (Linq 사용)
            List<ATest> st = l.OrderBy(x => x.idx).ToList();
            foreach (var a in st) Write(a.str + ":" + a.idx + ", ");
            WriteLine();
            st = l.OrderByDescending(x => x.idx).ToList();
            foreach (var a in st) Write(a.str + ":" + a.idx + ", ");
        }
    }
}
