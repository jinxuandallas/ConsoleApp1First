using System;

namespace ConsoleApp1First
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("第一题：\n");
            int inputInt = 0;
            do
            {
                Console.Write("请输入一个正整数：");
                string input = Console.ReadLine();

                int.TryParse(input, out inputInt);
            } while (inputInt < 1);

            Console.WriteLine($"\n两个整数乘积为{inputInt}的所有组合为：");
            for (int i = 1; i <= inputInt; i++)
                for (int j = i + 1; j <= inputInt; j++)
                    if (i * j == inputInt)
                        Console.WriteLine($"{i}*{j}={inputInt}");
        }
    }
}
