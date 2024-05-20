/*Створіть клас UkrainianStringUtils, який буде містити корисні методи для обробки рядків українською мовою.

Клас UkrainianStringUtils та методи створити статичними, тобто позначаючи модифікаторами static (с. 141-142)

1) Реалізуйте метод CountVowels, який приймає рядок і повертає кількість голосних літер у ньому.

2) CountConsonants: Метод для підрахунку кількості приголосних літер у рядку.

3) Реалізуйте метод ReverseString, який приймає рядок і повертає його обернену версію.

4) RemoveDuplicates: Метод для видалення дублікатів символів з рядка, залишаючи тільки перше входження кожного символу.

5) RemovePunctuation: Метод для видалення всіх знаків пунктуації з рядка.

Після створення бібліотеки, створіть консольну програму, яка використовує цю бібліотеку для демонстрації роботи методів.
 */


//
using MyLib;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace Lesson_11_1
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Будь ласка введіть речення: ");
            string input = Console.ReadLine();
            Console.WriteLine(UkrainianStringUtils.CountVowels(input));
            Console.WriteLine(UkrainianStringUtils.CountConsonants(input));
            Console.WriteLine(UkrainianStringUtils.ReverseString(input));
            Console.WriteLine(UkrainianStringUtils.RemovePunctuation(input));
            Console.WriteLine(UkrainianStringUtils.RemoveDuplicates(input));
            
            
        }
    }
}
