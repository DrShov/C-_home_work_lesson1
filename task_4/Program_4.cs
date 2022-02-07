// Показать чётные числа от 1 до N

Console.WriteLine("Программа показывает четные числа от 1 до N. Введите желаемое число N: ");

string str1 = Console.ReadLine();

int n = Convert.ToInt32(str1);

int a = 2;

while (n > a)
{
    Console.Write(a);
    Console.Write(" ");
    a = a + 2;

}

