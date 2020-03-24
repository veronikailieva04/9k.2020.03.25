using System;

namespace _9k._2020._03._25
{
    class Program
    {
        static void Main(string[] args) {
            TestA();
            TestB();
            TestC();

        }

        static void TestA() {
            string line = "";

            Console.WriteLine("\nТест A:\n");
            do {
                Console.WriteLine("Моля, въведете текст по голям от 7 символа (през CTRL+Z за изход):\n");
                line = Console.ReadLine();
            } while (7 > line.Length);

            Console.Write("Текста без първите 3 символа : {0}\n", line.Substring(3));
            Console.Write("Текста без последните 3 символа : {0}\n", line.Substring(0, line.Length - 3));
            Console.Write("Текста без първите и последните 3 символа : {0}\n", line.Substring(3, line.Length - 6));
        }

        static void TestB() {
            bool isAppear;

            Console.WriteLine("\nТест B:\n");
            int[] ints1 = TestB_getNumbers();
            int[] ints2 = TestB_getNumbers();

            Console.Write("\nВсички числа общи за двата списъка: ");
            foreach (var n1 in ints1) {
                foreach (var n2 in ints2) {
                    if (n1 == n2) Console.Write("{0} ", n1);
                }
            }
            Console.Write("\nВсички числа уникални за 1-вия списък: ");
            foreach (var n1 in ints1) {
                isAppear = false;
                foreach (var n2 in ints2) {
                    isAppear = n1 == n2;
                    if (isAppear) break;
                }
                if (!isAppear) Console.Write("{0} ", n1);
            }
            Console.Write("\nВсички числа уникални за 2-рия списък: ");
            foreach (var n1 in ints2) {
                isAppear = false;
                foreach (var n2 in ints1) {
                    isAppear = n1 == n2;
                    if (isAppear) break;
                }
                if (!isAppear) Console.Write("{0} ", n1);
            }
        }

        static int[] TestB_getNumbers() {
            string line = "";
            int lenprev;

            do {
                Console.WriteLine("Моля, въведете поне 5 числа разделени с интервал:\n");
                line = Console.ReadLine().Trim();
                do {
                    lenprev = line.Length;
                    line = line.Replace("  ", " ");
                } while (lenprev != line.Length);
            } while (4 > line.Split(' ').Length - 1);

            return Array.ConvertAll(line.Split(' '), Int32.Parse);
        }

        static void TestC() {
            Console.WriteLine("\nТест C:\n");

            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++) {
                array[i] = int.Parse(Console.ReadLine());
            }

            int odds = 0, evens = 0;
            foreach (var number in array) {
                if (number % 2 == 0) evens += number; else odds += number;
            }

            Console.WriteLine($"({evens}) - ({odds}) = {evens - odds}");
            Console.ReadLine();
        }

    }
}
