// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

// // ВВодим функию
// void CutNumder(int a){ 
//     // формула нахождения
//     int result = (a / 10) %10;
//     Console.WriteLine("Вторая цифра " + result);
// }

// Console.Write("Введите трехзначное число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// // проверяем на соответствие условию 
// if (a < 100 || a > 999 )
// {
//     Console.WriteLine("Число не трехзначное!!!");
// }
// else
// {
//    CutNumder(a); 
// }


// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// // Формула проверки на выходной
// void day(int a){
//     if(a == 6 || a == 7){
//         Console.Write("Выходной");
//     }
    
//     else{
//         Console.Write("Не выходной ");
//     }
// }

// Console.Write("Введите порядковый номер дня недели: ");
// int a = Convert.ToInt32(Console.ReadLine());
// // Проверка на правильность ввода (от 1 до 7 )
// if (a < 1 || a > 7)
// {
//     Console.WriteLine("Такого дня недели нет  ");
// }
// // если ок, запускаем формулу
// else
// day(a);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// void num3(string s1){

//   Console.WriteLine("Третья цифра:" + s1[2]);

// }

// Console.Write("Введите число: ");
// string s1 = Convert.ToString(Console.ReadLine());
// char a = s1[2];
// if (a == null)
// {
//     Console.WriteLine("Третьего числа нет!   ");
// }
// else
// num3(s1);





// void num3(string s1){
//   Console.WriteLine("Третья цифра:" + s1[2]);
// }

// Console.WriteLine("Введите число: ");

//  int a = Convert.ToInt32(Console.ReadLine());
//  if (a < 100)
//  {
//    Console.WriteLine("Третьего числа нет! ");
//  }
// else{
// string s1 = Convert.ToString(Console.ReadLine());
// num3(s1);
// }