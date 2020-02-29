using System;
using System.IO;

namespace ConsoleApp1Fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("第四题：\n");

            int letter = 0, number = 0, space = 0, symbol = 0;
            string txtfile = @"..\..\..\TextFile1.txt";
            try
            {
                using (StreamReader sr = new StreamReader(txtfile))
                {
                    string txt = sr.ReadToEnd();
                    foreach (char c in txt)
                    {
                        int cn = Convert.ToInt32(c);
                        if (cn <= 57 && cn >= 48)
                            number++;
                        else if (cn == 32)
                            space++;
                        else if ((cn >= 65 && cn <= 90) || (cn >= 97 && cn <= 127))
                            letter++;
                        else
                            symbol++;
                    }
                    FileInfo fi = new FileInfo(txtfile);
                    Console.WriteLine($"TextFile1文件创建时间是{fi.CreationTime},文件大小{fi.Length}字节");
                    Console.WriteLine($"TextFile1一共有{txt.Length}个字符，有{number}个数字，{letter}个字母，{space}个空格，{symbol}个符号");
                    //Console.WriteLine(sr.ReadToEnd());

                    //while ((line = sr.ReadLine()) != null)
                    //{
                    //    Console.WriteLine(line);
                    //}
                }
            }
            catch (Exception e)
            {
                // 向用户显示出错消息
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
