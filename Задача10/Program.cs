// Напишите программу, 
//которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.WriteLine ("введите трехзначное число число");
int num1 = Convert.ToInt32(Console.ReadLine());
string showNumber(int num)
{if (num>99 && num<1000)
   {
   int second = (num%100-num%10)/10;
   return ("Вторая цифра числа->"+second);
   }else
   {
      return "введенное число не трехзначное!";
   }
}
   Console.WriteLine(showNumber(num1));