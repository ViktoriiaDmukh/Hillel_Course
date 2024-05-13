namespace Lesson_10_1
{ /* У вас є система керування інформацією про людей. Напишіть клас «Person», який містить інформацію про людину, таку як ім'я, вік і стать. 
     Клас «Person» повинен мати наступні конструктори:

    * Конструктор, що приймає ім'я, вік та стать. Використовується, коли всі дані про людину відомі заздалегідь.
    * Конструктор, що приймає лише ім'я. При виклику цього конструктора вік встановлюється за замовчуванням (0), а стать - «не вказано».
    * Конструктор, що приймає лише ім'я та вік. При виклику цього конструктора вік встановлюється на передане значення, а стать - «не вказано».
    
     Клас «Person» також повинен містити наступні методи:

    * Метод «PrintDetails()», який виводить інформацію про людину (ім'я, вік та стать).
    * Метод «IsAdult()», який повертає true, якщо вік людини становить 18 років або більше, і false в іншому випадку.
    * Метод «ChangeName()», який дозволяє змінити ім'я людини.
    
     Напишіть клас «Person» і в «Program» створіть об'єкти типу «Person» 
     з використанням різних конструкторів та викликайте їх методи для відображення та зміни інформації про людину.
   */

    

    class Person
    {
        string firstname;
        string lastname;
        int age;
        string gender;

        public Person(string firstname, string lastname, int age, string gender)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.gender = gender;
            
        }

        public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public Person(string firstname, string lastname, int age)
        {
            this.firstname=firstname;
            this.lastname=lastname;
            this.age = age;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"First name: {firstname}\nLast name: {lastname}\nAge: {age}\nGender: {gender}");
        }
        public void IsAdult()
        {
            bool isadult;
            if ( age >= 18 )
            {
                Console.WriteLine("This person is adult");
            }
        }
        public void ChangeName(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Person person = new Person("Viktoriia", "Dmukh", 33, "female");
           person.PrintDetails();
           Console.WriteLine();
           person.IsAdult();
           Person person2 = new Person("Vadym", "Bened");
           person2.PrintDetails();
           Console.WriteLine();
           Person person3 = new Person("Alla", "Sapunkova", 33);
           person3.PrintDetails();
           person3.IsAdult();
           
         
           person.ChangeName("Viktoriia", "Sapunkova");
        }
    }
}
