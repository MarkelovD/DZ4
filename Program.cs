// задача 1
// int VozvStep (int chislo, int stepen){ // создание метода возведение в степень
// int rez=chislo;
// for (int i=1; i<stepen;i++){// цикл перемножения на себя
//     rez*=rez;
// }
// return rez;// возврат результата
// }
// Console.WriteLine("введите число");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("введите степень числа");
// int B = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{VozvStep(A,B)}");

//задача 2
int SummaChisel(int chislo){
    int summ =0;
    while (chislo!=0){
     summ+=chislo%10;
     chislo=chislo/10;
    }
    return summ;
}
Console.WriteLine("введите число");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"сумма чисел входящих в число {A} равна {SummaChisel(A)}");