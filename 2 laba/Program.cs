using System;
using System.Text;

namespace _2_laba
{
    class Program
    {
        static void Main(string[] args)
        {
            //Типы
            string name = "Tanya";
            int age = 18;
            bool student = true;
            double weight = 56.65;
            byte bit1 = 1;
            sbyte bit2 = -101;
            short n2 = 102;
            ushort n1 = 1;
            int a = 10;
            uint b = 23u;
            long c = -15L;
            ulong f = 19ul;
            char z = '\x5A';
            string hello = "Hello World!";
            object pi = 3.14;
            float ya = 26.05f;
            decimal r = 0.18m;
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Вес: {weight}");
            Console.WriteLine($"Студент: {student}");
            Console.WriteLine($"Тип byte: {bit1}");
            Console.WriteLine($"Тип sbyte: {bit2}");
            Console.WriteLine($"Тип short: {n2}");
            Console.WriteLine($"Тип ushort: {n1}");
            Console.WriteLine($"Тип int: {a}");
            Console.WriteLine($"Тип uint: {b}");
            Console.WriteLine($"Тип long: {c}");
            Console.WriteLine($"Тип ulong: {f}");
            Console.WriteLine($"Тип char: {z}");
            Console.WriteLine($"Тип string: {hello}");
            Console.WriteLine($"Тип object: {pi}");
            Console.WriteLine($"Тип float: {ya}");
            Console.WriteLine($"Тип decimal: {r}");
            //Неявное приведение
            int a11 = 111111111;
            long b11 = a11;

            byte a22 = 22;
            ushort b22 = a22;

            uint a33 = 2323233;
            ulong b33 = a33;

            sbyte a44 = 127;
            short b44 = a44;
            //Явное приведение
            Console.WriteLine("Явное приведение:");
            double x = 1234.7;
            Console.WriteLine("double: " + x);
            int a55;
            a55 = (int)x;
            Console.WriteLine("int: " + a55);
            //Упаковка
            int sum = 666;
            object osum = sum;
            //Распаковка
            int sum1 = (int)osum;
            //Работа с неявно типизированной переменной
            Console.WriteLine("Пример с неявно типизированной переменной:");
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            //Работа с Nullable переменной
            int? q = 6489;
            if (q != null)
            {
                Console.WriteLine($"Переменная 'c' равна {q.Value}");
            }
            else
            {
                Console.WriteLine("Переменная 'c' не имеет значения.");
            }
            //Строки
            Console.WriteLine($"Введите две строки:");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            Console.WriteLine("Результат сравнения:" + (s1 == s2));
            //Работа со строками
            string str1 = "Доброе утро";
            string str2 = "Добрый день";
            string str3 = "Добрый вечер";
            //сцепление
            string text = str1 + str2 + str3;
            Console.WriteLine("Результат сцепления:" + text);
            //копирование
            string n = str1.Substring(0, 6);
            Console.WriteLine("Результат копирования:" + n);
            //выделение подстроки
            Console.WriteLine("Выделение подстроки:" + (text.Substring(0, 4)));
            //разделение строки на слова
            string[] words = str1.Split(' ');
            Console.WriteLine("Певрое слово:" + words[0]);
            Console.WriteLine("Второе слово:" + words[1]);
            //вставки подстроки в заданную позицию
            string modif1 = str2.Insert(6, str1);
            Console.WriteLine("После вставки подстроки: " + modif1);
            // удаление заданной подстроки
            string modif2 = str2.Remove(2, 6);
            Console.WriteLine("После удаления подстроки: " + modif2);
            //Работа с пустой и null строкой
            Console.WriteLine("Проверка на пустоту: ");
            string str4 = null;
            string str5 = "";
            Console.WriteLine(string.IsNullOrEmpty(str4));
            Console.WriteLine(string.IsNullOrEmpty(str5));
            //Работа со строкой на основе StringBuilder
            StringBuilder sb = new StringBuilder("Мой дом — душа, и всё, что в нем есть — я.");
            Console.WriteLine("Исходная строка: " + sb);
            sb.Remove(4, 20);
            Console.WriteLine("Удаляем определенную позицию: " + sb);
            sb.Insert(0, "Цитата: ");
            sb.Insert(30, " Автор:Айшек Норам.");
            Console.WriteLine("Добавляем новые символы в начало и конец строки: " + sb);
            //Массивы
            int[,] nums2 = new int [5,4];
            Random rn = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    nums2[i, j] = rn.Next(1, 15);
                    Console.Write("{0}\t", nums2[i, j]);
                }
                Console.WriteLine();
            }
            // одномерный массив строк
            string[] str = { "apple", "strawberry", "banana" };
            int length = str.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write(str[i] + "\t");
            }
            Console.Write("\nДлина массива: " + length + "\n");
            Int32 g = Convert.ToInt32(Console.ReadLine());
            Int32 k = Convert.ToInt32(Console.ReadLine());
            string temp1 = str[g];
            str[g] = str[k];
            str[k] = temp1;
            Console.WriteLine("Замена элементов местами: ",g,k);
            for(Int32 i = 0; i < length; i++)
            {
                Console.Write("{0} ", str[i]);
            }
            Console.WriteLine();
            //ступенчатый массив
            // объявляем ступенчатый массив
            int[][] myArr = new int[3][];
            myArr[0] = new int[2];
            myArr[1] = new int[3];
            myArr[2] = new int[4];
            //заполняем ступенчатый массив
            for (int i = 0; i < myArr.Length; i++)
            {
                for (int j = 0; j < myArr[i].Length; j++)
                {
                    Console.Write($"myArr[{i}][{j}] = ");
                    myArr[i][j] = int.Parse(Console.ReadLine());
                }
            }
            //выводим массив
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine(string.Join(" ", myArr[i]));
            }
            Console.WriteLine();
            //неявно типизированные переменные для хранения массива и строки
            var arr = new object[0];
            var stn = "";
            //Кортежи
            (int, string, char, string, ulong) tp = (1654, "Zhlobin", 'a', "city", 249210);
            Console.WriteLine(tp);
            Console.WriteLine(tp.Item1);
            Console.WriteLine(tp.Item3);
            Console.WriteLine(tp.Item4);
            //Pаспаковкa кортежа в переменные
            var w = ("123", 456);
            (string onetwothree, double fourfivesix) = w;
            Console.WriteLine($"{onetwothree} , {fourfivesix}");
            Console.WriteLine();
            //сравнение двух кортежей
            var yung = (3, 14, 21);
            var yung2 = (5, 12, 41);
            Console.WriteLine(yung == yung2);
            Console.WriteLine(yung != yung2);
            //локальная ф-ция
            LocalFunc(args);
        }
        static void LocalFunc(string[] args)
        {
            int[] a = new int[] { 32, 4, 19, 2, 5 };
            string s = "Kulakova";
            var tuple = GetValues(a, s);
            Console.WriteLine($"Максимальный элемент: {tuple.Max}");
            Console.WriteLine($"Минимальный элемент: {tuple.Min}");
            Console.WriteLine($"Сумма элементов: {tuple.Sum}");
            Console.WriteLine($"Первый символ строки: {tuple.First}");
            Console.ReadKey();
        }
        private static (int Max, int Min, int Sum, string First) GetValues(int[] a, string s)
        {

            var result = (Max: a[0], Min: a[0], Sum: 0, First: "");
            result.First = s.Remove(1); //вырезаем 1 букву из строки
            for (int i = 0; i < a.Length; i++)
            {
                result.Sum += a[i];
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (result.Max < a[i])
                {
                    result.Max = a[i];
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (result.Min > a[i])
                {
                    result.Min = a[i];
                }
            }
            return result;
        }
    }
}
