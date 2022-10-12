// задача 1
int VozvStep (int chislo, int stepen){ // создание метода возведение в степень
int rez=chislo;
for (int i=1; i<stepen;i++){// цикл перемножения на себя
    rez*=rez;
}
return rez;// возврат результата
}
Console.WriteLine("введите число");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите степень числа");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{VozvStep(A,B)}");