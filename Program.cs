using Newtonsoft.Json;
namespace HW_16_01_07_2024
{
//    Створіть програму для роботи з інформацією про журнал, в якій
//зберігатиметься таку інформація:
//1. Назва журналу.
//2. Назва видавництва.
//3. Дата видання.
//4. Кількість сторінок.
//Програма має бути з такою функціональністю:
//1. Введення інформації про журнал.
//2. Виведення інформації про журнал.
//3. Серіалізація журналу.
//4. Збереження серіалізованого журналу у файл.
//5. Завантаження серіалізованого журналу з файлу.Після
//завантаження потрібно виконати десеріалізацію журналу.
//Вибір певного формату серіалізації потрібно зробити вам.
//Звертаємо вашу увагу, що вибір має бути обґрунтованим.

    internal class Program
    {
        static void Main(string[] args)
        {
            string pathBIN = @".\data.bin";
            string pathXML = @".\data.xml";
            string pathJSON = @".\data.json";
            Magazine magazine = new Magazine("Science and Technology", "Knowledge Publishing", new DateTime(2024,07,01), 128);
            MySerializer mySerializer = new MySerializer();
            Console.WriteLine("=====BIN=====");
            mySerializer.SerializeBIN(magazine, pathBIN);
            Magazine magazine1 = mySerializer.DeSerializeBIN(pathBIN);
            Console.WriteLine(magazine1);
            Console.WriteLine("=====JSON=====");
            mySerializer.SerializeJSON(magazine, pathJSON);
            Magazine magazine2 = mySerializer.DeSerializeJSON(pathJSON);
            Console.WriteLine(magazine2);
            Console.WriteLine("=====XML=====");
            mySerializer.SerializeXML(magazine, pathXML);
            Magazine magazine3 = mySerializer.DeSerializeXML(pathXML);
            Console.WriteLine(magazine3);
        }
    }
}
