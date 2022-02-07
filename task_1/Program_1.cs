// Даны два числа. Показать большее и меньшее число
Console.WriteLine("Введите два числа для сравнения: ");

string str1 = Console.ReadLine();
string str2 = Console.ReadLine();

int a = Convert.ToInt32(str1);
int b = Convert.ToInt32(str2);

int MaxNumber(int arg1, int arg2)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    return result;
}

int MinNumber(int arg1, int arg2)
{
    int result = arg1;
    if (arg2 < result) result = arg2;
    return result;
}

int max = MaxNumber(a, b);
int min = MinNumber(a, b);
Console.WriteLine($"{max} больше {min}");
