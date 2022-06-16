// Таблица квадратов чисел от 1 до N.


Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int i = 1;

while (N >= i)
{
    int result = (int) Math.Pow(i, 2);
    Console.Write(result + ", ");
    i++;
}