
// Начало задачи 8

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int chisloN = 0; // Obyavlayem peremenniye 
int i = 0; // Peremennaya schetchik cikla
int rezultatDeleniya = 0;
string rezultatZadachi = "";

Console.Write("Задача 6: \n Напишите программу, которая на вход принимает число (N) \n а на выходе показывает все чётные числа от 1 до N.");

Console.Write("\n"); // "для создание оступов между строками"
Console.Write("\n");

Console.Write("Решение:");

Console.Write("\n");// "для создание оступов между строками"
Console.Write("\n");

Console.Write("Задайте любое число ");
chisloN = Convert.ToInt32(Console.ReadLine()); // "Принимаем данные от пользователя"

for (i = 1; i < chisloN + 1; i++) // "начало цикла"
{
    rezultatDeleniya =  i % 2 ;
    if( rezultatDeleniya == 0) // "начало условия"  / здесь проверяем чётное ли число
    {
        rezultatZadachi = rezultatZadachi + i.ToString() + ", " ; // здесь присваиваем значение переменной в случае четности числа
    }
    else
    {
        
    }                                         // "конец условия"


}                                            // "конец цикла"

Console.Write(rezultatZadachi);

// задача 8 завершена. ------------------------------------------------------------------------