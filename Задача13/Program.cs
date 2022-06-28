//Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает, 
//что третьей цифры нет.


Console.WriteLine ("введите число");
int num = Convert.ToInt32(Console.ReadLine());
string showNumber()
{
   int i = 0;
   int n=num;
   if (n<100)
   {
    return ("третья цифра в числе отсутствует");
   }
   else
   {
   while(n>999)
   {
    n=n/10;
    i++;
    }
      
   int third = n%10;
   return ("третья цифра числа->"+third);
   }
}
   Console.WriteLine(showNumber());