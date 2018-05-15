using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04
{
    class Program
    {
        static void Main(string[] args)
        {
            // 將號碼加入List中

            List<int> members = new List<int>();

            for (int i = 1; i <= 42; i++)
            {
                members.Add(i);
            }

            // 隨機一印出
            Random rand = new Random();

            for (int i = 0; i < 6; i++)
            {
                int r = rand.Next(1, members.Count);
                Console.Write(members[r] + " ");

                // 從List中刪除
                members.RemoveAt(r);
            }

            // 停住畫面
            Console.ReadLine();
        }
    }
}
