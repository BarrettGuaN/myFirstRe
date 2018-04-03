using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public class bank
    {
        public long money=0;

        static public void query(long money)//查询功能
        {
            Console.WriteLine("您当前的余额为：{0}", money);
        }

        static public long save(long money)//存钱功能
        {
            long plus = 0;
            Console.Write("请输入您要存入的金额:");
            plus = getLongNum();
            money = money + plus;
            Console.WriteLine("您目前的账户余额为:{0}",money);
            return money;
        }

        static public long withdraw(long money)//取款功能
        {
            long minus = 0;
            Console.Write("请输入您要取的金额:");
            minus = getLongNum();
            if (money > minus)
                money = money - minus;
            else
                Console.WriteLine("您目前的余额不足！");
            Console.WriteLine("您目前的账户余额为:{0}",money);
            return money;
        }

        static public long newAccount(long money)//开户功能
        {
            while(true)
            {
                Console.WriteLine("请开户，请输入您要存的金额:");
                money = getLongNum();
                if (money > 5)
                {
                    Console.WriteLine("开户成功！您目前的余额为：{0}",money);
                    return money;
                }
                else
                    Console.WriteLine("对不起，开户金额不能小于5，请重试。");
            }
        }

        public static long getLongNum()//获取长整型并纠错的方法
        {
            long i = 0;
            while (true)
            {
                try
                {
                    i = Convert.ToInt64(Console.ReadLine());
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message + "请重试。");
                }
                return i;
            }
        }
    }

    


    class Program
    {

        static int getInt32()
        {
            int i = 0;
            while(true)
            {
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                    return i;
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message + "请重试。");
                }
            }
        }

        static void Main(string[] args)
        {
            
            bank newAccount = new bank();

            newAccount.money = bank.newAccount(newAccount.money);//开户

            bool j = true;
            while (j)
            {
                Console.WriteLine("您可以办理的业务：\n1.存钱\n2.取钱\n3.查询");//功能选项部分
                Console.Write("请选择<1/2/3>:");
                switch(getInt32())
                {
                    case 1:
                            newAccount.money=bank.save(newAccount.money);
                            break;
                    case 2:
                            newAccount.money = bank.withdraw(newAccount.money);
                            break;
                    case 3:
                            bank.query(newAccount.money);
                            break;
                    default:
                            Console.WriteLine("输入有误，请重新输入。");
                            continue;
                }

                Console.WriteLine("是否继续操作？<y/n>");
                switch(Console.Read())
                {
                    case 'y':
                    case 'Y':
                        j = true;
                        break;
                    case 'n':
                    case 'N':
                        j = false;
                        break;
                }
            }

        }
    }
}
