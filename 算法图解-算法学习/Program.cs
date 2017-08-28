using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 算法图解_算法学习
{
    class Program
    {
        /// <summary>
        /// 输入一个int数组与要查找的值,找到返回索引,没找到返回-1
        /// </summary>
        /// <param name="list"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        static int 二分查找法(int[] list , int item)
        {
            int mid = 0;//索引
            int low = 0;//尾
            int high = list.Length - 1;//头
            int re = -1;//返回值
            while(low <= high)//判定条件尾部大于头部,结束
            {
                mid = (low + high) / 2;//返回中间的索引
                int guess = list[mid];
                if(guess == item)//找到了,退出循环
                {
                    re = mid;
                    break;
                }
                else if(guess > item)//超过了
                {
                    high = mid - 1;
                }
                else//小了
                {
                    low = mid + 1;
                }
            }
            return re;
            
        }
        static void Main(string[] args)
        {
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 21, 22, 24, 25, 29, 30 };
            int w =二分查找法(list, 33);
            Console.WriteLine(w);
        }
    }
}
