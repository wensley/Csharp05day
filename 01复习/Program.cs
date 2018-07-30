using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //练习2
            Console.WriteLine("请输入班级总人数：");
            int ren = Convert.ToInt32(Console.ReadLine());
            int score = 0;
            int i = 0;//我没有定义这个变量
            int sum = 0; //存用户的总成绩,我没有定义这个变量
            while (i < ren)
            {
                Console.WriteLine("请输入第{0}名学员的成绩：", i + 1);
                score = Convert.ToInt32(Console.ReadLine());
                sum += score;  //等于sum=sum+score；这个表达式等于重复赋值sum，并累加score成绩值
                i++;//应该是i++，我原来写的ren++这个变量是不对的

                // Console.WriteLine("班级学员的平均成绩为{0}，总成绩为{1}",score/ren,ren+ren);
            }
            Console.WriteLine("班级总学员{0}名，总成绩为{1}分，平均成绩为{2}分", ren, sum, sum / ren);
            */
            //练习3
            /*            
            Console.WriteLine("这道题你会做了吗？(y/n)");
            string input = Console.ReadLine();
            int i = 0;
            while (input=="n"||i<=10)//需要灵活运用字符串
            {
               
                    Console.WriteLine("老师讲一遍题！");
                    i++;
                    Console.WriteLine("这道题你会做了吗？(y/n)");
                    input = Console.ReadLine();
                    
            }
            Console.WriteLine("放学！");
            */

            //练习4

            int year = 2006;
            double stu = 80000;
            while (stu<200000)
            {
                stu = stu * 1.25;   //计算人数增加25%后的值
                year++;

            }

            Console.WriteLine(year);
            Console.ReadKey();

        }
    }
}
