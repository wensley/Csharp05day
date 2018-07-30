using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06水仙花数
{
    class Program
    {
        static void Main(string[] args)
        {
            //问题2：找出100-999间的水仙花数？
            /*
            for (int i = 100; i <= 999; i++)
            {
                int ge = i % 10;
                int shi = i / 10 % 10;
                int bai = i / 100;
                if (i == ge * ge * ge + shi * shi * shi + bai * bai * bai)
                {
                    Console.WriteLine("100-999之间的水仙花数为{0}", i);
                }
            }
            Console.ReadKey();
            */
        
            //例子
            int k = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("我爱你！"+ ++k);
                }
            }
            Console.ReadKey();

            //特例
            /*
            for (表达式1可以空 ; 表达式2不能空; 表达式3可以空)
            {
                Console.WriteLine("我爱你！" + ++i);
            }
            */

        }
    }
}
