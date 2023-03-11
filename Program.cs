//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

//оператор инкремента ++ для увел. на 1


int number = Prompt("Введите натуральное число");

if (number>0) PrintSqr (number);
else Console.WriteLine("Введено не натуральное число");

void PrintSqr(int n)
{
    Console.WriteLine("Число     Квадрат числа");
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i,5} {i*i*i, 5}");
    }
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int cc = Convert.ToInt32(Console.ReadLine());
    return cc;
}
