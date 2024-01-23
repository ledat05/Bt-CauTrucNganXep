using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt_CauTrucNganXep
{
    internal class Program
    {

        class Stack
        {
            private int[] data;
            private int top;

            public Stack()
            {
                data = new int[100];
                top = -1;
            }

            public Stack(int size)
            {
                data = new int[size];
                top = -1;
            }

            public bool IsEmpty()
            {
                return top == -1;
            }

            public bool IsFull()
            {
                return top == data.Length - 1;
            }

            public void Push(int x)
            {
                if (IsFull())
                {
                    Console.WriteLine("Ngăn xếp đã đầy! Thêm không thành công");
                }
                else
                {
                    data[++top] = x;
                }
            }

            public int Pop()
            {
                int result = 0;
                if (IsEmpty())
                {
                    Console.WriteLine("Ngăn xếp còn trống");
                }
                else
                {
                    result = data[top--];
                }
                return result;
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            {
                string chon = "y";

                while (chon.ToLower() != "n")
                {
                    int n;
                    Console.WriteLine("Nhập số hệ 10:");
                    n = int.Parse(Console.ReadLine());

                    Console.WriteLine("Nhập cơ số cần đổi (2, 8, 16):");
                    int x = int.Parse(Console.ReadLine());

                    Stack s = new Stack();

                    while (n > 0)
                    {
                        s.Push(n % x);
                        n = n / x;
                    }

                    Console.WriteLine($"Biểu diễn hệ {x}:");
                    while (!s.IsEmpty())
                    {
                        Console.Write(s.Pop());
                    }

                    Console.Write("\n Tiếp tục (y/n)? ");
                    chon = Console.ReadLine();
                }
            }
        }
    }
}


