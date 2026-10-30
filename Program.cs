using System;
namespace Pr3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Задание 1\n");
            //Console.Write("Ведите трёхзначное число: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i0 = n % 10;
            //int i1 = ((n - 1) / 10) % 10;
            //int i2 = (n - i0 - i1) / 100;
            //Console.WriteLine($"{i0}{i1}{i2}");


            //Console.WriteLine("Задание 2\n");
            //string? s1, s2, s3, s4, s5;
            //Console.Write("Введите слово №1: ");
            //s1 = Console.ReadLine();
            //Console.Write("Введите слово №2: ");
            //s2 = Console.ReadLine();
            //Console.Write("Введите слово №3: ");
            //s3 = Console.ReadLine();
            //Console.Write("Введите слово №4: ");
            //s4 = Console.ReadLine();
            //Console.Write("Введите слово №5: ");
            //s5 = Console.ReadLine();
            //Console.WriteLine($"Длина слова №1 = {s1.Length};");
            //Console.WriteLine($"Длина слова №2 = {s2.Length};");
            //Console.WriteLine($"Длина слова №3 = {s3.Length};");
            //Console.WriteLine($"Длина слова №4 = {s4.Length};");
            //Console.WriteLine($"Длина слова №5 = {s5.Length};");

            //Console.WriteLine("Задание 3\n");
            //int N_door, N_window;
            //double S_oboi;
            //double room_length, room_width, room_H, door_width, door_H, window_witdth, window_H;
            //Console.WriteLine("Введите длину комнаты: ");
            //room_length =  Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите ширину комнаты: ");
            //room_width = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите высоту комнаты: ");
            //room_H = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите количество окон: ");
            //N_window = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите количество дверей: ");
            //N_door = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите ширину окна: ");
            //window_witdth = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите высоту окна: ");
            //window_H = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите ширину двери: ");
            //door_width = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите высоту двери: ");
            //door_H = Convert.ToDouble(Console.ReadLine());
            //S_oboi = 2 * (room_length * room_H + room_width * room_H);
            //S_oboi -= N_window * ( window_witdth *  window_H );
            //S_oboi -= N_door * (door_width * door_H);
            //Console.WriteLine($"\nПлощадь обоев = {S_oboi} (квад.см)");
            //
            //Console.WriteLine("Задание 4\n");
            //string? str1, str2, str3, str4 , str5;
            //Console.WriteLine("Введите 1-ое слово: ");
            //str1 = Console.ReadLine();
            //Console.WriteLine("Введите 2-ое слово: ");
            //str2 = Console.ReadLine(); 
            //Console.WriteLine("Введите 3-ое слово: ");
            //str3 = Console.ReadLine(); 
            //Console.WriteLine("Введите 4-ое слово: ");
            //str4 = Console.ReadLine(); 
            //Console.WriteLine("Введите 5-ое слово: ");
            //str5 = Console.ReadLine();
            //int sum_str = str1.Length + str2.Length + str3.Length + str4.Length + str5.Length;
            //Console.WriteLine($"сумарная длина 5 слов = {sum_str}");
            //
            //Console.WriteLine("Задание 5 (1 вар)\n");
            //Console.WriteLine("Введите целое число  больше 9");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = n % 10;
            //n /= 10;
            //sum += n % 10;
            //Console.WriteLine($"{sum}");

            Console.WriteLine("Задание 6 (1 вар)\n");
            Console.WriteLine("ведите количество хвойных деревьев: ");
            int n_hvoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ведите количество Лиственных деревьев: ");
            int n_listv = Convert.ToInt32(Console.ReadLine());
            double procent = ((n_listv / (double)(n_hvoi + n_listv))) * 100;
            Console.WriteLine($"Процент листеных деревьев = {procent}%");


        }
    }
}