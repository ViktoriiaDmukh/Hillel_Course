using System.ComponentModel;

namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Створіть програму для каси у магазині, яка обчислює вартість товарів у кошику. 
             * Програма має використовувати перерахування (enum) для представлення типів товарів (Food, Clothing, Electronics, Books) 
             * та повинна дозволяти користувачу вводити тип та ціну кожного товару.
             * Після введення кожного товару програма повинна виводити загальну вартість товарів у кошику.
             * 
             * 1.Програма повинна починати з нульовою загальною вартістю товарів у кошику.
             * 2. Програма повинна запитувати користувача ввести тип товару (їжа, одяг, електроніка, книги) та ціну товару.
             * 3. Після введення кожного товару програма має додавати ціну товару до загальної вартості у кошику.
             * 4. Програма повинна продовжувати запитувати користувача про нові товари до тих пір, поки користувач не вирішить припинити введення.
             * 
             * - Додайте можливість вибору опції для додавання нового товару або завершення введення.
             * - Виведіть меню з опціями на екрані, щоб користувач міг легко вибрати потрібну дію.
             * - Після завершення введення виведіть на екран рахунок з деталізацією кожного товару та загальною вартістю.
             */

            //1. Привітатись з покупцем
            //2. Показати вміст кошика з позначкою 0
            //3. Вивести в меню який товар покупець хоче додати до кошика
            //4. Виводити меню зі змогою закінчити програму або додавати новий товар
            //5. Дати змогу покупцю додати товар і автоматично його додавати до кошика і рахувати вартість продуктової корзини
            //6. Після завершення додавання товарів до кошика вивести на екан які товари були додані, скільки вони коштують та загальну вартість покупки

            Console.OutputEncoding = System.Text.Encoding.Unicode;           

            double price;
            TypeProducts typeProducts;
            Actions exit = Actions.Exit;
                        
            double shoppingCart = 0;

            Console.WriteLine("Welcome to our store! Have a nice shopping!)");
           
            
            do
            {
                Console.WriteLine($"\n\n Total amount in your shopping cart is: {shoppingCart}");
                Console.Write("\n\n Please, choose available products or exit: (1) Clothing, (2) Electronics, (3) Books, (4) Food, (5) Exit: ");
                while (!Enum.TryParse(Console.ReadLine(), out typeProducts) || !Enum.IsDefined(typeof(TypeProducts), typeProducts))
                {
                    while (!Enum.TryParse(Console.ReadLine(), out exit) || !Enum.IsDefined(typeof(TypeProducts), exit))
                    {
                        Console.Write("Invalid input! Please, try again: ");
                    }


                }

                Console.Write("\n\n Please indicate the price of the selected item: ");

                while (!double.TryParse(Console.ReadLine(), out price))
                {
                    Console.Write("Entering the price was unsuccessful, please try again: ");
                }

                shoppingCart = CalculateAmount(price, typeProducts, exit);
            }
            while (!Enum.TryParse(Console.ReadLine(), out exit));
           

            Console.WriteLine("\n Products: {0}  -  {1}", typeProducts, price);

        }

        private static double CalculateAmount(double price, TypeProducts typeProducts, Actions exit)
        {
            double amount = 0;
            switch(typeProducts)
            {
                case TypeProducts.Clothing:
                    amount += price;
                    break;
                case TypeProducts.Electronics:
                    amount += price;
                    break;
                case TypeProducts.Books:
                    amount += price;
                    break;
                case TypeProducts.Food:
                    amount += price;
                    break;
                case (TypeProducts)Actions.Exit:
                    break;
                default:
                    Console.Write("Error!");
                    break;
            }
            return amount;

            Console.WriteLine();
        }
    }
}
