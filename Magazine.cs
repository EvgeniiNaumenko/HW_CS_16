using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;
//    Створіть програму для роботи з інформацією про журнал, в якій
//зберігатиметься таку інформація:
//1. Назва журналу.+
//2. Назва видавництва.+
//3. Дата видання.+
//4. Кількість сторінок.+
//Програма має бути з такою функціональністю:
//1. Введення інформації про журнал.+
//2. Виведення інформації про журнал.+
//3. Серіалізація журналу.
//4. Збереження серіалізованого журналу у файл.
//5. Завантаження серіалізованого журналу з файлу.Після
//завантаження потрібно виконати десеріалізацію журналу.
//Вибір певного формату серіалізації потрібно зробити вам.
//Звертаємо вашу увагу, що вибір має бути обґрунтованим.
namespace HW_16_01_07_2024
{
    [Serializable]
    public class Magazine
    {
        public string Name {  get; set; }
        public string PublHouse {  get; set; }
        public DateTime Date { get; set; }
        public int NumPages { get; set; }
        public Magazine() { }
        public Magazine(string name, string publHouse, DateTime date, int numPages)
        {
            Name = name;
            PublHouse = publHouse;
            Date = date;
            NumPages = numPages;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nPublishing house: {PublHouse}\nPublishing date: {Date}\nNumber of pages: {NumPages}";
        }
        public void setInfo (string name, string publHouse, DateTime date, int numPages)
        {
            Name = name ;
            PublHouse = publHouse ;
            Date = date ;
            NumPages = numPages ;
        }
    }
}
