using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class teacher
    {
        public string name;
        public string title;
        static public string department;
        public void show()
        {
            Console.WriteLine("姓名：{0}\n职称：{1}",name,title);
        } 
        public static void showD()
        {
            Console.WriteLine("所属院系：{0}",department);
        }
    }

    class Program
    {
        static teacher getTeacher(int i)
        {
            teacher a = new teacher();
            Console.Write("请输入第{0}位的姓名：", i + 1);
            a.name = Console.ReadLine();
            Console.Write("请输入第{0}位的职称：", i + 1);
            a.title = Console.ReadLine();
            return a;
        }
        static void putTeacher(teacher a,int i)
        {
            Console.WriteLine("第{0}位的信息为：", i + 1);
            a.show();
            teacher.showD();
        }


        static void Main(string[] args)
        {
            int count = 0;
            Console.Write("请输入要登记的人数：");
            try
            {
                count = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            Console.WriteLine();

            teacher[] a = new teacher[count];

            Console.Write("请输入所属院系：");
            teacher.department = Console.ReadLine();

            for(int i=0;i<count;i++)
            {
                a[i] = getTeacher(i);
            }

            for(int i=0;i<count;i++)
            {
                putTeacher(a[i],i);
            }

            Console.ReadLine();
        }
    }
}
