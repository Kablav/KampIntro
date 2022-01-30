
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "yazılım geliştirme kursu";
            string kurs2 = "programlamaya başlangıç kursu";
            string kurs3 = "java kursu";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            //"array = dizi" liste yani dizi yapmamızı sağlar. tek tek string yazmaktansa, dizi strin[] altında hepsini yazmamızı sağlar.

            string[] kurslar = new string[] { "yazılım geliştirme kursu", "programlamaya başlangıç kursu", "java kursu" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");



        }
    }
}