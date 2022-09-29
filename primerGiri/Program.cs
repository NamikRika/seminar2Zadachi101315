int[] massivGir = new int[] { 1, 20, 60, 120, 51, 6, 81, 74, 12}; // Объявляем массив гирь
int schetchij = 0; // объявили переменную счётчик
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

Console.WriteLine(samayaTyajelayaGirya);      // "вывод результата"