using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDelegate1委派練習
{
    delegate double DArea(int d1, int d2);//要宣告在namespace層

    class Program
    {        

        public static double TriA(int H, int B)//方法一
        { return (H * B) / 2; }

        public static double RecA(int L,int W)//方法二
        { return (L * W); }

        public static void GetArea(int x, int y, DArea tv)
        {
            double area = tv(x, y);
            Console.WriteLine($"高：{x}，底：{y}，面積：{area}");
        }

        static void Main(string[] args)
        {
            int d1 = 20, d2 = 10;
            //DArea dv;
            //dv = new DArea(TriA);
            //GetArea(d1, d2, dv);
            Console.WriteLine("1.三角形.........");
            GetArea(d1, d2, new DArea(TriA));//簡寫


            Console.WriteLine("2.矩形..........");
            GetArea(d1, d2, new DArea(RecA));
            Console.Read();



        }
    }
}
