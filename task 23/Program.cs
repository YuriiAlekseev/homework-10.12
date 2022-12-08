// Напишите программу, которая принимает на вход число (N) и
//  выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

    Console.WriteLine("Введите число N: ");
    int num = int.Parse(Console.ReadLine());
    Console.Write("таблица кубов чисел от 1 до "+num+" = ");
    int i = 1;
    while (i <= num) 
    {
        int result = i * i * i;
        Console.Write(result+ ", ");
        i++;
    }
