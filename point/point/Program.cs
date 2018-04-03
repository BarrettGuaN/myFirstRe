using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point
{

    public class point
    {
        public double x;
        public double y;

        public point()
        {
            x = 0;
            y = 0;
        }
        public point(double x,double y)
        {
            this.x = x;
            this.y = y;
        }

        public point(int i)
        {
            Console.WriteLine("请输入第{0}个点的坐标:",i+1);
            try
            {
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception exp)
            {
                x = 0;y = 0;
                Console.WriteLine(exp.Message+"已将错误坐标改为(0,0)");
            }
        }

        static public double distance(double x1,double x2,double y1,double y2)
        {
            double d=0;
            d = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
            return d;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("<----------两点距离运算---------->");
            Console.Write("请输入你要进行运算的次数：");
            try
            {
                count = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            point[] points = new point[2*count];
            for(int i=0;i<2*count;i++)
            {
                points[i] = new point(i);
                if (i%2==1)
                {
                    double d = point.distance(points[i-1].x,points[i].x, points[i-1].y, points[i].y);
                    Console.WriteLine("点({0},{1})和({2},{3})的距离为:{4}", points[i - 1].x, points[i - 1].y, points[i].x, points[i].y,d);
                }
            }

            Console.ReadLine();
        }
    }
}
