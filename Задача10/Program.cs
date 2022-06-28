// Напишите программу, 
//которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.WriteLine ("введите трехзначное число число");
int num = Convert.ToInt32(Console.ReadLine());
string showNumber()
{
   int second = (num%100-num%10)/10;
   return ("Вторая цифра числа->"+second);
   };
   Console.WriteLine(showNumber());