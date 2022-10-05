// // Урок 2. Массивы и функции в программировании

// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

// Console.WriteLine ("Задача 10: \n Напишите программу, которая принимает на вход трёхзначное число \n и на выходе показывает вторую цифру этого числа.");
// Console.WriteLine();

// Console.WriteLine ("Решение:");
// Console.WriteLine();

// int VtorayaCifraChisla (int chisloN)
// {
//     int rezultat = (chisloN % 100) /10;

//     return rezultat;

// }

// Console.Write("Введите трехзначное число ");
// int chisloPolzovatelya = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(VtorayaCifraChisla(chisloPolzovatelya));

// // Задача 10 завершена ----------------------------------
 

// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6

// Console.WriteLine("// Задача 13: \n Напишите программу, которая выводит третью цифру заданного числа \n или сообщает, что третьей цифры нет.");
// Console.WriteLine();

// Console.WriteLine("Решение:");

// int TretiyaCifraChisla (int chisloN)
// {
// string stroka = Convert.ToString(chisloN);
// string result = stroka.Substring(2, Math.Min(stroka.Length, 1));

//     return Convert.ToInt32(result);

// }

// Console.Write("Введите число ");
// int chisloPolzovatelya = Convert.ToInt32(Console.ReadLine());

// string chisloVtext = Convert.ToString(chisloPolzovatelya);

// if (chisloVtext.Length > 2) {

//     Console.Write(TretiyaCifraChisla (chisloPolzovatelya));

// }
// else
// {
//     Console.Write("Число не трехзначное, третьей цифры нет!");    
// }

// // Задача 13 завершена ----------------------------------

// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// // 6 -> да
// // 7 -> да
// // 1 -> нет

// Console.WriteLine("Задача 15: \n Напишите программу, которая принимает на вход цифру, обозначающую день недели, \n и проверяет, является ли этот день выходным.");
// Console.WriteLine();

// Console.WriteLine("Решение:");
// Console.WriteLine();


// string BudniyVixodnoyDen (string denNedeli)
// {    
// string messageDay = "";

//     if (denNedeli == "6" || denNedeli == "7") 
//         {
//            messageDay = "Это выходной день!";
//            return messageDay;      
            
//         }
//     else if (denNedeli == "1" || denNedeli == "2"  || denNedeli == "3" || denNedeli == "4"  || denNedeli == "5") 
//         {            
//             messageDay = "Это будний день!";   
//             return messageDay;                 
            
//         }

// return "В Неделе 7 дней, вводите числа от 1 до 7 включительно!";      

    
// }

// Console.Write("Введите число ");

// int denNedeli = Convert.ToInt32(Console.ReadLine());

// string denNedeliText = Convert.ToString(denNedeli);

// Console.Write(BudniyVixodnoyDen(denNedeliText));

// // Задача 15 завершена ----------------------------------
