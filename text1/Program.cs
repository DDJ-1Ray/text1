using System;

namespace text1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
             
            int num1, num2;
            int result = 0;
            //bool True = true;
            try
            {
                Console.WriteLine("請輸入第一個整數: ");
                num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("請輸入第二個整數: ");
                num2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("請輸入運算符: ");
                str = Console.ReadLine();
                switch (str)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("輸入錯誤!除數不能是0!!");
                            //True = false;
                        }
                        else
                        {
                            result = num1 / num2;

                        }
                        break;
                    default:
                        Console.WriteLine("輸入錯誤!請輸入正確的運算符號!!");
                        return;
                }
                Console.WriteLine("運算結果是: {0}", result);
            }
            catch (FormatException)
            {
                Console.WriteLine("輸入錯誤!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("輸入錯誤!!超出輸入范围!!");
                return;
            }
        }
    }
}
