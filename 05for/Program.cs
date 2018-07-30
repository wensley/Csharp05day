using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05for
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i < 100)
            //{
            //    Console.WriteLine("下次一定细心！");
            //    i++;
            //}

            //把while转换成for语法
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine("下次一定细心！"+i );
            //}
            //Console.ReadKey();

            //问题1：求1-100间的所有偶数和？
            /*
            int sum=0;
            for (int i = 1; i <= 100; i++)
            {
                if (i%2==0)
                sum = sum + i;
            }
            Console.WriteLine("1-100之间偶数的和为{0}。",sum);
            Console.ReadKey();
            */

            //问题2：找出100-999间的水仙花数？

            //for (int i = 100; i <= 999; i++)
            //{
            //    int ge = i % 10;
            //    int shi = i / 10 % 10;
            //    int bai = i / 100;
            //    if (i==ge*ge*ge+shi*shi*shi+bai*bai*bai)
            //    {
            //        Console.WriteLine("100-999之间的水仙花数为{0}",i);
            //    }
            //}
            //Console.ReadKey();

            //问题3:输出九九乘法表（循环嵌套
            int a = 1;
            int b = 1;
            int sum = 0;
            for (a = 1; a <= 9;a++ )
            {
                for (b = 1; b <= 9; )
                    if (a <= 9 || b <= 9)
                    {
                        sum = a * b;
                        Console.WriteLine("{0}*{1}={2}",a,b,sum);
                        b++;
                    }
            }
            
            Console.ReadKey();
        }
    }
}
