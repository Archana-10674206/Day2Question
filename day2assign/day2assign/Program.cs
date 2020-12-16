using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2assign
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, end,flag;
            start = int.Parse(Console.ReadLine());
            end = int.Parse(Console.ReadLine());
            if (start == 0 || start == 1)
                start = 2;
                for (int i = start; i <= end; i++)
                {
                    flag = 1;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = 0;
                            break;
                        }
                    }
                    if (flag == 1)
                        Console.Write(" "+i);
                }
            
        }
    }
}
