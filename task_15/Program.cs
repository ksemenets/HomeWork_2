/* Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным..*/

Console.WriteLine("Введите цифру от 1 до 7, которая определяет день недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7)
Console.WriteLine ("Вы ввели не верные данные");
else
if (number == 6 || number == 7)

   {
   Console.WriteLine ("Этот день выходной");
   }
else 
   {  
   Console.WriteLine ("Этот день рабочий");
   }
   