using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04do_while练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1：计算1-100之前整数的和；
            /* 

             int i=1;
             int sum = 0;

             while (i<= 100)
             {
                     sum = sum + i;
                     i++;

             }
             Console.WriteLine(sum);
             Console.ReadKey();
             */

            //练习2
            //方案1
            /*
            string userName, passWord;
            bool flag = false;
            do
            {
                flag = false;
                Console.WriteLine("请输入用户名：");
                userName = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                passWord = Console.ReadLine();

                if (userName != "admin" || passWord != "888888")
                {
                    Console.WriteLine("用户名或密码错误，请重新输入！");
                    flag = true;
                }
            }
            while (flag);
            Console.WriteLine("登陆成功！");
            Console.ReadKey();
            */
            //方案2
            /*
            string userName, passWord;
            
            do
            {
                Console.WriteLine("请输入用户名：");
                userName = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                passWord = Console.ReadLine();

                if (userName != "admin" || passWord != "888888")
                {
                    Console.WriteLine("用户名或密码错误，请重新输入！");
                }
            }
            while (userName != "admin" || passWord != "888888");
            Console.WriteLine("登陆成功！");
            
            Console.ReadKey();
            */

            /*
            //练习3
            string name;
            do
            {
                Console.WriteLine("请输入学生的姓名：");
                name = Console.ReadLine();
            }
            while (name!="q");
           
            Console.WriteLine("结束！");

            Console.ReadKey();
            */
            //练习4
            //方案1
            /*
            int num;
            bool flag = true;
            do
            {

                try
                {
                    Console.WriteLine("请输入一个数字：");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0}的2倍是{1}.", num, num * 2);
                }
                catch
                {
                    Console.WriteLine("输入错误！请输入一个数字！");//不提示也可以
                    flag = false;
                }
            }
            //while (answer == "q");不用考虑q的问题，想多了
            while (flag);
            Console.WriteLine("结束！");
            Console.ReadKey();  
            */
            //方案2
            /*
            string input;
            int number;
            Console.WriteLine("请输入一个数字：");
            input = Console.ReadLine();
            while (input != "q")
            {

                number = Convert.ToInt32(input);//把用户的输入转换成int类型的number
                Console.WriteLine("{0}的2倍是{1}.", number, number * 2);
                Console.WriteLine("请输入一个数字：");
                input = Console.ReadLine();
            }
            Console.WriteLine("结束！");
            Console.ReadKey();
            */
            //练习5
            /*
            int num = 0;
            int max = 0;
            //string over = "end";应该先只是定义不赋值
            string input="";//先赋予空值，否则报错提示“使用了未赋值的局部变量”
            bool flag = false;
            do
            {
                try
                {
                    Console.WriteLine("请输入一个数字：");
                    input = Console.ReadLine();
                    num = Convert.ToInt32(input);
                    if ( num>max)//这道题没做出来就是因为不知道怎么处理记录最大值
                    {
                        max = num;
                    }
                }
                catch
                {
                    if (input != "end")//前面定义的时候可以先赋空值
                    {
                        Console.WriteLine("输入错误！请输入一个数字！");
                        input = "end";//用来解决input不等于end的死循环
                        flag = true;
                    }
                }
                    
            }
            while (input != "end");
            if (flag == false)
            {
                Console.WriteLine("程序结束！您的输入中最大的值为{0}！", max);
                flag = true;
            }
            
            Console.ReadKey();
            */

            //练习6
            /*
            string answer;
            do
            {
                Console.WriteLine("张三唱一首歌曲");
                Console.WriteLine("老师你满意吗？(y/n)");
                answer = Console.ReadLine();
            }
            while (answer == "n");
            Console.WriteLine("下课");
            Console.ReadKey();
            */
        }
    }
}
