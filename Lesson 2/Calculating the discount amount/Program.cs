// See https://aka.ms/new-console-template for more information


ushort price, discount;

Console.WriteLine("Please enter the price of the product: ");

string price_str = Console.ReadLine();

price = Convert.ToUInt16(price_str);

Console.WriteLine("Please enter the discount amount: ");

string discount_str = Console.ReadLine();

discount = Convert.ToUInt16(discount_str);

Console.WriteLine("Current price is " + (System.Math.Round((double)(price - (price * discount/100)))));

Console.ReadLine();

