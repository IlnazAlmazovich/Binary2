using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Подключаем просторанство имён для работы с файлами
using System.Runtime.Remoting.Messaging;

namespace BinaryArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Пользователь\\Desktop\\Binary\\test2.txt"; //указываем путь к файлу
            // если файла test2.txt нет, то программа создаст его автоматически
            // Если нет файла с которым мы работаем, то в любых потоках он создаства автоматически

            // Создаём массив
            int[] array = { 1, 2, 3 };

            //Записываем массив в файл
            using (BinaryWriter writer = new BinaryWriter(new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite)))
            {
                foreach (int num in array)
                {
                    writer.Write(num);
                    Console.WriteLine(num);
                }
            }
            Console.WriteLine("YES");



            //Читаем массив
            using (BinaryReader read = new BinaryReader(new FileStream(path, FileMode.Open, FileAccess.Read)))
            {
                //Создаём новый массив для прочитанных данных
                int[] newAr = new int[array.Length];
                

                // перебераем и считываем массив
                for (int i = 0; i < newAr.Length; i++)
                {
                    newAr[i] = read.ReadInt32();
                }

                //выводим массив на консоль
                foreach (int num in newAr)
                {
                    Console.WriteLine(num);
                }
            }
            Console.ReadKey();
            
                                                                               
        }
    }
}
