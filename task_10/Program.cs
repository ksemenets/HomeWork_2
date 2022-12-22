/*Напишите программу,  которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.*/

Console.WriteLine("Введите 3-х значное число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = 0;

 number1 = (number / 10) % 10;

 if (number / 10 >= 10 & number /10 < 100)
    Console.WriteLine ($"Вторая цифра этого числа {number1}");
 else   
    Console.WriteLine ("Ну тебе же сказали, 3-Х ЗНАЧНОЕ");
