using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Подключаем просторанство имён для работы с файлами
using static System.Net.Mime.MediaTypeNames;

namespace Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Пользователь\\Desktop\\Binary\\test.txt"; //указываем путь к файлу

            //Запись в файл
            using (BinaryWriter bw = new BinaryWriter(new FileStream(path,FileMode.OpenOrCreate))) // создаём поток для записи
           //Использование BinaryWriter с FileStream упрощает преобразование данных различных типов в бинарный формат,
           //что позволяет сохранить эти данные в файле. Это особенно полезно, когда необходимо сохранить структурированные данные,
           //которые могут быть легко восстановлены позднее.
            {
                // Данные для записи
                string text = "Расцветали яблони и груши,\r\nПоплыли туманы над рекой.\r\nВыходила на берег Катюша,\r\nНа высокий берег на крутой.\r\nВыходила, песню заводила\r\nПро степного сизого орла,\r\nПро того, которого любила,\r\nПро того, чьи письма берегла.";
                int group = 228;
                double txt = 22.8;
                //Записываем данные
                bw.Write(text);
                bw.Write(group);
                bw.Write(txt);

                Console.WriteLine("Данные которые записались: \n");
                Console.WriteLine(text);
                Console.WriteLine(group);
                Console.WriteLine(txt);
                Console.WriteLine();
                Console.WriteLine();
            }

            //Чтение из файла
            using (BinaryReader br = new BinaryReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read)))//Создаём поток для чтения
            {
                Console.WriteLine("Данные из файла: ");
                Console.WriteLine(br.ReadString()); // считываем данные типа string
                Console.WriteLine(br.ReadInt32()); // считываем данные типа int
                Console.WriteLine(br.ReadDouble()); // считываем данные типа double
            }
            Console.ReadKey();
        }
    }
}
