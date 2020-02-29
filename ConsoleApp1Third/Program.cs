using System;

namespace ConsoleApp1Third
{
    class Program
    {
        static int _n = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("第三题：\n");

            decimal money = 0, add = 0;
            int b = 0, n = 0;
            do
            {
                Console.Write("输入起始资金：");
                string smoney = Console.ReadLine();
                decimal.TryParse(smoney, out money);
                Console.Write("输入投资收益率（单位：%）：");
                string sb = Console.ReadLine();
                int.TryParse(sb, out b);
                Console.Write("输入每年追加资金：");
                string sadd = Console.ReadLine();
                decimal.TryParse(sadd, out add);
                Console.Write("输入投资年数：");
                string sn = Console.ReadLine();
                int.TryParse(sn, out n);

                Console.WriteLine();
            } while (money <= 0 || add <= 0 || b <= 0);

            decimal acount = compute(money, b, add, n);
            Console.WriteLine($"{n}年后账户总额为：{acount}");
        }

        static decimal compute(decimal money, int b, decimal add, int n)
        {
            _n++;
            decimal _money = money * (1m + (b / 100m)) + add;
            if (_n == n)
                return _money;

            return compute(_money, b, add, n);
        }
    }
}
