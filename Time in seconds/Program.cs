// See https://aka.ms/new-console-template for more information

byte hours, minutes, seconds;

int amount_of_seconds;

Console.WriteLine("Please enter the amount of hours: ");

string hours_str = Console.ReadLine();

hours = Convert.ToByte(hours_str);

Console.WriteLine("Please enter the amount of minutes; ");

string minutes_str = Console.ReadLine();

minutes = Convert.ToByte(minutes_str);

Console.WriteLine("Please enter the amount of seconds: ");

string seconds_str = Console.ReadLine();

seconds = Convert.ToByte(seconds_str);

amount_of_seconds = hours * 60 * 60 + minutes * 60 +seconds;

Console.WriteLine("Amount of seconds in the entered time is: " + amount_of_seconds);

Console.ReadLine();



