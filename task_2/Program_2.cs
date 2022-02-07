// Найти максимальное из трёх чисел
Console.WriteLine("Введите три числа для поиска максимального из них: ");

string str1 = Console.ReadLine();
string str2 = Console.ReadLine();
string str3 = Console.ReadLine();

int a = Convert.ToInt32(str1);
int b = Convert.ToInt32(str2);
int c = Convert.ToInt32(str3);

int MaxNumber(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int max = MaxNumber(a, b, c);
Console.WriteLine($"{max} - максимальное число");
