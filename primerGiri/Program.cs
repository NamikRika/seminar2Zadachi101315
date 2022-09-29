int[] massivGir = new int[] { 1, 20, 60, 120, 51, 6, 81, 74, 12}; // Объявляем массив гирь
int samayaTyajelayaGirya = 0; // объявили переменную для самой тяжёлой гири

 
for (int i = 0; i < massivGir.Length; i++) // "начало цикла"
{

    if(samayaTyajelayaGirya <  massivGir[i]) // "начало условия"
    {
        samayaTyajelayaGirya = massivGir[i];
    }
    else
    {
        
    }                                         // "конец условия"


}                                            // "конец цикла"

Console.WriteLine("Самая тяжёлая гиря весит " +  samayaTyajelayaGirya + " килограмм");      // "вывод результата"

Console.Read(); // "ожидание ввода, чтобы экран консоли cmd не закрывался по исполнению программы"