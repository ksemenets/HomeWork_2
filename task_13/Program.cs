/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
int Num = number;
while (Num > 0)
{
  Num = (Num / 10);
  i ++;
}
if (i < 3)
{
   Console.WriteLine ("Третьей цифры в этом числе нет");
}
else
{  i = i - 3;
while (i > 0)
{
 number = (number / 10);
 i --;
}
number = number % 10;

 Console.WriteLine (number);
 }

