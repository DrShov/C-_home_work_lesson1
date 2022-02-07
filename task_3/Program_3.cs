// Выяснить является ли число чётным
Console.WriteLine("Введите число для определения его четности: ");

string str1 = Console.ReadLine();

int a = Convert.ToInt32(str1);

int b = a / 2;

if (a - b * 2 == 0)
{
    Console.WriteLine("Число четное");
}

else
{
    Console.WriteLine("Число нечетное");
}
