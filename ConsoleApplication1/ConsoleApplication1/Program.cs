using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入要登记的学生个数：");
            int i=0;
            try
            {
                i = Convert.ToInt32(Console.ReadLine());
                if(i==0)

                {
                    throw new Exception("输入为0.");
                }
            }
            catch (Exception Mes)
            {
                Console.WriteLine(Mes.Message+"必须输入不为0的数字。");
            }
            Console.WriteLine("请输入要登记的学生姓名：");
            string[] name = new string[i];
            try
            {
                int n = 0;
                for (int j = 0; j < i; j++)
                {
                    
                    name[j] = Console.ReadLine();
                    if (name[j] == "刘博" || name[j] == "王雨晴" || name[j] == "刘宇行")
                    {
                        n = n + 1;                       
                        Console.WriteLine(name[j] + "是小猪！");
                        if (n == 3)
                        {
                            Console.WriteLine("三只小猪齐了！");
                        }
                    }
                    if (name[j]=="关李"|| name[j] == "孙权"|| name[j] == "王明礼")
                    {
                        Console.WriteLine(name[j]+"是帅哥！");
                    }
                }
            }
            catch (Exception Mes)
            {

                Console.WriteLine(Mes.Message);
            }
            Console.WriteLine("已登记的学生如下：");
            foreach (string s in name)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
